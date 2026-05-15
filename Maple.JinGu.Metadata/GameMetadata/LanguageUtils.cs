using Maple.MonoGameAssistant.Core;

namespace Maple.JinGu.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."LanguageUtils"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_LanguageUtils>, Ptr_LanguageUtils>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "LanguageUtils", "LanguageUtils")]
    public partial class LanguageUtils
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_LanguageUtils(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_LanguageUtils(System.IntPtr ptr) => new Ptr_LanguageUtils(ptr);
            public static implicit operator System.IntPtr(Ptr_LanguageUtils ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_LanguageUtils ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."LanguageUtils"]
        /// </summary>
        partial struct Ptr_LanguageUtils
        {
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."LanguageUtils"]
        /// </summary>
        partial struct Ptr_LanguageUtils
        {
            /// <summary>
            /// static  System.String ConvertSkillDesc(System.String str)
            /// </summary>
            /// <param name = "str">class System.String</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ConvertSkillDesc", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public static partial nint CONVERT_SKILL_DESC(nint str); 
*/
            /// <summary>
            /// static  System.String get_GetAutoSave()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_GetAutoSave", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_GET_AUTO_SAVE(); 
*/
            /// <summary>
            /// static  System.String get_GetCameraFollow()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_GetCameraFollow", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_GET_CAMERA_FOLLOW(); 
*/
            /// <summary>
            /// static  System.String get_GetFightMove()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_GetFightMove", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_GET_FIGHT_MOVE(); 
*/
            /// <summary>
            /// static  System.String get_GetFps()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_GetFps", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_GET_FPS(); 
*/
            /// <summary>
            /// static  System.String get_GetFullScreen()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_GetFullScreen", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_GET_FULL_SCREEN(); 
*/
            /// <summary>
            /// static  System.String get_GetLanguage()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_GetLanguage", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_GET_LANGUAGE(); 
*/
            /// <summary>
            /// static  System.String get_GetPauseTime()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_GetPauseTime", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_GET_PAUSE_TIME(); 
*/
            /// <summary>
            /// static  System.String get_GetResolution()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_GetResolution", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_GET_RESOLUTION(); 
*/
            /// <summary>
            /// static  System.String GetActiveType(DBLoad.WuXueType type)
            /// </summary>
            /// <param name = "type">enum DBLoad.WuXueType</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetActiveType", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DBLoad.WuXueType", 0)]
            public static partial nint GET_ACTIVE_TYPE(DBLoad.WuXueType type); 
*/
            /// <summary>
            /// static  System.String GetDifficultName(DiffucultEnum dif)
            /// </summary>
            /// <param name = "dif">enum DiffucultEnum</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDifficultName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DiffucultEnum", 0)]
            public static partial nint GET_DIFFICULT_NAME(DiffucultEnum dif); 
*/
            /// <summary>
            /// static  System.String GetEquipType(System.Int32 type)
            /// </summary>
            /// <param name = "type">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEquipType", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial nint GET_EQUIP_TYPE(System.Int32 type); 
*/
            /// <summary>
            /// static  System.String GetGiftType(System.Int32 type)
            /// </summary>
            /// <param name = "type">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetGiftType", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial nint GET_GIFT_TYPE(System.Int32 type); 
*/
            /// <summary>
            /// static  System.String GetItemType(DBLoad.ItemType type)
            /// </summary>
            /// <param name = "type">enum DBLoad.ItemType</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItemType", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DBLoad.ItemType", 0)]
            public static partial nint GET_ITEM_TYPE(DBLoad.ItemType type); 
*/
            /// <summary>
            /// static  System.String GetLandformName(Fight.LandformType landform)
            /// </summary>
            /// <param name = "landform">enum Fight.LandformType</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLandformName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Fight.LandformType", 0)]
            public static partial nint GET_LANDFORM_NAME(Fight.LandformType landform); 
*/
            /// <summary>
            /// static  System.String GetNpcGroup(System.Int32 type)
            /// </summary>
            /// <param name = "type">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNpcGroup", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial nint GET_NPC_GROUP(System.Int32 type); 
*/
            /// <summary>
            /// static  System.String GetPropType(System.Int32 type)
            /// </summary>
            /// <param name = "type">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPropType", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial nint GET_PROP_TYPE(System.Int32 type); 
*/
            /// <summary>
            /// static  System.String GetStr(System.String pre)
            /// </summary>
            /// <param name = "pre">class System.String</param>
            /// <returns>class System.String</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetStr", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public static partial PMonoString GET_STR(PMonoString pre); 

            /// <summary>
            /// static  System.String GetStr(System.Int32 id, System.String pre)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "pre">class System.String</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetStr", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public static partial nint GET_STR(System.Int32 id, nint pre); 
*/
            /// <summary>
            /// static  System.String GetTextDef(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTextDef", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial nint GET_TEXT_DEF(System.Int32 id); 
*/
            /// <summary>
            /// static  System.String GetTextDef(System.Int32 id, System.Object[] args)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "args">class System.Object[]</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTextDef", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object[]", 1)]
            public static partial nint GET_TEXT_DEF(System.Int32 id, nint args); 
*/
            /// <summary>
            /// static  System.String GetTurn(System.Int32 turn)
            /// </summary>
            /// <param name = "turn">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTurn", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial nint GET_TURN(System.Int32 turn); 
*/
            /// <summary>
            /// static  System.String GetWuXueType(DBLoad.WuXueType type)
            /// </summary>
            /// <param name = "type">enum DBLoad.WuXueType</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetWuXueType", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DBLoad.WuXueType", 0)]
            public static partial nint GET_WU_XUE_TYPE(DBLoad.WuXueType type); 
*/
            /// <summary>
            /// static  System.Void RollUpTips(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RollUpTips", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial void ROLL_UP_TIPS(System.Int32 id); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
        }
    }
}