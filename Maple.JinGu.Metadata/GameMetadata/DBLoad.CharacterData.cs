namespace Maple.JinGu.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp"."DBLoad"."CharacterData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_CharacterData>, Ptr_CharacterData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "DBLoad", "CharacterData", "DBLoad.CharacterData")]
    public partial class CharacterData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_CharacterData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_CharacterData(System.IntPtr ptr) => new Ptr_CharacterData(ptr);
            public static implicit operator System.IntPtr(Ptr_CharacterData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_CharacterData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."CharacterData"]
        /// </summary>
        partial struct Ptr_CharacterData
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
            /// 0x20 System.String m_chengHao
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_chengHao", "System.String")]
            public partial nint M_CHENG_HAO { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Int32[] m_skills
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_skills", "System.Int32[]")]
            public partial nint M_SKILLS { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Int32[] m_passives
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_passives", "System.Int32[]")]
            public partial nint M_PASSIVES { get; set; } 
*/

            /// <summary>
            /// 0x38 System.String m_behaviorTree
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_behaviorTree", "System.String")]
            public partial nint M_BEHAVIOR_TREE { get; set; } 
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
            /// 0x44 System.Int32 m_res
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_res", "System.Int32")]
            public partial System.Int32 M_RES { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Int32 m_hp
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_hp", "System.Int32")]
            public partial System.Int32 M_HP { get; set; } 
*/

            /// <summary>
            /// 0x4C System.Int32 m_mp
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_mp", "System.Int32")]
            public partial System.Int32 M_MP { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Int32 m_damage
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_damage", "System.Int32")]
            public partial System.Int32 M_DAMAGE { get; set; } 
*/

            /// <summary>
            /// 0x54 System.Int32 m_atk
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_atk", "System.Int32")]
            public partial System.Int32 M_ATK { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Int32 m_def
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_def", "System.Int32")]
            public partial System.Int32 M_DEF { get; set; } 
*/

            /// <summary>
            /// 0x5C System.Int32 m_crt
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_crt", "System.Int32")]
            public partial System.Int32 M_CRT { get; set; } 
*/

            /// <summary>
            /// 0x60 System.Int32 m_eva
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_eva", "System.Int32")]
            public partial System.Int32 M_EVA { get; set; } 
*/

            /// <summary>
            /// 0x64 System.Int32 m_speed
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_speed", "System.Int32")]
            public partial System.Int32 M_SPEED { get; set; } 
*/

            /// <summary>
            /// 0x68 System.Int32 m_move
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_move", "System.Int32")]
            public partial System.Int32 M_MOVE { get; set; } 
*/

            /// <summary>
            /// 0x6C System.Int32 m_range
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_range", "System.Int32")]
            public partial System.Int32 M_RANGE { get; set; } 
*/

            /// <summary>
            /// 0x70 System.Int32 m_sizeType
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_sizeType", "System.Int32")]
            public partial System.Int32 M_SIZE_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x74 System.Int32 m_atkScope
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_atkScope", "System.Int32")]
            public partial System.Int32 M_ATK_SCOPE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."CharacterData"]
        /// </summary>
        partial struct Ptr_CharacterData
        {
            /// <summary>
            ///   System.Void .ctor(System.Int32 _id, System.Int32 _res, System.String _name, System.String _desc, System.String _chengHao, System.Int32 _hp, System.Int32 _mp, System.Int32 _damage, System.Int32 _atk, System.Int32 _def, System.Int32 _crt, System.Int32 _eva, System.Int32 _speed, System.Int32 _move, System.Int32 _range, System.Int32 _sizeType, System.Int32 _atkScope, System.Int32[] _skills, System.Int32[] _passives, System.String _behaviorTree)
            /// </summary>
            /// <param name = "_id">struct System.Int32</param>
            /// <param name = "_res">struct System.Int32</param>
            /// <param name = "_name">class System.String</param>
            /// <param name = "_desc">class System.String</param>
            /// <param name = "_chengHao">class System.String</param>
            /// <param name = "_hp">struct System.Int32</param>
            /// <param name = "_mp">struct System.Int32</param>
            /// <param name = "_damage">struct System.Int32</param>
            /// <param name = "_atk">struct System.Int32</param>
            /// <param name = "_def">struct System.Int32</param>
            /// <param name = "_crt">struct System.Int32</param>
            /// <param name = "_eva">struct System.Int32</param>
            /// <param name = "_speed">struct System.Int32</param>
            /// <param name = "_move">struct System.Int32</param>
            /// <param name = "_range">struct System.Int32</param>
            /// <param name = "_sizeType">struct System.Int32</param>
            /// <param name = "_atkScope">struct System.Int32</param>
            /// <param name = "_skills">class System.Int32[]</param>
            /// <param name = "_passives">class System.Int32[]</param>
            /// <param name = "_behaviorTree">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 7)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 8)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 9)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 10)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 11)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 12)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 13)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 14)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 15)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 16)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 17)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 18)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 19)]
            public partial void CTOR(System.Int32 _id, System.Int32 _res, nint _name, nint _desc, nint _chengHao, System.Int32 _hp, System.Int32 _mp, System.Int32 _damage, System.Int32 _atk, System.Int32 _def, System.Int32 _crt, System.Int32 _eva, System.Int32 _speed, System.Int32 _move, System.Int32 _range, System.Int32 _sizeType, System.Int32 _atkScope, nint _skills, nint _passives, nint _behaviorTree); 
*/
        }
    }
}