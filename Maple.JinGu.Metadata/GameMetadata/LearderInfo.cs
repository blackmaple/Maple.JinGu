namespace Maple.JinGu.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."LearderInfo"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_LearderInfo>, Ptr_LearderInfo>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "LearderInfo", "LearderInfo")]
    public partial class LearderInfo
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_LearderInfo(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_LearderInfo(System.IntPtr ptr) => new Ptr_LearderInfo(ptr);
            public static implicit operator System.IntPtr(Ptr_LearderInfo ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_LearderInfo ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."LearderInfo"]
        /// </summary>
        partial struct Ptr_LearderInfo
        {
            /// <summary>
            /// 0x10 UnityEngine.Sprite m_dialog
            /// class ["UnityEngine.CoreModule"."UnityEngine"."Sprite"]
            /// </summary>
            /// <returns>class UnityEngine.Sprite</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_dialog", "UnityEngine.Sprite")]
            public partial nint M_DIALOG { get; set; } 
*/

            /// <summary>
            /// 0x18 SerializedDictionary<DBLoad.EquipType , LeaderFight> m_dic
            /// class ["Assembly-CSharp".""."SerializedDictionary`2"]
            /// </summary>
            /// <returns>class SerializedDictionary<DBLoad.EquipType , LeaderFight></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_dic", "SerializedDictionary<DBLoad.EquipType,LeaderFight>")]
            public partial nint M_DIC { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."LearderInfo"]
        /// </summary>
        partial struct Ptr_LearderInfo
        {
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