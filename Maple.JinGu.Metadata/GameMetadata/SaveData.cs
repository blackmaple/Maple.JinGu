namespace Maple.JinGu.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."SaveData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_SaveData>, Ptr_SaveData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "SaveData", "SaveData")]
    public partial class SaveData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_SaveData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_SaveData(System.IntPtr ptr) => new Ptr_SaveData(ptr);
            public static implicit operator System.IntPtr(Ptr_SaveData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_SaveData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."SaveData"]
        /// </summary>
        partial struct Ptr_SaveData
        {
            /// <summary>
            /// 0x10 SerializedDictionary<DBLoad.EffectId , System.Single> m_effectDic
            /// class ["Assembly-CSharp".""."SerializedDictionary`2"]
            /// </summary>
            /// <returns>class SerializedDictionary<DBLoad.EffectId , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_effectDic", "SerializedDictionary<DBLoad.EffectId,System.Single>")]
            public partial nint M_EFFECT_DIC { get; set; } 
*/

            /// <summary>
            /// 0x18 System.String m_name
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_name", "System.String")]
            public partial nint M_NAME { get; set; } 
*/

            /// <summary>
            /// 0x20 System.String m_skin
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_skin", "System.String")]
            public partial nint M_SKIN { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Int32[] m_equips
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_equips", "System.Int32[]")]
            public partial nint M_EQUIPS { get; set; } 
*/

            /// <summary>
            /// 0x30 SerializedHashSet<System.Int32> m_globalBuffHash
            /// class ["Assembly-CSharp".""."SerializedHashSet`1"]
            /// </summary>
            /// <returns>class SerializedHashSet<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_globalBuffHash", "SerializedHashSet<System.Int32>")]
            public partial nint M_GLOBAL_BUFF_HASH { get; set; } 
*/

            /// <summary>
            /// 0x38 SerializedDictionary<System.Int32 , NpcInfo> m_npcDic
            /// class ["Assembly-CSharp".""."SerializedDictionary`2"]
            /// </summary>
            /// <returns>class SerializedDictionary<System.Int32 , NpcInfo></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_npcDic", "SerializedDictionary<System.Int32,NpcInfo>")]
            public partial nint M_NPC_DIC { get; set; } 
*/

            /// <summary>
            /// 0x40 SerializedDictionary<SceneEnum , UnityEngine.Vector2> m_posDic
            /// class ["Assembly-CSharp".""."SerializedDictionary`2"]
            /// </summary>
            /// <returns>class SerializedDictionary<SceneEnum , UnityEngine.Vector2></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_posDic", "SerializedDictionary<SceneEnum,UnityEngine.Vector2>")]
            public partial nint M_POS_DIC { get; set; } 
*/

            /// <summary>
            /// 0x48 SerializedDictionary<System.Int32 , System.Int32> m_itemDic
            /// class ["Assembly-CSharp".""."SerializedDictionary`2"]
            /// </summary>
            /// <returns>class SerializedDictionary<System.Int32 , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_itemDic", "SerializedDictionary<System.Int32,System.Int32>")]
            public partial nint M_ITEM_DIC { get; set; } 
*/

            /// <summary>
            /// 0x50 SerializedHashSet<System.Int32> m_receiveHash
            /// class ["Assembly-CSharp".""."SerializedHashSet`1"]
            /// </summary>
            /// <returns>class SerializedHashSet<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_receiveHash", "SerializedHashSet<System.Int32>")]
            public partial nint M_RECEIVE_HASH { get; set; } 
*/

            /// <summary>
            /// 0x58 SerializedHashSet<System.Int32> m_completeHash
            /// class ["Assembly-CSharp".""."SerializedHashSet`1"]
            /// </summary>
            /// <returns>class SerializedHashSet<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_completeHash", "SerializedHashSet<System.Int32>")]
            public partial nint M_COMPLETE_HASH { get; set; } 
*/

            /// <summary>
            /// 0x60 SerializedHashSet<System.Int32> m_failHash
            /// class ["Assembly-CSharp".""."SerializedHashSet`1"]
            /// </summary>
            /// <returns>class SerializedHashSet<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_failHash", "SerializedHashSet<System.Int32>")]
            public partial nint M_FAIL_HASH { get; set; } 
*/

            /// <summary>
            /// 0x68 SerializedHashSet<System.Int32> m_dialogHash
            /// class ["Assembly-CSharp".""."SerializedHashSet`1"]
            /// </summary>
            /// <returns>class SerializedHashSet<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_dialogHash", "SerializedHashSet<System.Int32>")]
            public partial nint M_DIALOG_HASH { get; set; } 
*/

            /// <summary>
            /// 0x70 SerializedHashSet<System.Int32> m_wanderHash
            /// class ["Assembly-CSharp".""."SerializedHashSet`1"]
            /// </summary>
            /// <returns>class SerializedHashSet<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_wanderHash", "SerializedHashSet<System.Int32>")]
            public partial nint M_WANDER_HASH { get; set; } 
*/

            /// <summary>
            /// 0x78 SerializedHashSet<System.Int32> m_weiTuoHash
            /// class ["Assembly-CSharp".""."SerializedHashSet`1"]
            /// </summary>
            /// <returns>class SerializedHashSet<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_weiTuoHash", "SerializedHashSet<System.Int32>")]
            public partial nint M_WEI_TUO_HASH { get; set; } 
*/

            /// <summary>
            /// 0x80 SerializedDictionary<System.Int32 , System.Int32> m_dialogCDDic
            /// class ["Assembly-CSharp".""."SerializedDictionary`2"]
            /// </summary>
            /// <returns>class SerializedDictionary<System.Int32 , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_dialogCDDic", "SerializedDictionary<System.Int32,System.Int32>")]
            public partial nint M_DIALOG_CD_DIC { get; set; } 
*/

            /// <summary>
            /// 0x88 SerializedHashSet<System.Int32> m_levelHash
            /// class ["Assembly-CSharp".""."SerializedHashSet`1"]
            /// </summary>
            /// <returns>class SerializedHashSet<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_levelHash", "SerializedHashSet<System.Int32>")]
            public partial nint M_LEVEL_HASH { get; set; } 
*/

            /// <summary>
            /// 0x90 SerializedHashSet<System.Int32> m_unlockHash
            /// class ["Assembly-CSharp".""."SerializedHashSet`1"]
            /// </summary>
            /// <returns>class SerializedHashSet<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_unlockHash", "SerializedHashSet<System.Int32>")]
            public partial nint M_UNLOCK_HASH { get; set; } 
*/

            /// <summary>
            /// 0x98 SerializedHashSet<System.Int32> m_dotHash
            /// class ["Assembly-CSharp".""."SerializedHashSet`1"]
            /// </summary>
            /// <returns>class SerializedHashSet<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_dotHash", "SerializedHashSet<System.Int32>")]
            public partial nint M_DOT_HASH { get; set; } 
*/

            /// <summary>
            /// 0xA0 SerializedHashSet<System.Int32> m_takeHash
            /// class ["Assembly-CSharp".""."SerializedHashSet`1"]
            /// </summary>
            /// <returns>class SerializedHashSet<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_takeHash", "SerializedHashSet<System.Int32>")]
            public partial nint M_TAKE_HASH { get; set; } 
*/

            /// <summary>
            /// 0xA8 System.Int32[] m_fights
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_fights", "System.Int32[]")]
            public partial nint M_FIGHTS { get; set; } 
*/

            /// <summary>
            /// 0xB0 System.String m_leaderFamily
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_leaderFamily", "System.String")]
            public partial nint M_LEADER_FAMILY { get; set; } 
*/

            /// <summary>
            /// 0xB8 System.String m_leaderName
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_leaderName", "System.String")]
            public partial nint M_LEADER_NAME { get; set; } 
*/

            /// <summary>
            /// 0xC0 SerializedDictionary<System.Int32 , System.Int32> m_wuXueExpDic
            /// class ["Assembly-CSharp".""."SerializedDictionary`2"]
            /// </summary>
            /// <returns>class SerializedDictionary<System.Int32 , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_wuXueExpDic", "SerializedDictionary<System.Int32,System.Int32>")]
            public partial nint M_WU_XUE_EXP_DIC { get; set; } 
*/

            /// <summary>
            /// 0xC8 SerializedHashSet<System.Int32> m_danFangHash
            /// class ["Assembly-CSharp".""."SerializedHashSet`1"]
            /// </summary>
            /// <returns>class SerializedHashSet<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_danFangHash", "SerializedHashSet<System.Int32>")]
            public partial nint M_DAN_FANG_HASH { get; set; } 
*/

            /// <summary>
            /// 0xD0 SerializedHashSet<System.Int32> m_daZaoHash
            /// class ["Assembly-CSharp".""."SerializedHashSet`1"]
            /// </summary>
            /// <returns>class SerializedHashSet<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_daZaoHash", "SerializedHashSet<System.Int32>")]
            public partial nint M_DA_ZAO_HASH { get; set; } 
*/

            /// <summary>
            /// 0xD8 SerializedDictionary<System.Int32 , CharacterInfo> m_characterDic
            /// class ["Assembly-CSharp".""."SerializedDictionary`2"]
            /// </summary>
            /// <returns>class SerializedDictionary<System.Int32 , CharacterInfo></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_characterDic", "SerializedDictionary<System.Int32,CharacterInfo>")]
            public partial nint M_CHARACTER_DIC { get; set; } 
*/

            /// <summary>
            /// 0xE0 SerializedHashSet<System.Int32> m_ganWuHash
            /// class ["Assembly-CSharp".""."SerializedHashSet`1"]
            /// </summary>
            /// <returns>class SerializedHashSet<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_ganWuHash", "SerializedHashSet<System.Int32>")]
            public partial nint M_GAN_WU_HASH { get; set; } 
*/

            /// <summary>
            /// 0xE8 System.Int32[] m_quanActives
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_quanActives", "System.Int32[]")]
            public partial nint M_QUAN_ACTIVES { get; set; } 
*/

            /// <summary>
            /// 0xF0 System.Int32[] m_daoActives
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_daoActives", "System.Int32[]")]
            public partial nint M_DAO_ACTIVES { get; set; } 
*/

            /// <summary>
            /// 0xF8 System.Int32[] m_jianActives
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_jianActives", "System.Int32[]")]
            public partial nint M_JIAN_ACTIVES { get; set; } 
*/

            /// <summary>
            /// 0x100 System.Int32[] m_qiangActives
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_qiangActives", "System.Int32[]")]
            public partial nint M_QIANG_ACTIVES { get; set; } 
*/

            /// <summary>
            /// 0x108 System.Int32[] m_anqiActives
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_anqiActives", "System.Int32[]")]
            public partial nint M_ANQI_ACTIVES { get; set; } 
*/

            /// <summary>
            /// 0x110 System.Int32[] m_qinActives
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_qinActives", "System.Int32[]")]
            public partial nint M_QIN_ACTIVES { get; set; } 
*/

            /// <summary>
            /// 0x118 System.Int32[] m_passives
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_passives", "System.Int32[]")]
            public partial nint M_PASSIVES { get; set; } 
*/

            /// <summary>
            /// 0x120 SerializedHashSet<System.Int32> m_favoBookHash
            /// class ["Assembly-CSharp".""."SerializedHashSet`1"]
            /// </summary>
            /// <returns>class SerializedHashSet<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_favoBookHash", "SerializedHashSet<System.Int32>")]
            public partial nint M_FAVO_BOOK_HASH { get; set; } 
*/

            /// <summary>
            /// 0x128 SerializedDictionary<System.Int32 , System.Int32> m_delayShowDic
            /// class ["Assembly-CSharp".""."SerializedDictionary`2"]
            /// </summary>
            /// <returns>class SerializedDictionary<System.Int32 , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_delayShowDic", "SerializedDictionary<System.Int32,System.Int32>")]
            public partial nint M_DELAY_SHOW_DIC { get; set; } 
*/

            /// <summary>
            /// 0x130 SerializedDictionary<System.Int32 , System.Int32> m_delayHideDic
            /// class ["Assembly-CSharp".""."SerializedDictionary`2"]
            /// </summary>
            /// <returns>class SerializedDictionary<System.Int32 , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_delayHideDic", "SerializedDictionary<System.Int32,System.Int32>")]
            public partial nint M_DELAY_HIDE_DIC { get; set; } 
*/

            /// <summary>
            /// 0x138 SerializedDictionary<System.Int32 , System.Int32> m_delayDotDic
            /// class ["Assembly-CSharp".""."SerializedDictionary`2"]
            /// </summary>
            /// <returns>class SerializedDictionary<System.Int32 , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_delayDotDic", "SerializedDictionary<System.Int32,System.Int32>")]
            public partial nint M_DELAY_DOT_DIC { get; set; } 
*/

            /// <summary>
            /// 0x140 SerializedDictionary<System.Int32 , System.Int32> m_delayCancelDotDic
            /// class ["Assembly-CSharp".""."SerializedDictionary`2"]
            /// </summary>
            /// <returns>class SerializedDictionary<System.Int32 , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_delayCancelDotDic", "SerializedDictionary<System.Int32,System.Int32>")]
            public partial nint M_DELAY_CANCEL_DOT_DIC { get; set; } 
*/

            /// <summary>
            /// 0x148 SerializedDictionary<System.Int32 , System.Int32> m_animalExpDic
            /// class ["Assembly-CSharp".""."SerializedDictionary`2"]
            /// </summary>
            /// <returns>class SerializedDictionary<System.Int32 , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_animalExpDic", "SerializedDictionary<System.Int32,System.Int32>")]
            public partial nint M_ANIMAL_EXP_DIC { get; set; } 
*/

            /// <summary>
            /// 0x150 SerializedDictionary<System.Int32 , System.Int32> m_friendLvDic
            /// class ["Assembly-CSharp".""."SerializedDictionary`2"]
            /// </summary>
            /// <returns>class SerializedDictionary<System.Int32 , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_friendLvDic", "SerializedDictionary<System.Int32,System.Int32>")]
            public partial nint M_FRIEND_LV_DIC { get; set; } 
*/

            /// <summary>
            /// 0x158 SerializedDictionary<System.Int32 , System.Int32> m_storeDic
            /// class ["Assembly-CSharp".""."SerializedDictionary`2"]
            /// </summary>
            /// <returns>class SerializedDictionary<System.Int32 , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_storeDic", "SerializedDictionary<System.Int32,System.Int32>")]
            public partial nint M_STORE_DIC { get; set; } 
*/

            /// <summary>
            /// 0x160 SerializedDictionary<System.Int32 , System.Int32> m_postDic
            /// class ["Assembly-CSharp".""."SerializedDictionary`2"]
            /// </summary>
            /// <returns>class SerializedDictionary<System.Int32 , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_postDic", "SerializedDictionary<System.Int32,System.Int32>")]
            public partial nint M_POST_DIC { get; set; } 
*/

            /// <summary>
            /// 0x168 DiffucultEnum m_diffucultEnum
            /// enum ["Assembly-CSharp".""."DiffucultEnum"]
            /// </summary>
            /// <returns>enum DiffucultEnum</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_diffucultEnum", "DiffucultEnum")]
            public partial DiffucultEnum M_DIFFUCULT_ENUM { get; set; } 
*/

            /// <summary>
            /// 0x16C System.Int32 m_chapterEnum
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_chapterEnum", "System.Int32")]
            public partial System.Int32 M_CHAPTER_ENUM { get; set; } 
*/

            /// <summary>
            /// 0x170 SceneEnum m_scene
            /// enum ["Assembly-CSharp".""."SceneEnum"]
            /// </summary>
            /// <returns>enum SceneEnum</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_scene", "SceneEnum")]
            public partial SceneEnum M_SCENE { get; set; } 
*/

            /// <summary>
            /// 0x174 System.Int32 m_gameTime
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_gameTime", "System.Int32")]
            public partial System.Int32 M_GAME_TIME { get; set; } 
*/

            /// <summary>
            /// 0x178 System.Int32 m_realTime
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_realTime", "System.Int32")]
            public partial System.Int32 M_REAL_TIME { get; set; } 
*/

            /// <summary>
            /// 0x180 System.Int64 m_saveTime
            /// struct ["mscorlib"."System"."Int64"]
            /// </summary>
            /// <returns>struct System.Int64</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_saveTime", "System.Int64")]
            public partial System.Int64 M_SAVE_TIME { get; set; } 
*/

            /// <summary>
            /// 0x188 System.Boolean m_fightWin
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_fightWin", "System.Boolean")]
            public partial System.Boolean M_FIGHT_WIN { get; set; } 
*/

            /// <summary>
            /// 0x189 System.Boolean m_yangCheng
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_yangCheng", "System.Boolean")]
            public partial System.Boolean M_YANG_CHENG { get; set; } 
*/

            /// <summary>
            /// 0x18C System.Int32 m_showMainId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_showMainId", "System.Int32")]
            public partial System.Int32 M_SHOW_MAIN_ID { get; set; } 
*/

            /// <summary>
            /// 0x190 System.Int32 m_showBranchId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_showBranchId", "System.Int32")]
            public partial System.Int32 M_SHOW_BRANCH_ID { get; set; } 
*/

            /// <summary>
            /// 0x194 System.Int32 m_fishRob
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_fishRob", "System.Int32")]
            public partial System.Int32 M_FISH_ROB { get; set; } 
*/

            /// <summary>
            /// 0x198 System.Int32 m_huntBow
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_huntBow", "System.Int32")]
            public partial System.Int32 M_HUNT_BOW { get; set; } 
*/

            /// <summary>
            /// 0x19C System.Int32 m_tiLi
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_tiLi", "System.Int32")]
            public partial System.Int32 M_TI_LI { get; set; } 
*/

            /// <summary>
            /// 0x1A0 System.Int32 m_turn
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_turn", "System.Int32")]
            public partial System.Int32 M_TURN { get; set; } 
*/

            /// <summary>
            /// 0x1A4 Direction m_leaderDirection
            /// enum ["Assembly-CSharp".""."Direction"]
            /// </summary>
            /// <returns>enum Direction</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_leaderDirection", "Direction")]
            public partial Direction M_LEADER_DIRECTION { get; set; } 
*/

            /// <summary>
            /// 0x1A8 System.Single m_hp
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_hp", "System.Single")]
            public partial System.Single M_HP { get; set; } 
*/

            /// <summary>
            /// 0x1AC System.Single m_mp
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_mp", "System.Single")]
            public partial System.Single M_MP { get; set; } 
*/

            /// <summary>
            /// 0x1B0 System.Single m_jingLi
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_jingLi", "System.Single")]
            public partial System.Single M_JING_LI { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."SaveData"]
        /// </summary>
        partial struct Ptr_SaveData
        {
            /// <summary>
            ///   System.Void .ctor(DiffucultEnum diffucultEnum, System.String leaderFamily, System.String leaderName, System.Collections.Generic.Dictionary<DBLoad.EffectId , System.Int32> effects, System.Int32 num, System.Collections.Generic.HashSet<System.Int32> hash)
            /// </summary>
            /// <param name = "diffucultEnum">enum DiffucultEnum</param>
            /// <param name = "leaderFamily">class System.String</param>
            /// <param name = "leaderName">class System.String</param>
            /// <param name = "effects">class System.Collections.Generic.Dictionary<DBLoad.EffectId , System.Int32></param>
            /// <param name = "num">struct System.Int32</param>
            /// <param name = "hash">class System.Collections.Generic.HashSet<System.Int32></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DiffucultEnum", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<DBLoad.EffectId,System.Int32>", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.HashSet<System.Int32>", 5)]
            public partial void CTOR(DiffucultEnum diffucultEnum, nint leaderFamily, nint leaderName, nint effects, System.Int32 num, nint hash); 
*/
            /// <summary>
            ///   System.Void <TriggerWander>g__Trigger|114_0(DBLoad.WanderDialogData res, SaveData.<>c__DisplayClass114_0& )
            /// </summary>
            /// <param name = "res">class DBLoad.WanderDialogData</param>
            /// <param name = "">struct SaveData.<>c__DisplayClass114_0&</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<TriggerWander>g__Trigger|114_0", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DBLoad.WanderDialogData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("SaveData.<>c__DisplayClass114_0&", 1)]
            public partial void TRIGGER_WANDERG__TRIGGER|114_0(nint res, SaveData. < > c__DisplayClass114_0 &); 
*/
            /// <summary>
            ///   System.Boolean ActiveGanWu(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ActiveGanWu", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean ACTIVE_GAN_WU(System.Int32 id); 
*/
            /// <summary>
            ///   System.Void AddDelayHide(System.Int32 npcId, System.Int32 time)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <param name = "time">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddDelayHide", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void ADD_DELAY_HIDE(System.Int32 npcId, System.Int32 time); 
*/
            /// <summary>
            ///   System.Void AddDelayShow(System.Int32 npcId, System.Int32 time)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <param name = "time">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddDelayShow", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void ADD_DELAY_SHOW(System.Int32 npcId, System.Int32 time); 
*/
            /// <summary>
            ///   System.Void AddEffectValue(DBLoad.EffectId id, System.Single add, System.Boolean needTips)
            /// </summary>
            /// <param name = "id">enum DBLoad.EffectId</param>
            /// <param name = "add">struct System.Single</param>
            /// <param name = "needTips">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddEffectValue", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DBLoad.EffectId", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void ADD_EFFECT_VALUE(DBLoad.EffectId id, System.Single add, System.Boolean needTips); 
*/
            /// <summary>
            ///   System.Void AddFavoBook(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddFavoBook", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void ADD_FAVO_BOOK(System.Int32 id); 
*/
            /// <summary>
            ///   System.Void AddGlobalBuff(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddGlobalBuff", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void ADD_GLOBAL_BUFF(System.Int32 id); 
*/
            /// <summary>
            ///   System.Void AddHour(System.Int32 hour)
            /// </summary>
            /// <param name = "hour">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddHour", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void ADD_HOUR(System.Int32 hour); 
*/
            /// <summary>
            ///   System.Void AddItems(System.Collections.Generic.List<ItemInfo> itemList, System.Boolean show)
            /// </summary>
            /// <param name = "itemList">class System.Collections.Generic.List<ItemInfo></param>
            /// <param name = "show">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddItems", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<ItemInfo>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void ADD_ITEMS(nint itemList, System.Boolean show); 
*/
            /// <summary>
            ///   System.Void AddItems(System.Collections.Generic.Dictionary<System.Int32 , System.Int32> itemDic, System.Boolean show)
            /// </summary>
            /// <param name = "itemDic">class System.Collections.Generic.Dictionary<System.Int32 , System.Int32></param>
            /// <param name = "show">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddItems", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.Int32,System.Int32>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void ADD_ITEMS(nint itemDic, System.Boolean show); 
*/
            /// <summary>
            ///   System.Void AddStoreRefresh(System.Int32 npcId)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddStoreRefresh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void ADD_STORE_REFRESH(System.Int32 npcId); 
*/
            /// <summary>
            ///   System.Void AddWuXueExp(System.Int32 id, System.Int32 exp, System.Boolean needTips)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "exp">struct System.Int32</param>
            /// <param name = "needTips">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddWuXueExp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void ADD_WU_XUE_EXP(System.Int32 id, System.Int32 exp, System.Boolean needTips); 
*/
            /// <summary>
            ///   System.Void AnimalEat(System.Int32 npcId, System.Int32 itemId, System.Int32 itemNum)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <param name = "itemId">struct System.Int32</param>
            /// <param name = "itemNum">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AnimalEat", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial void ANIMAL_EAT(System.Int32 npcId, System.Int32 itemId, System.Int32 itemNum); 
*/
            /// <summary>
            ///   System.Void CancelDot(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CancelDot", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void CANCEL_DOT(System.Int32 id); 
*/
            /// <summary>
            ///   System.Void CancleFightById(System.Int32 npcId)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CancleFightById", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void CANCLE_FIGHT_BY_ID(System.Int32 npcId); 
*/
            /// <summary>
            ///   System.Void CancleFightByIndex(System.Int32 index)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CancleFightByIndex", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void CANCLE_FIGHT_BY_INDEX(System.Int32 index); 
*/
            /// <summary>
            ///   System.Void ChangeGroupFavo(System.Int32 group, System.Int32 value)
            /// </summary>
            /// <param name = "group">struct System.Int32</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeGroupFavo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void CHANGE_GROUP_FAVO(System.Int32 group, System.Int32 value); 
*/
            /// <summary>
            ///   System.Void ChangeItem(System.Int32 itemId, System.Int32 changeNum)
            /// </summary>
            /// <param name = "itemId">struct System.Int32</param>
            /// <param name = "changeNum">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void CHANGE_ITEM(System.Int32 itemId, System.Int32 changeNum); 
*/
            /// <summary>
            ///   System.Void ChangeNpc(System.Int32 npcId, System.Int32 newId)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <param name = "newId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeNpc", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void CHANGE_NPC(System.Int32 npcId, System.Int32 newId); 
*/
            /// <summary>
            ///   System.Boolean CheckAction(Dialog.ActionType type)
            /// </summary>
            /// <param name = "type">enum Dialog.ActionType</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckAction", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Dialog.ActionType", 0)]
            public partial System.Boolean CHECK_ACTION(Dialog.ActionType type); 
*/
            /// <summary>
            ///   System.Void ClearLevel(System.Int32 levelId)
            /// </summary>
            /// <param name = "levelId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClearLevel", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void CLEAR_LEVEL(System.Int32 levelId); 
*/
            /// <summary>
            ///   System.Boolean CompleteTask(System.Int32 taskId)
            /// </summary>
            /// <param name = "taskId">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CompleteTask", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean COMPLETE_TASK(System.Int32 taskId); 
*/
            /// <summary>
            ///   System.Void CostAction(Dialog.ActionType type)
            /// </summary>
            /// <param name = "type">enum Dialog.ActionType</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CostAction", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Dialog.ActionType", 0)]
            public partial void COST_ACTION(Dialog.ActionType type); 
*/
            /// <summary>
            ///   System.Void DelayCancelDot(System.Int32 id, System.Int32 time)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "time">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DelayCancelDot", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void DELAY_CANCEL_DOT(System.Int32 id, System.Int32 time); 
*/
            /// <summary>
            ///   System.Void DelayDot(System.Int32 id, System.Int32 time)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "time">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DelayDot", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void DELAY_DOT(System.Int32 id, System.Int32 time); 
*/
            /// <summary>
            ///   System.Void Dot(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Dot", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void DOT(System.Int32 id); 
*/
            /// <summary>
            ///   System.Boolean Doted(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Doted", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean DOTED(System.Int32 id); 
*/
            /// <summary>
            ///   System.Boolean EnterFight(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EnterFight", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean ENTER_FIGHT(System.Int32 id); 
*/
            /// <summary>
            ///   System.Void Equip(System.Int32 itemId)
            /// </summary>
            /// <param name = "itemId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Equip", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void EQUIP(System.Int32 itemId); 
*/
            /// <summary>
            ///   System.Boolean EquipActive(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EquipActive", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean EQUIP_ACTIVE(System.Int32 id); 
*/
            /// <summary>
            ///   System.Void EquipPassive(System.Int32 id, DBLoad.WuXueType type)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "type">enum DBLoad.WuXueType</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EquipPassive", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DBLoad.WuXueType", 1)]
            public partial void EQUIP_PASSIVE(System.Int32 id, DBLoad.WuXueType type); 
*/
            /// <summary>
            ///   System.Boolean ExistWander(DBLoad.UnlockId id)
            /// </summary>
            /// <param name = "id">enum DBLoad.UnlockId</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ExistWander", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DBLoad.UnlockId", 0)]
            public partial System.Boolean EXIST_WANDER(DBLoad.UnlockId id); 
*/
            /// <summary>
            ///   System.Boolean FailTask(System.Int32 taskId)
            /// </summary>
            /// <param name = "taskId">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FailTask", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean FAIL_TASK(System.Int32 taskId); 
*/
            /// <summary>
            ///   System.Boolean GanWuActived(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GanWuActived", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean GAN_WU_ACTIVED(System.Int32 id); 
*/
            /// <summary>
            ///   System.Int32[] get_Actives()
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Actives", "System.Int32[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ACTIVES(); 
*/
            /// <summary>
            ///   System.String get_FullName()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_FullName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_FULL_NAME(); 
*/
            /// <summary>
            ///   System.Int32 get_Hour()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Hour", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_HOUR(); 
*/
            /// <summary>
            ///   System.Int32 get_Hp()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Hp", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_HP(); 
*/
            /// <summary>
            ///   System.Single get_HpPer()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_HpPer", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_HP_PER(); 
*/
            /// <summary>
            ///   System.Boolean get_InYangCheng()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_InYangCheng", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IN_YANG_CHENG(); 
*/
            /// <summary>
            ///   System.Int32 get_JingLi()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_JingLi", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_JING_LI(); 
*/
            /// <summary>
            ///   System.Single get_JingLiPer()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_JingLiPer", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_JING_LI_PER(); 
*/
            /// <summary>
            ///   System.Int32 get_LeaderId()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_LeaderId", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_LEADER_ID(); 
*/
            /// <summary>
            ///   System.Int32 get_Minute()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Minute", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_MINUTE(); 
*/
            /// <summary>
            ///   System.Int32 get_Mp()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Mp", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_MP(); 
*/
            /// <summary>
            ///   System.Single get_MpPer()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_MpPer", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_MP_PER(); 
*/
            /// <summary>
            ///   System.Int32 get_PostNum()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_PostNum", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_POST_NUM(); 
*/
            /// <summary>
            ///   System.Int32 get_RealTime()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_RealTime", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_REAL_TIME(); 
*/
            /// <summary>
            ///   SceneEnum get_Scene()
            /// </summary>
            /// <returns>enum SceneEnum</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Scene", "SceneEnum", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial SceneEnum GET_SCENE(); 
*/
            /// <summary>
            ///   System.Int32 get_ShowBranchId()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ShowBranchId", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_SHOW_BRANCH_ID(); 
*/
            /// <summary>
            ///   System.Int32 get_ShowMainId()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ShowMainId", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_SHOW_MAIN_ID(); 
*/
            /// <summary>
            ///   System.String get_Skin()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Skin", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SKIN(); 
*/
            /// <summary>
            ///   System.Int32 get_TiLi()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_TiLi", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_TI_LI(); 
*/
            /// <summary>
            ///   System.Int32 get_Turn()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Turn", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_TURN(); 
*/
            /// <summary>
            ///   System.Boolean get_YangCheng()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_YangCheng", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_YANG_CHENG(); 
*/
            /// <summary>
            ///   System.Int32 GetActionCost(Dialog.ActionType type)
            /// </summary>
            /// <param name = "type">enum Dialog.ActionType</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetActionCost", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Dialog.ActionType", 0)]
            public partial System.Int32 GET_ACTION_COST(Dialog.ActionType type); 
*/
            /// <summary>
            ///   System.Int32 GetAnimalExp(System.Int32 npcId)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAnimalExp", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_ANIMAL_EXP(System.Int32 npcId); 
*/
            /// <summary>
            ///   System.Int32 GetAnimalLv(System.Int32 npcId)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAnimalLv", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_ANIMAL_LV(System.Int32 npcId); 
*/
            /// <summary>
            ///   System.Int32 GetCharacterId(System.Int32 npcId)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCharacterId", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_CHARACTER_ID(System.Int32 npcId); 
*/
            /// <summary>
            ///   CharacterInfo GetCharacterInfo(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class CharacterInfo</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCharacterInfo", "CharacterInfo", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_CHARACTER_INFO(System.Int32 id); 
*/
            /// <summary>
            ///   System.Int32 GetEffectLv(DBLoad.EffectId id)
            /// </summary>
            /// <param name = "id">enum DBLoad.EffectId</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEffectLv", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DBLoad.EffectId", 0)]
            public partial System.Int32 GET_EFFECT_LV(DBLoad.EffectId id); 
*/
            /// <summary>
            ///   System.Single GetEffectValue(DBLoad.EffectId id)
            /// </summary>
            /// <param name = "id">enum DBLoad.EffectId</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEffectValue", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DBLoad.EffectId", 0)]
            public partial System.Single GET_EFFECT_VALUE(DBLoad.EffectId id); 
*/
            /// <summary>
            ///   System.Int32 GetEffectValueInt(DBLoad.EffectId id)
            /// </summary>
            /// <param name = "id">enum DBLoad.EffectId</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEffectValueInt", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DBLoad.EffectId", 0)]
            public partial System.Int32 GET_EFFECT_VALUE_INT(DBLoad.EffectId id); 
*/
            /// <summary>
            ///   System.String GetFavoName(System.Int32 npcId)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFavoName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_FAVO_NAME(System.Int32 npcId); 
*/
            /// <summary>
            ///   System.Int32 GetFriendLv(System.Int32 npcId)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFriendLv", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_FRIEND_LV(System.Int32 npcId); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<System.Int32> GetGlobalBuffs()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetGlobalBuffs", "System.Collections.Generic.List<System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_GLOBAL_BUFFS(); 
*/
            /// <summary>
            ///   System.Single GetGlobalBuffValue(DBLoad.GlobalBuffType type, System.Int32 index)
            /// </summary>
            /// <param name = "type">enum DBLoad.GlobalBuffType</param>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetGlobalBuffValue", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DBLoad.GlobalBuffType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Single GET_GLOBAL_BUFF_VALUE(DBLoad.GlobalBuffType type, System.Int32 index); 
*/
            /// <summary>
            ///   System.Int32 GetItemNum(System.Int32 itemId)
            /// </summary>
            /// <param name = "itemId">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItemNum", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_ITEM_NUM(System.Int32 itemId); 
*/
            /// <summary>
            ///   System.Int32 GetNpcFavo(System.Int32 npcId)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNpcFavo", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_NPC_FAVO(System.Int32 npcId); 
*/
            /// <summary>
            ///   NpcInfo GetNpcInfo(System.Int32 npcId)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <returns>class NpcInfo</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNpcInfo", "NpcInfo", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_NPC_INFO(System.Int32 npcId); 
*/
            /// <summary>
            ///   System.Void GetPost(System.Int32 id, System.Int32 rewardId)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "rewardId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPost", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void GET_POST(System.Int32 id, System.Int32 rewardId); 
*/
            /// <summary>
            ///   System.Int32 GetPostBegin(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPostBegin", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_POST_BEGIN(System.Int32 id); 
*/
            /// <summary>
            ///   System.Void GetReward(System.Int32 id, Dialog.ActionType type)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "type">enum Dialog.ActionType</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetReward", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Dialog.ActionType", 1)]
            public partial void GET_REWARD(System.Int32 id, Dialog.ActionType type); 
*/
            /// <summary>
            ///   System.Int32 GetRewardIndex(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRewardIndex", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_REWARD_INDEX(System.Int32 id); 
*/
            /// <summary>
            ///   System.Int32 GetSkillId(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkillId", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_SKILL_ID(System.Int32 id); 
*/
            /// <summary>
            ///   System.Int32 GetStoreRefreshTime(System.Int32 npcId)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetStoreRefreshTime", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_STORE_REFRESH_TIME(System.Int32 npcId); 
*/
            /// <summary>
            ///   System.Int32 GetWuXueCurExp(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetWuXueCurExp", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_WU_XUE_CUR_EXP(System.Int32 id); 
*/
            /// <summary>
            ///   System.Int32 GetWuXueLv(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetWuXueLv", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_WU_XUE_LV(System.Int32 id); 
*/
            /// <summary>
            ///   System.Void LockDialog(System.Int32 dialogId)
            /// </summary>
            /// <param name = "dialogId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LockDialog", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void LOCK_DIALOG(System.Int32 dialogId); 
*/
            /// <summary>
            ///   System.Void LockWander(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LockWander", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void LOCK_WANDER(System.Int32 id); 
*/
            /// <summary>
            ///   System.Void LockWeiTuo(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LockWeiTuo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void LOCK_WEI_TUO(System.Int32 id); 
*/
            /// <summary>
            ///   System.Boolean NpcFighted(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("NpcFighted", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean NPC_FIGHTED(System.Int32 id); 
*/
            /// <summary>
            ///   System.Boolean NpcHaveItem(System.Int32 npcId)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("NpcHaveItem", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean NPC_HAVE_ITEM(System.Int32 npcId); 
*/
            /// <summary>
            ///   System.Boolean PostReceived(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("PostReceived", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean POST_RECEIVED(System.Int32 id); 
*/
            /// <summary>
            ///   System.Boolean ReadDanFang(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReadDanFang", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean READ_DAN_FANG(System.Int32 id); 
*/
            /// <summary>
            ///   System.Boolean ReadDaZao(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReadDaZao", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean READ_DA_ZAO(System.Int32 id); 
*/
            /// <summary>
            ///   System.Boolean Readed(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Readed", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean READED(System.Int32 id); 
*/
            /// <summary>
            ///   System.Boolean ReadWuXue(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReadWuXue", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean READ_WU_XUE(System.Int32 id); 
*/
            /// <summary>
            ///   System.Boolean ReceivePost(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReceivePost", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean RECEIVE_POST(System.Int32 id); 
*/
            /// <summary>
            ///   System.Boolean ReceiveTask(System.Int32 taskId)
            /// </summary>
            /// <param name = "taskId">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReceiveTask", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean RECEIVE_TASK(System.Int32 taskId); 
*/
            /// <summary>
            ///   System.Void Recover(DBLoad.RecoverType type, System.Int32 value)
            /// </summary>
            /// <param name = "type">enum DBLoad.RecoverType</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Recover", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DBLoad.RecoverType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void RECOVER(DBLoad.RecoverType type, System.Int32 value); 
*/
            /// <summary>
            ///   System.Void RecoverPercent(DBLoad.RecoverType type, System.Int32 value)
            /// </summary>
            /// <param name = "type">enum DBLoad.RecoverType</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RecoverPercent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DBLoad.RecoverType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void RECOVER_PERCENT(DBLoad.RecoverType type, System.Int32 value); 
*/
            /// <summary>
            ///   System.Void RefreshTime(System.Int32 time)
            /// </summary>
            /// <param name = "time">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RefreshTime", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void REFRESH_TIME(System.Int32 time); 
*/
            /// <summary>
            ///   System.Void SavePos()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SavePos", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void SAVE_POS(); 
*/
            /// <summary>
            ///   System.Void set_Hp(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Hp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_HP(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_HpPer(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_HpPer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void SET_HP_PER(System.Single value); 
*/
            /// <summary>
            ///   System.Void set_JingLi(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_JingLi", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_JING_LI(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_JingLiPer(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_JingLiPer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void SET_JING_LI_PER(System.Single value); 
*/
            /// <summary>
            ///   System.Void set_Mp(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Mp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_MP(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_MpPer(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_MpPer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void SET_MP_PER(System.Single value); 
*/
            /// <summary>
            ///   System.Void set_RealTime(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_RealTime", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_REAL_TIME(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_Scene(SceneEnum value)
            /// </summary>
            /// <param name = "value">enum SceneEnum</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Scene", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("SceneEnum", 0)]
            public partial void SET_SCENE(SceneEnum value); 
*/
            /// <summary>
            ///   System.Void set_ShowBranchId(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_ShowBranchId", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_SHOW_BRANCH_ID(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_ShowMainId(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_ShowMainId", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_SHOW_MAIN_ID(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_Skin(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Skin", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_SKIN(nint value); 
*/
            /// <summary>
            ///   System.Void set_TiLi(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_TiLi", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_TI_LI(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_Turn(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Turn", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_TURN(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_YangCheng(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_YangCheng", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_YANG_CHENG(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void SetCharacterInfo(System.Int32 id, System.Single hp, System.Single mp)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "hp">struct System.Single</param>
            /// <param name = "mp">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetCharacterInfo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            public partial void SET_CHARACTER_INFO(System.Int32 id, System.Single hp, System.Single mp); 
*/
            /// <summary>
            ///   System.Void SetFriendLv(System.Int32 npcId, System.Int32 lv)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <param name = "lv">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetFriendLv", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void SET_FRIEND_LV(System.Int32 npcId, System.Int32 lv); 
*/
            /// <summary>
            ///   System.Void SwagFight(System.Int32 index, System.Int32 newIndex)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "newIndex">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SwagFight", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void SWAG_FIGHT(System.Int32 index, System.Int32 newIndex); 
*/
            /// <summary>
            ///   System.Boolean Taked(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Taked", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean TAKED(System.Int32 id); 
*/
            /// <summary>
            ///   System.Boolean TaskCompleted(System.Int32 taskId)
            /// </summary>
            /// <param name = "taskId">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TaskCompleted", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean TASK_COMPLETED(System.Int32 taskId); 
*/
            /// <summary>
            ///   System.Boolean TaskFailed(System.Int32 taskId)
            /// </summary>
            /// <param name = "taskId">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TaskFailed", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean TASK_FAILED(System.Int32 taskId); 
*/
            /// <summary>
            ///   System.Boolean TaskReceived(System.Int32 taskId)
            /// </summary>
            /// <param name = "taskId">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TaskReceived", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean TASK_RECEIVED(System.Int32 taskId); 
*/
            /// <summary>
            ///   System.Void TriggerDialog(DBLoad.DialogTrigger trigger, System.Int32 value)
            /// </summary>
            /// <param name = "trigger">enum DBLoad.DialogTrigger</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TriggerDialog", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DBLoad.DialogTrigger", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void TRIGGER_DIALOG(DBLoad.DialogTrigger trigger, System.Int32 value); 
*/
            /// <summary>
            ///   System.Void TriggerWander(DBLoad.UnlockId id)
            /// </summary>
            /// <param name = "id">enum DBLoad.UnlockId</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TriggerWander", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DBLoad.UnlockId", 0)]
            public partial void TRIGGER_WANDER(DBLoad.UnlockId id); 
*/
            /// <summary>
            ///   System.Void Unload(System.Int32 index)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Unload", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UNLOAD(System.Int32 index); 
*/
            /// <summary>
            ///   System.Boolean Unlock(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Unlock", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean UNLOCK(System.Int32 id); 
*/
            /// <summary>
            ///   System.Void UnlockActive(System.Int32 index)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UnlockActive", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UNLOCK_ACTIVE(System.Int32 index); 
*/
            /// <summary>
            ///   System.Void UnlockDialog(System.Int32 dialogId)
            /// </summary>
            /// <param name = "dialogId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UnlockDialog", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UNLOCK_DIALOG(System.Int32 dialogId); 
*/
            /// <summary>
            ///   System.Boolean Unlocked(DBLoad.UnlockId id)
            /// </summary>
            /// <param name = "id">enum DBLoad.UnlockId</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Unlocked", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DBLoad.UnlockId", 0)]
            public partial System.Boolean UNLOCKED(DBLoad.UnlockId id); 
*/
            /// <summary>
            ///   System.Void UnlockPassive(System.Int32 index)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UnlockPassive", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UNLOCK_PASSIVE(System.Int32 index); 
*/
            /// <summary>
            ///   System.Void UnlockWander(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UnlockWander", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UNLOCK_WANDER(System.Int32 id); 
*/
            /// <summary>
            ///   System.Void UnlockWeiTuo(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UnlockWeiTuo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UNLOCK_WEI_TUO(System.Int32 id); 
*/
            /// <summary>
            ///   System.Void UseItem(System.Int32 id, System.Single num)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "num">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UseItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial void USE_ITEM(System.Int32 id, System.Single num); 
*/
            /// <summary>
            ///   System.Boolean WeiTuoLocked(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("WeiTuoLocked", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean WEI_TUO_LOCKED(System.Int32 id); 
*/
            /// <summary>
            ///   System.Boolean WuXueEquiped(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("WuXueEquiped", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean WU_XUE_EQUIPED(System.Int32 id); 
*/
        }
    }
}