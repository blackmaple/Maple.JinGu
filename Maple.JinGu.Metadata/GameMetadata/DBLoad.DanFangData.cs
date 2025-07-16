namespace Maple.JinGu.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp"."DBLoad"."DanFangData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_DanFangData>, Ptr_DanFangData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "DBLoad", "DanFangData", "DBLoad.DanFangData")]
    public partial class DanFangData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_DanFangData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_DanFangData(System.IntPtr ptr) => new Ptr_DanFangData(ptr);
            public static implicit operator System.IntPtr(Ptr_DanFangData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_DanFangData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."DanFangData"]
        /// </summary>
        partial struct Ptr_DanFangData
        {
            /// <summary>
            /// 0x10 System.Int32[] m_start
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_start", "System.Int32[]")]
            public partial nint M_START { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32[] m_item
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_item", "System.Int32[]")]
            public partial nint M_ITEM { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int32[] m_itemNum
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_itemNum", "System.Int32[]")]
            public partial nint M_ITEM_NUM { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Int32[] m_fireStart
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_fireStart", "System.Int32[]")]
            public partial nint M_FIRE_START { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Int32[] m_danYao
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_danYao", "System.Int32[]")]
            public partial nint M_DAN_YAO { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Int32[] m_exp
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_exp", "System.Int32[]")]
            public partial nint M_EXP { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Int32 m_id
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_id", "System.Int32")]
            public partial System.Int32 M_ID { get; set; } 
*/

            /// <summary>
            /// 0x44 System.Int32 m_lv
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_lv", "System.Int32")]
            public partial System.Int32 M_LV { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Int32 m_time
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_time", "System.Int32")]
            public partial System.Int32 M_TIME { get; set; } 
*/

            /// <summary>
            /// 0x4C System.Int32 m_fireLength
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_fireLength", "System.Int32")]
            public partial System.Int32 M_FIRE_LENGTH { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."DanFangData"]
        /// </summary>
        partial struct Ptr_DanFangData
        {
            /// <summary>
            ///   System.Void .ctor(System.Int32 _id, System.Int32 _lv, System.Int32 _time, System.Int32[] _start, System.Int32[] _item, System.Int32[] _itemNum, System.Int32[] _fireStart, System.Int32 _fireLength, System.Int32[] _danYao, System.Int32[] _exp)
            /// </summary>
            /// <param name = "_id">struct System.Int32</param>
            /// <param name = "_lv">struct System.Int32</param>
            /// <param name = "_time">struct System.Int32</param>
            /// <param name = "_start">class System.Int32[]</param>
            /// <param name = "_item">class System.Int32[]</param>
            /// <param name = "_itemNum">class System.Int32[]</param>
            /// <param name = "_fireStart">class System.Int32[]</param>
            /// <param name = "_fireLength">struct System.Int32</param>
            /// <param name = "_danYao">class System.Int32[]</param>
            /// <param name = "_exp">class System.Int32[]</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 6)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 7)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 8)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 9)]
            public partial void CTOR(System.Int32 _id, System.Int32 _lv, System.Int32 _time, nint _start, nint _item, nint _itemNum, nint _fireStart, System.Int32 _fireLength, nint _danYao, nint _exp); 
*/
        }
    }
}