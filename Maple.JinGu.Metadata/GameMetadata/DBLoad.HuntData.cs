namespace Maple.JinGu.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp"."DBLoad"."HuntData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_HuntData>, Ptr_HuntData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "DBLoad", "HuntData", "DBLoad.HuntData")]
    public partial class HuntData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_HuntData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_HuntData(System.IntPtr ptr) => new Ptr_HuntData(ptr);
            public static implicit operator System.IntPtr(Ptr_HuntData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_HuntData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."HuntData"]
        /// </summary>
        partial struct Ptr_HuntData
        {
            /// <summary>
            /// 0x10 System.Int32[] m_itemId
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_itemId", "System.Int32[]")]
            public partial nint M_ITEM_ID { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32[] m_itemNum
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_itemNum", "System.Int32[]")]
            public partial nint M_ITEM_NUM { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int32[] m_itemValue
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_itemValue", "System.Int32[]")]
            public partial nint M_ITEM_VALUE { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Int32 m_id
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_id", "System.Int32")]
            public partial System.Int32 M_ID { get; set; } 
*/

            /// <summary>
            /// 0x2C System.Int32 m_hp
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_hp", "System.Int32")]
            public partial System.Int32 M_HP { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Int32 m_speed
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_speed", "System.Int32")]
            public partial System.Int32 M_SPEED { get; set; } 
*/

            /// <summary>
            /// 0x34 System.Int32 m_time
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_time", "System.Int32")]
            public partial System.Int32 M_TIME { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Int32 m_timeCost
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_timeCost", "System.Int32")]
            public partial System.Int32 M_TIME_COST { get; set; } 
*/

            /// <summary>
            /// 0x3C System.Int32 m_exp
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_exp", "System.Int32")]
            public partial System.Int32 M_EXP { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Int32 m_score
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_score", "System.Int32")]
            public partial System.Int32 M_SCORE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."HuntData"]
        /// </summary>
        partial struct Ptr_HuntData
        {
            /// <summary>
            ///   System.Void .ctor(System.Int32 _id, System.Int32[] _itemId, System.Int32[] _itemNum, System.Int32[] _itemValue, System.Int32 _hp, System.Int32 _speed, System.Int32 _time, System.Int32 _timeCost, System.Int32 _exp, System.Int32 _score)
            /// </summary>
            /// <param name = "_id">struct System.Int32</param>
            /// <param name = "_itemId">class System.Int32[]</param>
            /// <param name = "_itemNum">class System.Int32[]</param>
            /// <param name = "_itemValue">class System.Int32[]</param>
            /// <param name = "_hp">struct System.Int32</param>
            /// <param name = "_speed">struct System.Int32</param>
            /// <param name = "_time">struct System.Int32</param>
            /// <param name = "_timeCost">struct System.Int32</param>
            /// <param name = "_exp">struct System.Int32</param>
            /// <param name = "_score">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 7)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 8)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 9)]
            public partial void CTOR(System.Int32 _id, nint _itemId, nint _itemNum, nint _itemValue, System.Int32 _hp, System.Int32 _speed, System.Int32 _time, System.Int32 _timeCost, System.Int32 _exp, System.Int32 _score); 
*/
        }
    }
}