using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataCollections;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataObject;
using Maple.UnityAssistant.Resource;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Maple.JinGu.Metadata
{
    public partial class GameResourceCache(GameMetadataContext context)
    {

        public GameMetadataContext Context { get; } = context;
        public ILogger Logger => Context.Logger;
        public required GameCurrencyResource[] CurrencyResources { get; init; }
        public bool TryGetCurrencyResource(string? category, string objectId, [MaybeNullWhen(false)] out GameCurrencyResource resource)
        {
            resource = this.CurrencyResources.FirstOrDefault(r => r.DisplayCategory == category && r.ObjectId == objectId);
            return resource is not null;
        }

        public required GameInventoryResource[] InventoryResources { get; init; }
        public bool TryGetInventoryResource(string? category, string objectId, [MaybeNullWhen(false)] out GameInventoryResource resource)
        {
            resource = this.InventoryResources.FirstOrDefault(r => r.DisplayCategory == category && r.ObjectId == objectId);
            return resource is not null;
        }
        public required GameMonsterResourceEx[] AllNPCResources { get; init; }
        public required GameMonsterResourceEx[] NPCResources { get; init; }  


        public bool TryGetNPCResource(string? category, string objectId, [MaybeNullWhen(false)] out GameMonsterResource resource)
        {
            resource = this.NPCResources.FirstOrDefault(r => r.DisplayCategory == category && r.ObjectId == objectId);
            return resource is not null;
        }

        //  public required GameObjectResource[] BookResources { get; init; }
        //public static GameObjectResource? GetBookResource(int bookId, GameObjectResource[] bookResources)
        //{
        //    return bookResources.FirstOrDefault(r => bookId == r.ID);
        //}
        public required GameSkillResource[] SkillResources { get; init; }

        public SaveManager.Ptr_SaveManager PtrSaveManager { get; init; }

        SerializedHashSetGeneric<int>? SerializedHashSet_Metadata { get; set; }
        SerializedDictionaryGeneric<int, NpcInfo.Ptr_NpcInfo>? SerializedDictionary_Metadata { get; set; }
        private void InitMetadata(SaveData.Ptr_SaveData ptr_SaveData)
        {
            if (ptr_SaveData == false)
            {
                return;
            }

            var runtimeContext = this.Context.RuntimeContext;

            if (SerializedHashSet_Metadata is null)
            {
                if (runtimeContext.TryGetOrAddClassMetadata(new PMonoObject(ptr_SaveData.M_GLOBAL_BUFF_HASH), out var metadataCollection1))
                {
                    SerializedHashSet_Metadata = new SerializedHashSetGeneric<int>(this.Context.RuntimeContext, metadataCollection1);
                }
            }

            if (SerializedDictionary_Metadata is null)
            {
                if (runtimeContext.TryGetOrAddClassMetadata(new PMonoObject(ptr_SaveData.M_NPC_DIC), out var metadataCollection2))
                {
                    SerializedDictionary_Metadata = new SerializedDictionaryGeneric<int, NpcInfo.Ptr_NpcInfo>(this.Context.RuntimeContext, metadataCollection2);
                }
            }

        }
        public bool TryGetSaveData(out SaveData.Ptr_SaveData ptr_SaveData)
        {
            ptr_SaveData = this.PtrSaveManager.M_SAVE_DATA;
            InitMetadata(ptr_SaveData);
            return ptr_SaveData;
        }

        public static GameResourceCache Create(GameMetadataContext context)
        {
            SpinWait.SpinUntil(() => SaveManager.Ptr_SaveManager._INSTANCE != nint.Zero);

            GameCurrencyResource[] currencyResources = [.. LoadCurrencyResources(context)];
            foreach (var item in currencyResources)
            {
                context.Logger.LogInformation("Loaded Currency Resource:{DisplayCategory} {Name} ({Id})", item.DisplayCategory, item.DisplayName, item.ObjectId);
            }
            GameInventoryResource[] inventoryResources = [.. LoadInventoryResources(context)];
            foreach (var item in inventoryResources)
            {
                context.Logger.LogInformation("Loaded Inventory Resource:{DisplayCategory} {Name} ({Id})", item.DisplayCategory, item.DisplayName, item.ObjectId);
            }

            GameSkillResource[] skillResources = [
                .. LoadAchieveResources(context),
                .. LoadSkillResources(context),
                .. LoadWuXueResources(context),
                .. LoadPassiveResources(context),
                .. LoadEffectResources(context),
                .. LoadGlobalBuffResources(context)];
            foreach (var item in skillResources)
            {
                context.Logger.LogInformation("Loaded Skill Resource:{DisplayCategory} {Name} ({Id})", item.DisplayCategory, item.DisplayName, item.ObjectId);
            }



            GameMonsterResourceEx[] allNpcResources = [.. LoadCharacterResourcesEx(context, skillResources)];
            foreach (var item in allNpcResources)
            {
                context.Logger.LogInformation("Loaded Monster Resource:{DisplayCategory} {Name} ({Id})", item.DisplayCategory, item.DisplayName, item.ObjectId);
            }
            return new GameResourceCache(context)
            {
                CurrencyResources = currencyResources,
                InventoryResources = inventoryResources,
                AllNPCResources = allNpcResources,
                NPCResources = [.. allNpcResources.Where(r =>  r.CharacterPointer != nint.Zero)],
                SkillResources = skillResources,

                PtrSaveManager = SaveManager.Ptr_SaveManager._INSTANCE,
            };
        }
        static IEnumerable<GameCurrencyResource> LoadCurrencyResources(GameMetadataContext context)
        {
            //移除轮回点,好像修改不了
            var itemIdArray = Enum.GetValues<ItemId>().Where(p => p != ItemId.轮回点 && p != ItemId.天数龟甲);
            var itemDIC = Item.Ptr_Item.GET_DIC();
            foreach (var item in itemDIC.AsRefEnumerable())
            {
                var itemPtr = item.Value;
                var id = itemPtr.M_ID;

                if (!itemIdArray.Contains((ItemId)id))
                {
                    continue;
                }
                var itemName = LanguageUtils.Ptr_LanguageUtils.GET_STR(itemPtr.M_NAME);
                var itemDesc = LanguageUtils.Ptr_LanguageUtils.GET_STR(itemPtr.M_DESCRIBE);
                ItemType itemType = (ItemType)itemPtr.M_TYPE;
                ItemType2 itemType2 = (ItemType2)itemPtr.M_TYPE2;
                var itemTypeFullName = $"{itemType}.{itemType2}";
                yield return new GameCurrencyResource
                {
                    ObjectId = itemPtr.Ptr.ToString(),
                    ObjectPointer = itemPtr.Ptr,
                    DisplayName = itemName.ToString(),
                    DisplayDesc = itemDesc.ToString(),
                    DisplayCategory = itemTypeFullName,
                };
            }

        }
        static IEnumerable<GameInventoryResource> LoadInventoryResources(GameMetadataContext context)
        {
            var itemIdArray = Enum.GetValues<ItemId>();
            var itemDIC = Item.Ptr_Item.GET_DIC();
            foreach (var item in itemDIC.AsRefEnumerable())
            {
                var itemPtr = item.Value;
                var id = itemPtr.M_ID;
                if (itemIdArray.Contains((ItemId)id))
                {
                    continue;
                }
                var itemName = LanguageUtils.Ptr_LanguageUtils.GET_STR(itemPtr.M_NAME);
                var itemDesc = LanguageUtils.Ptr_LanguageUtils.GET_STR(itemPtr.M_DESCRIBE);
                ItemType itemType = (ItemType)itemPtr.M_TYPE;
                ItemType2 itemType2 = (ItemType2)itemPtr.M_TYPE2;
                var itemTypeFullName = $"{itemType}.{itemType2}";
                yield return new GameInventoryResource
                {
                    ObjectId = itemPtr.Ptr.ToString(),
                    ObjectPointer = itemPtr.Ptr,
                    DisplayName = itemName.ToString(),
                    DisplayDesc = itemDesc.ToString(),
                    DisplayCategory = itemTypeFullName,
                };
            }

        }

        static IEnumerable<GameSkillResource> LoadAchieveResources(GameMetadataContext context)
        {

            var achieveDIC = Achieve.Ptr_Achieve.GET_DIC();
            foreach (var achieve in achieveDIC.AsRefEnumerable())
            {
                var achievePtr = achieve.Value;
                var achieveName = LanguageUtils.Ptr_LanguageUtils.GET_STR(achievePtr.M_NAME);
                var achieveDesc = LanguageUtils.Ptr_LanguageUtils.GET_STR(achievePtr.M_DESC);
                //var achieveType = LanguageUtils.Ptr_LanguageUtils.GET_STR(achievePtr.M_TYPE);
                yield return new GameSkillResource
                {
                    ObjectId = achievePtr.Ptr.ToString(),
                    ObjectPointer = achievePtr.Ptr,
                    DisplayName = achieveName.ToString(),
                    DisplayDesc = achieveDesc.ToString(),
                    DisplayCategory = nameof(Achieve),
                };
            }

        }
        static IEnumerable<GameSkillResource> LoadSkillResources(GameMetadataContext context)
        {

            var skillDIC = Skill.Ptr_Skill.GET_DIC();
            foreach (var skill in skillDIC.AsRefEnumerable())
            {
                var skillPtr = skill.Value;
                var skillPtrName = LanguageUtils.Ptr_LanguageUtils.GET_STR(skillPtr.M_NAME);
                var skillPtrDesc = LanguageUtils.Ptr_LanguageUtils.GET_STR(skillPtr.M_DESC);

                yield return new GameSkillResource
                {
                    ObjectId = skillPtr.Ptr.ToString(),
                    ObjectPointer = skillPtr.Ptr,
                    DisplayName = skillPtrName.ToString(),
                    DisplayDesc = skillPtrDesc.ToString(),
                    DisplayCategory = nameof(Skill),
                };
            }

        }
        static IEnumerable<GameSkillResource> LoadWuXueResources(GameMetadataContext context)
        {

            var wuxueDIC = WuXue.Ptr_WuXue.GET_DIC();
            foreach (var wuxue in wuxueDIC.AsRefEnumerable())
            {
                var wuxuePtr = wuxue.Value;
                var wuxueName = string.Empty;// LanguageUtils.Ptr_LanguageUtils.GET_STR(wuxuePtr.M_NAME);
                var wuxueDesc = LanguageUtils.Ptr_LanguageUtils.GET_STR(wuxuePtr.M_DESC);

                yield return new GameSkillResource
                {
                    ObjectId = wuxuePtr.Ptr.ToString(),
                    ObjectPointer = wuxuePtr.Ptr,
                    DisplayName = wuxueName.ToString(),
                    DisplayDesc = wuxueDesc.ToString(),
                    DisplayCategory = nameof(WuXue),
                };
            }

        }
        static IEnumerable<GameSkillResource> LoadPassiveResources(GameMetadataContext context)
        {

            var passiveDIC = Passive.Ptr_Passive.GET_DIC();
            foreach (var passive in passiveDIC.AsRefEnumerable())
            {
                var passivePtr = passive.Value;
                var passiveName = LanguageUtils.Ptr_LanguageUtils.GET_STR(passivePtr.M_NAME);
                var passiveDesc = LanguageUtils.Ptr_LanguageUtils.GET_STR(passivePtr.M_DESC);

                yield return new GameSkillResource
                {
                    ObjectId = passivePtr.Ptr.ToString(),
                    ObjectPointer = passivePtr.Ptr,
                    DisplayName = passiveName.ToString(),
                    DisplayDesc = passiveDesc.ToString(),
                    DisplayCategory = nameof(Passive),
                };
            }

        }
        static IEnumerable<GameSkillResource> LoadEffectResources(GameMetadataContext context)
        {

            var effectDIC = Effect.Ptr_Effect.GET_DIC();
            foreach (var effect in effectDIC.AsRefEnumerable())
            {
                var effectPtr = effect.Value;
                var effectName = LanguageUtils.Ptr_LanguageUtils.GET_STR(effectPtr.M_NAME);
                var effectDesc = LanguageUtils.Ptr_LanguageUtils.GET_STR(effectPtr.M_ADD_NAME);

                yield return new GameSkillResource
                {
                    ObjectId = effectPtr.Ptr.ToString(),
                    ObjectPointer = effectPtr.Ptr,
                    DisplayName = effectName.ToString(),
                    DisplayDesc = effectDesc.ToString(),
                    DisplayCategory = nameof(Effect),
                };
            }

        }

        static IEnumerable<GameSkillResource> LoadGlobalBuffResources(GameMetadataContext context)
        {

            var globalBuffDIC = GlobalBuff.Ptr_GlobalBuff.GET_DIC();
            foreach (var globalBuff in globalBuffDIC.AsRefEnumerable())
            {
                var globalBuffPtr = globalBuff.Value;
                var globalBuffName = LanguageUtils.Ptr_LanguageUtils.GET_STR(globalBuffPtr.M_NAME);
                var globalBuffDesc = LanguageUtils.Ptr_LanguageUtils.GET_STR(globalBuffPtr.M_DESC);

                yield return new GameSkillResource
                {
                    ObjectId = globalBuffPtr.Ptr.ToString(),
                    ObjectPointer = globalBuffPtr.Ptr,
                    DisplayName = globalBuffName.ToString(),
                    DisplayDesc = globalBuffDesc.ToString(),
                    DisplayCategory = nameof(GlobalBuff),
                };
            }

        }


        static IEnumerable<GameObjectResource> LoadBookResources(GameMetadataContext context)
        {
            var bookDIC = Book.Ptr_Book.GET_DIC();
            foreach (var book in bookDIC.AsRefEnumerable())
            {
                var bookPtr = book.Value;
                var bookName = LanguageUtils.Ptr_LanguageUtils.GET_STR(bookPtr.M_NAME);
                var bookDesc = LanguageUtils.Ptr_LanguageUtils.GET_STR(bookPtr.M_DESC);
                var bookType = nameof(Book);
                yield return new GameObjectResource
                {
                    ObjectId = bookPtr.Ptr.ToString(),
                    ID = bookPtr.M_ID,
                    ObjectPointer = bookPtr.Ptr,
                    DisplayName = bookName.ToString(),
                    DisplayDesc = bookDesc.ToString(),
                    DisplayCategory = bookType,
                };
            }

        }
        static IEnumerable<GameMonsterResource> LoadNPCResources(GameMetadataContext context)
        {
            var npcDIC = Npc.Ptr_Npc.GET_DIC();
            foreach (var npc in npcDIC.AsRefEnumerable())
            {
                var npcPtr = npc.Value;
                var npcType = (NpcCamp)npcPtr.M_GROUP;
                //   var npcId = npcPtr.M_ID;
                yield return new GameMonsterResource
                {
                    ObjectId = npcPtr.Ptr.ToString(),
                    //  ID = npcId,
                    ObjectPointer = npcPtr.Ptr,
                    DisplayCategory = npcType.ToString(),
                };
            }

        }
        static IEnumerable<GameMonsterResource> LoadMonsterResources(GameMetadataContext context)
        {
            var monsterDIC = Monster.Ptr_Monster.GET_DIC();
            foreach (var monster in monsterDIC.AsRefEnumerable())
            {
                var monsterPtr = monster.Value;
                var monsterName = LanguageUtils.Ptr_LanguageUtils.GET_STR(monsterPtr.M_NAME);
                //    var monsterDesc = LanguageUtils.Ptr_LanguageUtils.GET_STR(monsterPtr.M_DESC);
                var monsterType = nameof(Monster);
                yield return new GameMonsterResource
                {
                    ObjectId = monsterPtr.Ptr.ToString(),
                    ObjectPointer = monsterPtr.Ptr,
                    DisplayName = monsterName.ToString(),
                    //  DisplayDesc = monsterDesc.ToString(),
                    DisplayCategory = monsterType,
                };
            }
        }

        //static IEnumerable<GameObjectResource> LoadFriendResources(GameMetadataContext context)
        //{
        //    var friendDIC = Friend.Ptr_Friend.GET_DIC();
        //    foreach (var friend in friendDIC.AsRefEnumerable())
        //    {
        //        var friendPtr = friend.Value;
        //         var friendType = nameof(Friend);
        //        var friendId = friendPtr.M_NPC_ID;
        //        yield return new GameObjectResource
        //        {
        //            ObjectId = friendPtr.Ptr.ToString(),
        //            ObjectPointer = friendPtr.Ptr,
        //            ID = friendId,  
        //            //  DisplayName = friendName.ToString(),
        //            //  DisplayDesc = friendDesc.ToString(),
        //            DisplayCategory = friendType,
        //        };
        //    }

        //}
        //static IEnumerable<GameObjectResource> LoadAnimalResources(GameMetadataContext context)
        //{
        //    var animalDIC = Animal.Ptr_Animal.GET_DIC();
        //    foreach (var animal in animalDIC.AsRefEnumerable())
        //    {
        //        var animalPtr = animal.Value;
        //        // var animalName = LanguageUtils.Ptr_LanguageUtils.GET_STR(animalPtr.M_NAME);
        //        //    var animalDesc = LanguageUtils.Ptr_LanguageUtils.GET_STR(animalPtr.M_DESC);
        //        var animalType = nameof(Animal);
        //        var animalId = animalPtr.M_NPC_ID;
        //        yield return new GameObjectResource
        //        {
        //            ObjectId = animalPtr.Ptr.ToString(),
        //            ObjectPointer = animalPtr.Ptr,
        //            //  DisplayName = animalName.ToString(),
        //            //  DisplayDesc = animalDesc.ToString(),
        //            DisplayCategory = animalType,
        //        };
        //    }

        //}


        static IEnumerable<GameMonsterResource> LoadCharacterResources(GameMetadataContext context, GameSkillResource[] skills, GameObjectResource[] bookResources)
        {
            var characterDIC = Character.Ptr_Character.GET_DIC();
            foreach (var character in characterDIC.AsRefEnumerable())
            {
                var characterPtr = character.Value;
                var bookId = characterPtr.M_BOOK;
                var bookData = bookResources.FirstOrDefault(b => b.ID == bookId);

                var characterName = bookData?.DisplayName;
                ////  var characterChengHao = LanguageUtils.Ptr_LanguageUtils.GET_STR(characterPtr.M_CHENG_HAO);

                var characterDesc = bookData?.DisplayDesc;
                var characterType = nameof(Character);

                GameSkillInfoDTO[] skillInfos = [.. GetGameSkills(skills, characterPtr.M_SKILLS), .. GetGamePassiveSkills(skills, characterPtr.M_PASSIVES)];

                yield return new GameMonsterResource
                {
                    ObjectId = characterPtr.Ptr.ToString(),
                    ObjectPointer = characterPtr.Ptr,
                    DisplayName = characterName,
                    DisplayDesc = characterDesc,
                    DisplayCategory = characterType.ToString(),
                    MonsterAttributes = [
                        new GameValueInfoDTO(){ ObjectId = nameof(characterPtr.M_HP), DisplayName = nameof(characterPtr.M_HP), IntValue = characterPtr.M_HP },
                        new GameValueInfoDTO(){ ObjectId = nameof(characterPtr.M_MP), DisplayName = nameof(characterPtr.M_MP), IntValue = characterPtr.M_MP },
                        new GameValueInfoDTO(){ ObjectId = nameof(characterPtr.M_DAMAGE), DisplayName = nameof(characterPtr.M_DAMAGE), IntValue = characterPtr.M_DAMAGE },
                        new GameValueInfoDTO(){ ObjectId = nameof(characterPtr.M_ATK), DisplayName = nameof(characterPtr.M_ATK), IntValue = characterPtr.M_ATK },
                        new GameValueInfoDTO(){ ObjectId = nameof(characterPtr.M_DEF), DisplayName = nameof(characterPtr.M_DEF), IntValue = characterPtr.M_DEF },
                        new GameValueInfoDTO(){ ObjectId = nameof(characterPtr.M_CRT), DisplayName = nameof(characterPtr.M_CRT), IntValue = characterPtr.M_CRT },
                        new GameValueInfoDTO(){ ObjectId = nameof(characterPtr.M_EVA), DisplayName = nameof(characterPtr.M_EVA), IntValue = characterPtr.M_EVA },
                        new GameValueInfoDTO(){ ObjectId = nameof(characterPtr.M_SPEED), DisplayName = nameof(characterPtr.M_SPEED), IntValue = characterPtr.M_SPEED },
                        new GameValueInfoDTO(){ ObjectId = nameof(characterPtr.M_MOVE), DisplayName = nameof(characterPtr.M_MOVE), IntValue = characterPtr.M_MOVE },
                        new GameValueInfoDTO(){ ObjectId = nameof(characterPtr.M_RANGE), DisplayName = nameof(characterPtr.M_RANGE), IntValue = characterPtr.M_RANGE },
                        //new GameValueInfoDTO(){ ObjectId = nameof(characterPtr.M_ATK_SCOPE), DisplayName = nameof(characterPtr.M_ATK_SCOPE), IntValue = characterPtr.M_ATK_SCOPE },

                        ],
                    SkillInfos = skillInfos,
                };
            }

        }


        public static bool TryGetCharacter(GameMonsterResource[] monsterResources, int characterId, out GameMonsterResource characterData)
        {
            Unsafe.SkipInit(out characterData);
            foreach (var character in monsterResources)
            {
                var characterPtr = new CharacterData.Ptr_CharacterData(character.ObjectPointer);
                if (characterPtr.M_ID == characterId)
                {
                    characterData = character;
                    return true;
                }
            }
            return false;
        }

        static IEnumerable<GameSkillInfoDTO> GetGameSkills(GameSkillResource[] skills, PMonoArray<int> skillIds)
        {
            foreach (var skill in skills.Where(p => p.DisplayCategory == nameof(Skill)))
            {
                var skillPtr = new SkillData.Ptr_SkillData(skill.ObjectPointer);
                var id = skillPtr.M_ID;
                if (skillIds.AsReadOnlySpan().Contains(id))
                {
                    yield return new GameSkillInfoDTO
                    {
                        ObjectId = skill.ObjectId,
                        DisplayName = skill.DisplayName,
                        DisplayCategory = skill.DisplayCategory,
                        DisplayDesc = skill.DisplayDesc,
                        CanWrite = false,
                    };
                }
            }
        }
        public static IEnumerable<GameSkillInfoDTO> GetGamePassiveSkills(GameSkillResource[] skills, PMonoArray<int> skillIds)
        {
            foreach (var skill in skills.Where(p => p.DisplayCategory == nameof(Passive)))
            {
                var skillPtr = new PassiveData.Ptr_PassiveData(skill.ObjectPointer);
                var id = skillPtr.M_ID;
                if (skillIds.AsReadOnlySpan().Contains(id))
                {
                    yield return new GameSkillInfoDTO
                    {
                        ObjectId = skill.ObjectId,
                        DisplayName = skill.DisplayName,
                        DisplayCategory = skill.DisplayCategory,
                        DisplayDesc = skill.DisplayDesc,
                        CanWrite = false,
                    };
                }
            }
        }

        static IEnumerable<GameMonsterResourceEx> LoadCharacterResourcesEx(GameMetadataContext context, GameSkillResource[] skills)
        {
            GameObjectResource[] bookResources = [.. LoadBookResources(context)];
            GameMonsterResource[] characterRes = [.. LoadCharacterResources(context, skills, bookResources)];
            GameMonsterResource[] npcResources = [.. LoadNPCResources(context)];

            foreach (var npc in npcResources)
            {
                var npcPtr = new NpcData.Ptr_NpcData(npc.ObjectPointer);
                var character = characterRes.FirstOrDefault(c =>
                {
                    var characterPtr = new CharacterData.Ptr_CharacterData(c.ObjectPointer);
                    return characterPtr.M_ID == npcPtr.M_CHARACTER_ID;
                });
                yield return new GameMonsterResourceEx
                {
                    ObjectId = npc.ObjectId,
                    ObjectPointer = npc.ObjectPointer,
                    DisplayCategory = npc.DisplayCategory,

                    DisplayName = character?.DisplayName,
                    DisplayDesc = character?.DisplayDesc,
                    MonsterAttributes = character?.MonsterAttributes,
                    SkillInfos = character?.SkillInfos,
                    CharacterPointer = character?.ObjectPointer ?? default,
                };
            }



        }

    }


    public class GameObjectResource : GameObjectDisplayDTO
    {
        public nint ObjectPointer { get; set; }

        public int ID { get; set; }
    }

    public class GameMonsterResourceEx : GameMonsterResource
    {


        public nint CharacterPointer { get; set; }
    }

}
