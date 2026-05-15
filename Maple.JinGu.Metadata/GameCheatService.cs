using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataCollections;
using Maple.UnityAssistant.Resource;
using Microsoft.Extensions.Logging;

namespace Maple.JinGu.Metadata
{
    public readonly partial struct GameCheatService(GameResourceCache cache, SaveData.Ptr_SaveData saveData)
    {
        public SaveData.Ptr_SaveData PtrSaveData { get; } = saveData;
        public GameResourceCache Cache { get; } = cache;
        public GameMetadataContext Context => Cache.Context;
        private ILogger Logger => Context.Logger;


        public static GameCheatService CreateCheatService(GameResourceCache cache)
        {
            if (!cache.TryGetSaveData(out var ptr_SaveData))
            {
                return GameException.ThrowIfNotLoaded<GameCheatService>();
            }
            return new GameCheatService(cache, ptr_SaveData);
        }



        public GameCurrencyInfoDTO GetCurrencyInfoDTO(GameCurrencyObjectDTO currencyObjectDTO)
        {
            if (!this.Cache.TryGetCurrencyResource(currencyObjectDTO.CurrencyCategory, currencyObjectDTO.CurrencyObject, out var res))
            {
                return GameException.Throw<GameCurrencyInfoDTO>($"NOT FOUND {currencyObjectDTO.CurrencyCategory}:{currencyObjectDTO.CurrencyObject}");
            }

            ItemData.Ptr_ItemData itemDataPtr = new(res.ObjectPointer);
            var num = this.PtrSaveData.GET_ITEM_NUM(itemDataPtr.M_ID);
            return new GameCurrencyInfoDTO()
            {
                ObjectId = currencyObjectDTO.CurrencyObject,
                Currency = num
            };
        }
        public GameCurrencyInfoDTO UpdateCurrencyInfoDTO(GameCurrencyModifyDTO currencyModifyDTO)
        {
            if (!this.Cache.TryGetCurrencyResource(currencyModifyDTO.CurrencyCategory, currencyModifyDTO.CurrencyObject, out var res))
            {
                return GameException.Throw<GameCurrencyInfoDTO>($"NOT FOUND {currencyModifyDTO.CurrencyCategory}:{currencyModifyDTO.CurrencyObject}");
            }

            ItemData.Ptr_ItemData itemDataPtr = new(res.ObjectPointer);
            var num = this.PtrSaveData.GET_ITEM_NUM(itemDataPtr.M_ID);
            var changeNum = currencyModifyDTO.IntValue - num;
            this.PtrSaveData.CHANGE_ITEM(itemDataPtr.M_ID, changeNum);
            num = this.PtrSaveData.GET_ITEM_NUM(itemDataPtr.M_ID);
            return new GameCurrencyInfoDTO()
            {
                ObjectId = currencyModifyDTO.CurrencyObject,
                Currency = num
            };
        }

        public GameInventoryInfoDTO GetInventoryInfoDTO(GameInventoryObjectDTO inventoryObjectDTO)
        {
            if (!this.Cache.TryGetInventoryResource(inventoryObjectDTO.InventoryCategory, inventoryObjectDTO.InventoryObject, out var res))
            {
                return GameException.Throw<GameInventoryInfoDTO>($"NOT FOUND {inventoryObjectDTO.InventoryCategory}:{inventoryObjectDTO.InventoryObject}");
            }
            ItemData.Ptr_ItemData itemDataPtr = new(res.ObjectPointer);
            var num = this.PtrSaveData.GET_ITEM_NUM(itemDataPtr.M_ID);
            return new GameInventoryInfoDTO()
            {
                ObjectId = inventoryObjectDTO.InventoryObject,
                InventoryCount = num
            };
        }
        public GameInventoryInfoDTO UpdateInventoryInfoDTO(GameInventoryModifyDTO inventoryModifyDTO)
        {
            if (!this.Cache.TryGetInventoryResource(inventoryModifyDTO.InventoryCategory, inventoryModifyDTO.InventoryObject, out var res))
            {
                return GameException.Throw<GameInventoryInfoDTO>($"NOT FOUND {inventoryModifyDTO.InventoryCategory}:{inventoryModifyDTO.InventoryObject}");
            }

            ItemData.Ptr_ItemData itemDataPtr = new(res.ObjectPointer);
            var num = this.PtrSaveData.GET_ITEM_NUM(itemDataPtr.M_ID);
            var changeNum = inventoryModifyDTO.InventoryCount - num;
            this.PtrSaveData.CHANGE_ITEM(itemDataPtr.M_ID, changeNum);
            num = this.PtrSaveData.GET_ITEM_NUM(itemDataPtr.M_ID);
            return new GameInventoryInfoDTO()
            {
                ObjectId = inventoryModifyDTO.InventoryObject,
                InventoryCount = num
            };
        }

        public IEnumerable<GameCharacterResource> GetCharacterResources()
        {
            var characterName = this.PtrSaveData.GET_FULL_NAME();
            yield return new GameCharacterResource()
            {
                ObjectId = this.PtrSaveData.Ptr.ToString(),
                DisplayName = characterName.ToString(),
                DisplayCategory = nameof(LearderInfo),
                //  DisplayDesc = characterName.ToString(), 
            };


            var npcInfoDic = this.PtrSaveData.M_NPC_DIC;
            npcInfoDic.ON_BEFORE_SERIALIZE();
            var npcInfoList = npcInfoDic.M_VALUES.AsEnumerable().Select(p => p.M_ID).ToArray();

            foreach (var npc in this.Cache.NPCResources )
            {
                var npcData = new NpcData.Ptr_NpcData(npc.ObjectPointer);
                if (npcInfoList.Contains(npcData.M_ID))
                {
                    yield return new GameCharacterResource()
                    {
                        ObjectId = npc.ObjectId,
                        DisplayName = npc.DisplayName,
                        DisplayCategory = npc.DisplayCategory,
                        DisplayDesc = npc.DisplayDesc,
                    };
                }
            }


            npcInfoDic.ON_AFTER_DESERIALIZE();
        }
        public GameCharacterSkillDTO AddMonsterMember(GameMonsterObjectDTO monsterObjectDTO)
        {
            var monsterResource = this.Cache.NPCResources.Where(p => p.ObjectId == monsterObjectDTO.MonsterObject).FirstOrDefault();
            if (monsterResource is null)
            {
                return GameException.Throw<GameCharacterSkillDTO>($"NOT FOUND {monsterObjectDTO.MonsterObject}");
            }
            var npcData = new NpcData.Ptr_NpcData   (monsterResource.ObjectPointer);
            //var characterId = 0;
            //var npcId = 0;
            //if (monsterResource.DisplayCategory == nameof(Friend))
            //{
            //    var friendData = new FriendData.Ptr_FriendData(monsterResource.ObjectPointer);
            //    characterId = friendData.M_CHARACTER_ID;
            //    npcId = friendData.M_NPC_ID;
            //}
            //else if (monsterResource.DisplayCategory == nameof(Animal))
            //{
            //    var animalData = new AnimalData.Ptr_AnimalData(monsterResource.ObjectPointer);
            //    characterId = animalData.M_CHARACTER_ID;
            //    npcId = animalData.M_NPC_ID;
            //}
            if (npcData  )
            {
                var npcId = npcData.M_ID;
                //var characterInfo = this.PtrSaveData.GET_CHARACTER_INFO(characterId);
                this.PtrSaveData.TAKE(npcId);
                this.PtrSaveData.ADD_FAVO_BOOK(npcId);
                var npcInfo = this.PtrSaveData.GET_NPC_INFO(npcId);
                return new GameCharacterSkillDTO()
                {
                    ObjectId = npcInfo.Ptr.ToString(),
                    SkillInfos = monsterResource.SkillInfos,
                };
            }

            return GameException.Throw<GameCharacterSkillDTO>($"ERROR {monsterResource.DisplayCategory}:{monsterResource.ObjectId}");

        }


        private IEnumerable<GameSwitchDisplayDTO> EnumCharacterStatus()
        {
            foreach (var attr in this.Cache.SkillResources.Where(p => p.DisplayCategory == nameof(Effect)))
            {
                var effectData = new EffectData.Ptr_EffectData(attr.ObjectPointer);
                //if (effectData.M_INIT_VALUE == 0)
                //{
                //    continue;
                //}
                var id = effectData.M_ID;
                var value = this.PtrSaveData.GET_EFFECT_VALUE(id);
                yield return new GameSwitchDisplayDTO() { ObjectId = attr.ObjectId, DisplayName = attr.DisplayName, DisplayDesc = attr.DisplayDesc, ContentValue = value.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            }
            //foreach (var attr in this.PtrSaveData.EnumSaveDataReader())
            //{
            //    yield return new GameSwitchDisplayDTO() { ObjectId = attr.Key, DisplayName = attr.Name, ContentValue = attr.Value, UIType = (int)EnumGameSwitchUIType.TextEditor };
            //}
            //yield return new GameSwitchDisplayDTO() { ObjectId = nameof(PtrSaveData.M_YANG_CHENG), DisplayName = "养成", ContentValue = PtrSaveData.M_YANG_CHENG.ToString(), UIType = (int)EnumGameSwitchUIType.Switches };

        }
        private IEnumerable<GameSwitchDisplayDTO> EnumNPCStatus(GameMonsterResource npcRes)
        {
            var npcData = new NpcData.Ptr_NpcData(npcRes.ObjectPointer);
            var npcInfo = this.PtrSaveData.GET_NPC_INFO(npcData.M_ID);
            if (npcInfo)
            {
                yield return new GameSwitchDisplayDTO() { ObjectId = nameof(NpcInfo.Ptr_NpcInfo.M_DEADED), DisplayName = nameof(NpcInfo.Ptr_NpcInfo.M_DEADED), SwitchValue = npcInfo.M_DEADED, UIType = (int)EnumGameSwitchUIType.Switches };
                yield return new GameSwitchDisplayDTO() { ObjectId = nameof(NpcInfo.Ptr_NpcInfo.M_FAVO), DisplayName = nameof(NpcInfo.Ptr_NpcInfo.M_FAVO), ContentValue = npcInfo.M_FAVO.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            }
        }
        public GameCharacterStatusDTO GetCharacterStatus(GameCharacterObjectDTO characterObjectDTO)
        {
            if (characterObjectDTO.CharacterCategory == nameof(LearderInfo))
            {
                return new GameCharacterStatusDTO()
                {
                    ObjectId = characterObjectDTO.CharacterId,
                    CharacterAttributes = [.. EnumCharacterStatus()]
                };
            }
            if (this.Cache.TryGetNPCResource(characterObjectDTO.CharacterCategory, characterObjectDTO.CharacterId,
                out var npcRes))
            {
                return new GameCharacterStatusDTO()
                {
                    ObjectId = characterObjectDTO.CharacterId,
                    CharacterAttributes = [.. EnumNPCStatus(npcRes)]
                };
            }

            return GameException.Throw<GameCharacterStatusDTO>($"NOT FOUND {characterObjectDTO.CharacterCategory}:{characterObjectDTO.CharacterId}");
        }

        void SetCharacterStatus(GameCharacterModifyDTO characterModifyDTO)
        {
            var attr = this.Cache.SkillResources.Where(p => p.DisplayCategory == nameof(Effect) && p.ObjectId == characterModifyDTO.ModifyObject).FirstOrDefault();
            if (attr is null)
            {
                GameException.Throw($"NOT FOUND {characterModifyDTO.ModifyCategory}:{characterModifyDTO.ModifyObject}");
            }
            var effectData = new EffectData.Ptr_EffectData(attr.ObjectPointer);
            //if (effectData.M_INIT_VALUE == 0)
            //{
            //    continue;
            //}
            var id = effectData.M_ID;
            var value = this.PtrSaveData.GET_EFFECT_VALUE(id);
            this.PtrSaveData.ADD_EFFECT_VALUE(id, -value, false);
            this.PtrSaveData.ADD_EFFECT_VALUE(id, characterModifyDTO.FloatValue, false);


        }
        void SetNPCStatus(GameMonsterResource npcRes, GameCharacterModifyDTO characterModifyDTO)
        {
            var npcData = new NpcData.Ptr_NpcData(npcRes.ObjectPointer);
            var npcInfo = this.PtrSaveData.GET_NPC_INFO(npcData.M_ID);
            if (characterModifyDTO.ModifyObject == nameof(NpcInfo.Ptr_NpcInfo.M_DEADED))
            {
                npcInfo.M_DEADED = characterModifyDTO.BoolValue ?? false;
            }
            else if (characterModifyDTO.ModifyObject == nameof(NpcInfo.Ptr_NpcInfo.M_FAVO))
            {
                npcInfo.M_FAVO = characterModifyDTO.IntValue;
            }
        }

        public GameCharacterStatusDTO UpdateCharacterStatus(GameCharacterModifyDTO characterModifyDTO)
        {
            if (characterModifyDTO.CharacterCategory == nameof(LearderInfo))
            {
                this.SetCharacterStatus(characterModifyDTO);
                return new GameCharacterStatusDTO()
                {
                    ObjectId = characterModifyDTO.CharacterId,
                    CharacterAttributes = [.. EnumCharacterStatus()]
                };
            }
            if (this.Cache.TryGetNPCResource(characterModifyDTO.CharacterCategory, characterModifyDTO.CharacterId,
                out var npcRes))
            {
                this.SetNPCStatus(npcRes, characterModifyDTO);
                return new GameCharacterStatusDTO()
                {
                    ObjectId = characterModifyDTO.CharacterId,
                    CharacterAttributes = [.. EnumNPCStatus(npcRes)]
                };
            }
            return GameException.Throw<GameCharacterStatusDTO>($"NOT FOUND {characterModifyDTO.CharacterCategory}:{characterModifyDTO.CharacterId}");

        }

        IEnumerable<GameSkillInfoDTO> EnumCharacterSkill()
        {
            yield return new GameSkillInfoDTO()
            {
                ObjectId = string.Empty,
                DisplayCategory = nameof(GlobalBuff),
                CanWrite = true,
                //  DisplayDesc = skill.DisplayDesc,
                //  DisplayName = skill.DisplayName,
            };
            var globalBuffSkill = this.Cache.SkillResources.Where(p => p.DisplayCategory == nameof(GlobalBuff)).ToArray();
            this.PtrSaveData.M_GLOBAL_BUFF_HASH.ON_BEFORE_SERIALIZE();
            var hashKey = this.PtrSaveData.M_GLOBAL_BUFF_HASH.M_KEYS;
            foreach (var id in hashKey.AsEnumerable())
            {
                var skill = globalBuffSkill.Where(p => (new GlobalBuffData.Ptr_GlobalBuffData(p.ObjectPointer)).M_ID == id).FirstOrDefault();
                if (skill is not null)
                {
                    yield return new GameSkillInfoDTO()
                    {
                        ObjectId = skill.ObjectId,
                        DisplayCategory = skill.DisplayCategory,
                        DisplayDesc = skill.DisplayDesc,
                        DisplayName = skill.DisplayName,
                        CanWrite = false,
                    };
                }

            }

            this.PtrSaveData.M_GLOBAL_BUFF_HASH.ON_AFTER_DESERIALIZE();
        }
        public GameCharacterSkillDTO GetCharacterSkill(GameCharacterObjectDTO characterObjectDTO)
        {
            if (characterObjectDTO.CharacterCategory != nameof(LearderInfo))
            {
                return GameException.Throw<GameCharacterSkillDTO>($"NOT FOUND {characterObjectDTO.CharacterCategory}");
            }
            return new GameCharacterSkillDTO()
            {
                ObjectId = characterObjectDTO.CharacterId,
                SkillInfos = [.. EnumCharacterSkill()]
            };
        }
        public GameCharacterSkillDTO UpdateCharacterSkill(GameCharacterModifyDTO characterModifyDTO)
        {
            if (characterModifyDTO.CharacterCategory != nameof(LearderInfo))
            {
                return GameException.Throw<GameCharacterSkillDTO>($"NOT FOUND {characterModifyDTO.CharacterCategory}");
            }
            var skill = this.Cache.SkillResources.Where(p => p.DisplayCategory == characterModifyDTO.ModifyCategory && p.ObjectId == characterModifyDTO.NewValue).FirstOrDefault();
            if (skill is null)
            {
                return GameException.Throw<GameCharacterSkillDTO>($"NOT FOUND {characterModifyDTO.ModifyCategory}:{characterModifyDTO.NewValue}");
            }
            var globalBuffData = new GlobalBuffData.Ptr_GlobalBuffData(skill.ObjectPointer);
            var id = globalBuffData.M_ID;
            this.PtrSaveData.ADD_GLOBAL_BUFF(id);
            return new GameCharacterSkillDTO()
            {
                ObjectId = characterModifyDTO.CharacterId,
                SkillInfos = [.. EnumCharacterSkill()]
            };

            //var passiveIdList = GameResourceCache.GetGamePassiveSkills(this.Cache.SkillResources, this.PtrSaveData.M_PASSIVES).Select(p => p.ObjectId).ToList();
            //if (!passiveIdList.Contains(characterModifyDTO.ModifyObject))
            //{
            //    GameException.Throw($"NOT FOUND {characterModifyDTO.ModifyObject}");
            //}
            //var passiveResource = this.Cache.SkillResources.Where(p => p.DisplayCategory == nameof(Passive) && p.ObjectId == characterModifyDTO.ModifyObject).FirstOrDefault();
            //if (passiveResource is null)
            //{
            //    GameException.Throw($"NOT FOUND {characterModifyDTO.ModifyObject}");
            //}
            //var passiveData = new PassiveData.Ptr_PassiveData(passiveResource.ObjectPointer);
            //var id = passiveData.M_ID;
            //this.PtrSaveData.ADD_PASSIVE(id);
            //return new GameCharacterSkillDTO()
            //{
            //    ObjectId = characterModifyDTO.CharacterId,
            //    SkillInfos = [.. GameResourceCache.GetGamePassiveSkills(this.Cache.SkillResources, this.PtrSaveData.M_PASSIVES)]
            //};

        }
    }
}
