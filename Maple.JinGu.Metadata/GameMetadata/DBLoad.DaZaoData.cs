namespace Maple.JinGu.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp"."DBLoad"."DaZaoData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_DaZaoData>, Ptr_DaZaoData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "DBLoad", "DaZaoData", "DBLoad.DaZaoData")]
    public partial class DaZaoData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_DaZaoData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_DaZaoData(System.IntPtr ptr) => new Ptr_DaZaoData(ptr);
            public static implicit operator System.IntPtr(Ptr_DaZaoData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_DaZaoData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."DaZaoData"]
        /// </summary>
        partial struct Ptr_DaZaoData
        {
            /// <summary>
            /// 0x10 System.Int32[] m_item
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_item", "System.Int32[]")]
            public partial nint M_ITEM { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32[] m_num
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_num", "System.Int32[]")]
            public partial nint M_NUM { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int32 m_id
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_id", "System.Int32")]
            public partial System.Int32 M_ID { get; set; } 
*/

            /// <summary>
            /// 0x24 System.Int32 m_lv
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_lv", "System.Int32")]
            public partial System.Int32 M_LV { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Int32 m_get
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_get", "System.Int32")]
            public partial System.Int32 M_GET { get; set; } 
*/

            /// <summary>
            /// 0x2C System.Int32 m_exp
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_exp", "System.Int32")]
            public partial System.Int32 M_EXP { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."DaZaoData"]
        /// </summary>
        partial struct Ptr_DaZaoData
        {
            /// <summary>
            ///   System.Void .ctor(System.Int32 _id, System.Int32 _lv, System.Int32[] _item, System.Int32[] _num, System.Int32 _get, System.Int32 _exp)
            /// </summary>
            /// <param name = "_id">struct System.Int32</param>
            /// <param name = "_lv">struct System.Int32</param>
            /// <param name = "_item">class System.Int32[]</param>
            /// <param name = "_num">class System.Int32[]</param>
            /// <param name = "_get">struct System.Int32</param>
            /// <param name = "_exp">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
            public partial void CTOR(System.Int32 _id, System.Int32 _lv, nint _item, nint _num, System.Int32 _get, System.Int32 _exp); 
*/
        }
    }
}