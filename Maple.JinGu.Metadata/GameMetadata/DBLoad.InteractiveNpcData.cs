namespace Maple.JinGu.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp"."DBLoad"."InteractiveNpcData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_InteractiveNpcData>, Ptr_InteractiveNpcData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "DBLoad", "InteractiveNpcData", "DBLoad.InteractiveNpcData")]
    public partial class InteractiveNpcData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_InteractiveNpcData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_InteractiveNpcData(System.IntPtr ptr) => new Ptr_InteractiveNpcData(ptr);
            public static implicit operator System.IntPtr(Ptr_InteractiveNpcData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_InteractiveNpcData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."InteractiveNpcData"]
        /// </summary>
        partial struct Ptr_InteractiveNpcData
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
            /// 0x18 System.Int32[] m_itemId
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_itemId", "System.Int32[]")]
            public partial nint M_ITEM_ID { get; set; } 
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
            /// 0x28 System.Int32[] m_giftTypePrefer
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_giftTypePrefer", "System.Int32[]")]
            public partial nint M_GIFT_TYPE_PREFER { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Int32[] m_giftIdPrefer
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_giftIdPrefer", "System.Int32[]")]
            public partial nint M_GIFT_ID_PREFER { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Int32[] m_giftHate
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_giftHate", "System.Int32[]")]
            public partial nint M_GIFT_HATE { get; set; } 
*/

            /// <summary>
            /// 0x40 System.String m_desc
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_desc", "System.String")]
            public partial nint M_DESC { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Int32[] m_task
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_task", "System.Int32[]")]
            public partial nint M_TASK { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Int32 m_id
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_id", "System.Int32")]
            public partial System.Int32 M_ID { get; set; } 
*/

            /// <summary>
            /// 0x54 System.Int32 m_money
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_money", "System.Int32")]
            public partial System.Int32 M_MONEY { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Int32 m_refresh
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_refresh", "System.Int32")]
            public partial System.Int32 M_REFRESH { get; set; } 
*/

            /// <summary>
            /// 0x5C System.Int32 m_favor
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_favor", "System.Int32")]
            public partial System.Int32 M_FAVOR { get; set; } 
*/

            /// <summary>
            /// 0x60 System.Int32 m_group
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_group", "System.Int32")]
            public partial System.Int32 M_GROUP { get; set; } 
*/

            /// <summary>
            /// 0x64 System.Int32 m_characterId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_characterId", "System.Int32")]
            public partial System.Int32 M_CHARACTER_ID { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."InteractiveNpcData"]
        /// </summary>
        partial struct Ptr_InteractiveNpcData
        {
            /// <summary>
            ///   System.Void .ctor(System.Int32 _id, System.String _name, System.Int32[] _itemId, System.Int32[] _itemNum, System.Int32 _money, System.Int32 _refresh, System.Int32 _favor, System.Int32[] _giftTypePrefer, System.Int32[] _giftIdPrefer, System.Int32[] _giftHate, System.Int32 _group, System.Int32 _characterId, System.String _desc, System.Int32[] _task)
            /// </summary>
            /// <param name = "_id">struct System.Int32</param>
            /// <param name = "_name">class System.String</param>
            /// <param name = "_itemId">class System.Int32[]</param>
            /// <param name = "_itemNum">class System.Int32[]</param>
            /// <param name = "_money">struct System.Int32</param>
            /// <param name = "_refresh">struct System.Int32</param>
            /// <param name = "_favor">struct System.Int32</param>
            /// <param name = "_giftTypePrefer">class System.Int32[]</param>
            /// <param name = "_giftIdPrefer">class System.Int32[]</param>
            /// <param name = "_giftHate">class System.Int32[]</param>
            /// <param name = "_group">struct System.Int32</param>
            /// <param name = "_characterId">struct System.Int32</param>
            /// <param name = "_desc">class System.String</param>
            /// <param name = "_task">class System.Int32[]</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 7)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 8)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 9)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 10)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 11)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 12)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 13)]
            public partial void CTOR(System.Int32 _id, nint _name, nint _itemId, nint _itemNum, System.Int32 _money, System.Int32 _refresh, System.Int32 _favor, nint _giftTypePrefer, nint _giftIdPrefer, nint _giftHate, System.Int32 _group, System.Int32 _characterId, nint _desc, nint _task); 
*/
        }
    }
}