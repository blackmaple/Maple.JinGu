namespace Maple.JinGu.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp"."DBLoad"."WuXueData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_WuXueData>, Ptr_WuXueData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "DBLoad", "WuXueData", "DBLoad.WuXueData")]
    public partial class WuXueData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_WuXueData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_WuXueData(System.IntPtr ptr) => new Ptr_WuXueData(ptr);
            public static implicit operator System.IntPtr(Ptr_WuXueData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_WuXueData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."WuXueData"]
        /// </summary>
        partial struct Ptr_WuXueData
        {
            /// <summary>
            /// 0x10 System.Int32[] m_lvNeed
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_lvNeed", "System.Int32[]")]
            public partial nint M_LV_NEED { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32[] m_skill
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_skill", "System.Int32[]")]
            public partial nint M_SKILL { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int32[] m_effectId
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_effectId", "System.Int32[]")]
            public partial nint M_EFFECT_ID { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Single[] m_effectValue
            /// class ["mscorlib"."System"."Single[]"]
            /// </summary>
            /// <returns>class System.Single[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_effectValue", "System.Single[]")]
            public partial nint M_EFFECT_VALUE { get; set; } 
*/

            /// <summary>
            /// 0x30 System.String m_desc
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_desc", "System.String")]
            public partial nint M_DESC { get; set; } 


            /// <summary>
            /// 0x38 System.Int32[] m_condition
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_condition", "System.Int32[]")]
            public partial nint M_CONDITION { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Int32[][] m_conditionValue
            /// class ["mscorlib"."System"."Int32[][]"]
            /// </summary>
            /// <returns>class System.Int32[][]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_conditionValue", "System.Int32[][]")]
            public partial nint M_CONDITION_VALUE { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Int32 m_id
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_id", "System.Int32")]
            public partial System.Int32 M_ID { get; set; } 


            /// <summary>
            /// 0x4C System.Int32 m_type
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_type", "System.Int32")]
            public partial System.Int32 M_TYPE { get; set; } 


            /// <summary>
            /// 0x50 System.Int32 m_lvMax
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_lvMax", "System.Int32")]
            public partial System.Int32 M_LV_MAX { get; set; } 


            /// <summary>
            /// 0x54 System.Int32 m_exp
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_exp", "System.Int32")]
            public partial System.Int32 M_EXP { get; set; } 

        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."WuXueData"]
        /// </summary>
        partial struct Ptr_WuXueData
        {
            /// <summary>
            ///   System.Void .ctor(System.Int32 _id, System.Int32 _type, System.Int32 _lvMax, System.Int32 _exp, System.Int32[] _lvNeed, System.Int32[] _skill, System.Int32[] _effectId, System.Single[] _effectValue, System.String _desc, System.Int32[] _condition, System.Int32[][] _conditionValue)
            /// </summary>
            /// <param name = "_id">struct System.Int32</param>
            /// <param name = "_type">struct System.Int32</param>
            /// <param name = "_lvMax">struct System.Int32</param>
            /// <param name = "_exp">struct System.Int32</param>
            /// <param name = "_lvNeed">class System.Int32[]</param>
            /// <param name = "_skill">class System.Int32[]</param>
            /// <param name = "_effectId">class System.Int32[]</param>
            /// <param name = "_effectValue">class System.Single[]</param>
            /// <param name = "_desc">class System.String</param>
            /// <param name = "_condition">class System.Int32[]</param>
            /// <param name = "_conditionValue">class System.Int32[][]</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 6)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single[]", 7)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 8)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 9)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[][]", 10)]
            public partial void CTOR(System.Int32 _id, System.Int32 _type, System.Int32 _lvMax, System.Int32 _exp, nint _lvNeed, nint _skill, nint _effectId, nint _effectValue, nint _desc, nint _condition, nint _conditionValue); 
*/
        }
    }
}