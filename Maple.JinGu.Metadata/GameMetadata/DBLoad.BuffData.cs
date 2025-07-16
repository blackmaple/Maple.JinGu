namespace Maple.JinGu.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp"."DBLoad"."BuffData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_BuffData>, Ptr_BuffData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "DBLoad", "BuffData", "DBLoad.BuffData")]
    public partial class BuffData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_BuffData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_BuffData(System.IntPtr ptr) => new Ptr_BuffData(ptr);
            public static implicit operator System.IntPtr(Ptr_BuffData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_BuffData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."BuffData"]
        /// </summary>
        partial struct Ptr_BuffData
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
            /// 0x20 System.Int32[] m_value
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_value", "System.Int32[]")]
            public partial nint M_VALUE { get; set; } 
*/

            /// <summary>
            /// 0x28 System.String m_icon
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_icon", "System.String")]
            public partial nint M_ICON { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Int32 m_id
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_id", "System.Int32")]
            public partial System.Int32 M_ID { get; set; } 
*/

            /// <summary>
            /// 0x34 System.Int32 m_turnTimes
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_turnTimes", "System.Int32")]
            public partial System.Int32 M_TURN_TIMES { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Int32 m_type
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_type", "System.Int32")]
            public partial System.Int32 M_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x3C System.Int32 m_sole
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_sole", "System.Int32")]
            public partial System.Int32 M_SOLE { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Int32 m_initNum
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_initNum", "System.Int32")]
            public partial System.Int32 M_INIT_NUM { get; set; } 
*/

            /// <summary>
            /// 0x44 System.Int32 m_state
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_state", "System.Int32")]
            public partial System.Int32 M_STATE { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Int32 m_begin
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_begin", "System.Int32")]
            public partial System.Int32 M_BEGIN { get; set; } 
*/

            /// <summary>
            /// 0x4C System.Int32 m_command
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_command", "System.Int32")]
            public partial System.Int32 M_COMMAND { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Int32 m_show
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_show", "System.Int32")]
            public partial System.Int32 M_SHOW { get; set; } 
*/

            /// <summary>
            /// 0x54 System.Int32 m_de
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_de", "System.Int32")]
            public partial System.Int32 M_DE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."BuffData"]
        /// </summary>
        partial struct Ptr_BuffData
        {
            /// <summary>
            ///   System.Void .ctor(System.Int32 _id, System.String _name, System.String _desc, System.Int32 _turnTimes, System.Int32 _type, System.Int32[] _value, System.Int32 _sole, System.Int32 _initNum, System.Int32 _state, System.Int32 _begin, System.Int32 _command, System.Int32 _show, System.Int32 _de, System.String _icon)
            /// </summary>
            /// <param name = "_id">struct System.Int32</param>
            /// <param name = "_name">class System.String</param>
            /// <param name = "_desc">class System.String</param>
            /// <param name = "_turnTimes">struct System.Int32</param>
            /// <param name = "_type">struct System.Int32</param>
            /// <param name = "_value">class System.Int32[]</param>
            /// <param name = "_sole">struct System.Int32</param>
            /// <param name = "_initNum">struct System.Int32</param>
            /// <param name = "_state">struct System.Int32</param>
            /// <param name = "_begin">struct System.Int32</param>
            /// <param name = "_command">struct System.Int32</param>
            /// <param name = "_show">struct System.Int32</param>
            /// <param name = "_de">struct System.Int32</param>
            /// <param name = "_icon">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 7)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 8)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 9)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 10)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 11)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 12)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 13)]
            public partial void CTOR(System.Int32 _id, nint _name, nint _desc, System.Int32 _turnTimes, System.Int32 _type, nint _value, System.Int32 _sole, System.Int32 _initNum, System.Int32 _state, System.Int32 _begin, System.Int32 _command, System.Int32 _show, System.Int32 _de, nint _icon); 
*/
        }
    }
}