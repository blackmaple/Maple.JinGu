namespace Maple.JinGu.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp"."DBLoad"."NpcData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_NpcData>, Ptr_NpcData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "DBLoad", "NpcData", "DBLoad.NpcData")]
    public partial class NpcData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_NpcData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_NpcData(System.IntPtr ptr) => new Ptr_NpcData(ptr);
            public static implicit operator System.IntPtr(Ptr_NpcData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_NpcData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."NpcData"]
        /// </summary>
        partial struct Ptr_NpcData
        {
            /// <summary>
            /// 0x10 System.String m_name
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_name", "System.String")]
            public partial nint M_NAME { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32 m_id
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_id", "System.Int32")]
            public partial System.Int32 M_ID { get; set; } 
*/

            /// <summary>
            /// 0x1C System.Int32 m_hide
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_hide", "System.Int32")]
            public partial System.Int32 M_HIDE { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int32 m_refresh
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_refresh", "System.Int32")]
            public partial System.Int32 M_REFRESH { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."NpcData"]
        /// </summary>
        partial struct Ptr_NpcData
        {
            /// <summary>
            ///   System.Void .ctor(System.Int32 _id, System.String _name, System.Int32 _hide, System.Int32 _refresh)
            /// </summary>
            /// <param name = "_id">struct System.Int32</param>
            /// <param name = "_name">class System.String</param>
            /// <param name = "_hide">struct System.Int32</param>
            /// <param name = "_refresh">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            public partial void CTOR(System.Int32 _id, nint _name, System.Int32 _hide, System.Int32 _refresh); 
*/
        }
    }
}