namespace Maple.JinGu.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."WanderInfo"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_WanderInfo>, Ptr_WanderInfo>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "WanderInfo", "NpcWander.WanderInfo")]
    public partial class WanderInfo
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_WanderInfo(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_WanderInfo(System.IntPtr ptr) => new Ptr_WanderInfo(ptr);
            public static implicit operator System.IntPtr(Ptr_WanderInfo ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_WanderInfo ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."WanderInfo"]
        /// </summary>
        partial struct Ptr_WanderInfo
        {
            /// <summary>
            /// 0x10 System.String m_ani
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_ani", "System.String")]
            public partial nint M_ANI { get; set; } 
*/

            /// <summary>
            /// 0x18 UnityEngine.Vector2 m_pos
            /// struct ["UnityEngine.CoreModule"."UnityEngine"."Vector2"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_pos", "UnityEngine.Vector2")]
            public partial UnityEngine.Vector2 M_POS { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Single m_time
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_time", "System.Single")]
            public partial System.Single M_TIME { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."WanderInfo"]
        /// </summary>
        partial struct Ptr_WanderInfo
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