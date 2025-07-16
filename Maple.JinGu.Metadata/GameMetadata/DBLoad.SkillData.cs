namespace Maple.JinGu.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp"."DBLoad"."SkillData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_SkillData>, Ptr_SkillData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "DBLoad", "SkillData", "DBLoad.SkillData")]
    public partial class SkillData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_SkillData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_SkillData(System.IntPtr ptr) => new Ptr_SkillData(ptr);
            public static implicit operator System.IntPtr(Ptr_SkillData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_SkillData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."SkillData"]
        /// </summary>
        partial struct Ptr_SkillData
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
            /// 0x18 System.String m_desc
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_desc", "System.String")]
            public partial nint M_DESC { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int32[] m_scopeType
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_scopeType", "System.Int32[]")]
            public partial nint M_SCOPE_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Int32[] m_scope
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_scope", "System.Int32[]")]
            public partial nint M_SCOPE { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Int32[] m_targetType
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_targetType", "System.Int32[]")]
            public partial nint M_TARGET_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Int32[] m_to
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_to", "System.Int32[]")]
            public partial nint M_TO { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Int32[] m_needOperation
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_needOperation", "System.Int32[]")]
            public partial nint M_NEED_OPERATION { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Int32[][] m_effectType
            /// class ["mscorlib"."System"."Int32[][]"]
            /// </summary>
            /// <returns>class System.Int32[][]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_effectType", "System.Int32[][]")]
            public partial nint M_EFFECT_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Int32[][] m_value
            /// class ["mscorlib"."System"."Int32[][]"]
            /// </summary>
            /// <returns>class System.Int32[][]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_value", "System.Int32[][]")]
            public partial nint M_VALUE { get; set; } 
*/

            /// <summary>
            /// 0x58 System.String m_flyRes
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_flyRes", "System.String")]
            public partial nint M_FLY_RES { get; set; } 
*/

            /// <summary>
            /// 0x60 System.String m_explodeRes
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_explodeRes", "System.String")]
            public partial nint M_EXPLODE_RES { get; set; } 
*/

            /// <summary>
            /// 0x68 System.Int32 m_id
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_id", "System.Int32")]
            public partial System.Int32 M_ID { get; set; } 
*/

            /// <summary>
            /// 0x6C System.Int32 m_quality
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_quality", "System.Int32")]
            public partial System.Int32 M_QUALITY { get; set; } 
*/

            /// <summary>
            /// 0x70 System.Int32 m_mpCost
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_mpCost", "System.Int32")]
            public partial System.Int32 M_MP_COST { get; set; } 
*/

            /// <summary>
            /// 0x74 System.Int32 m_CD
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_CD", "System.Int32")]
            public partial System.Int32 M_CD { get; set; } 
*/

            /// <summary>
            /// 0x78 System.Int32 m_currentCD
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_currentCD", "System.Int32")]
            public partial System.Int32 M_CURRENT_CD { get; set; } 
*/

            /// <summary>
            /// 0x7C System.Int32 m_actionAgain
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_actionAgain", "System.Int32")]
            public partial System.Int32 M_ACTION_AGAIN { get; set; } 
*/

            /// <summary>
            /// 0x80 System.Int32 m_selectNumber
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_selectNumber", "System.Int32")]
            public partial System.Int32 M_SELECT_NUMBER { get; set; } 
*/

            /// <summary>
            /// 0x84 System.Int32 m_fullSelect
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_fullSelect", "System.Int32")]
            public partial System.Int32 M_FULL_SELECT { get; set; } 
*/

            /// <summary>
            /// 0x88 System.Int32 m_specialSkill
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_specialSkill", "System.Int32")]
            public partial System.Int32 M_SPECIAL_SKILL { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."SkillData"]
        /// </summary>
        partial struct Ptr_SkillData
        {
            /// <summary>
            ///   System.Void .ctor(System.Int32 _id, System.String _name, System.Int32 _quality, System.String _desc, System.Int32[] _scopeType, System.Int32[] _scope, System.Int32[] _targetType, System.Int32[] _to, System.Int32[] _needOperation, System.Int32[][] _effectType, System.Int32[][] _value, System.Int32 _mpCost, System.Int32 _CD, System.Int32 _currentCD, System.Int32 _actionAgain, System.Int32 _selectNumber, System.Int32 _fullSelect, System.Int32 _specialSkill, System.String _flyRes, System.String _explodeRes)
            /// </summary>
            /// <param name = "_id">struct System.Int32</param>
            /// <param name = "_name">class System.String</param>
            /// <param name = "_quality">struct System.Int32</param>
            /// <param name = "_desc">class System.String</param>
            /// <param name = "_scopeType">class System.Int32[]</param>
            /// <param name = "_scope">class System.Int32[]</param>
            /// <param name = "_targetType">class System.Int32[]</param>
            /// <param name = "_to">class System.Int32[]</param>
            /// <param name = "_needOperation">class System.Int32[]</param>
            /// <param name = "_effectType">class System.Int32[][]</param>
            /// <param name = "_value">class System.Int32[][]</param>
            /// <param name = "_mpCost">struct System.Int32</param>
            /// <param name = "_CD">struct System.Int32</param>
            /// <param name = "_currentCD">struct System.Int32</param>
            /// <param name = "_actionAgain">struct System.Int32</param>
            /// <param name = "_selectNumber">struct System.Int32</param>
            /// <param name = "_fullSelect">struct System.Int32</param>
            /// <param name = "_specialSkill">struct System.Int32</param>
            /// <param name = "_flyRes">class System.String</param>
            /// <param name = "_explodeRes">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 6)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 7)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 8)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[][]", 9)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[][]", 10)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 11)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 12)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 13)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 14)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 15)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 16)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 17)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 18)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 19)]
            public partial void CTOR(System.Int32 _id, nint _name, System.Int32 _quality, nint _desc, nint _scopeType, nint _scope, nint _targetType, nint _to, nint _needOperation, nint _effectType, nint _value, System.Int32 _mpCost, System.Int32 _CD, System.Int32 _currentCD, System.Int32 _actionAgain, System.Int32 _selectNumber, System.Int32 _fullSelect, System.Int32 _specialSkill, nint _flyRes, nint _explodeRes); 
*/
        }
    }
}