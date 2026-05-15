using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;

namespace Maple.JinGu.Metadata
{
    [ContextParentMetadata<ContextMetadataCollector>(true)]

    [ContextMemberMetadata<SaveManager>]
    [ContextMemberMetadata<SaveData>]
    [ContextMemberMetadata<GlobalData>]


    [ContextMemberMetadata<UIUtlils>]
    [ContextMemberMetadata<LanguageUtils>]

    [ContextMemberMetadata<Book>]
    [ContextMemberMetadata<BookData>]



    [ContextMemberMetadata<Item>]
    [ContextMemberMetadata<ItemData>]
    [ContextMemberMetadata<ItemInfo>]

    [ContextMemberMetadata<Npc>]
    [ContextMemberMetadata<NpcData>]
    [ContextMemberMetadata<NpcInfo>]
    //[ContextMemberMetadata<AnimalData>]
    //[ContextMemberMetadata<Animal>]
    //[ContextMemberMetadata<Friend>]
    //[ContextMemberMetadata<FriendData>]
    [ContextMemberMetadata<Character>]
    [ContextMemberMetadata<CharacterData>]


    [ContextMemberMetadata<Achieve>]
    [ContextMemberMetadata<AchieveData>]
    [ContextMemberMetadata<Skill>]
    [ContextMemberMetadata<SkillData>]
    [ContextMemberMetadata<WuXue>]
    [ContextMemberMetadata<WuXueData>]
    [ContextMemberMetadata<Passive>]
    [ContextMemberMetadata<PassiveData>]
    [ContextMemberMetadata<Effect>]
    [ContextMemberMetadata<EffectData>]
    [ContextMemberMetadata<GlobalBuff>]
    [ContextMemberMetadata<GlobalBuffData>]



    public partial class GameMetadataContext
    {

    }
}
