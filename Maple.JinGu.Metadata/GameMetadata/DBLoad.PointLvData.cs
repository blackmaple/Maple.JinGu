namespace Maple.JinGu.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp"."DBLoad"."PointLvData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_PointLvData>, Ptr_PointLvData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "DBLoad", "PointLvData", "DBLoad.PointLvData")]
    public partial class PointLvData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_PointLvData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_PointLvData(System.IntPtr ptr) => new Ptr_PointLvData(ptr);
            public static implicit operator System.IntPtr(Ptr_PointLvData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_PointLvData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."PointLvData"]
        /// </summary>
        partial struct Ptr_PointLvData
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
            /// 0x18 System.Int32[] m_effectId
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_effectId", "System.Int32[]")]
            public partial nint M_EFFECT_ID { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Single[] m_effectValue
            /// class ["mscorlib"."System"."Single[]"]
            /// </summary>
            /// <returns>class System.Single[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_effectValue", "System.Single[]")]
            public partial nint M_EFFECT_VALUE { get; set; } 
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
            /// 0x2C System.Int32 m_type
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_type", "System.Int32")]
            public partial System.Int32 M_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Int32 m_lv
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_lv", "System.Int32")]
            public partial System.Int32 M_LV { get; set; } 
*/

            /// <summary>
            /// 0x34 System.Int32 m_value
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_value", "System.Int32")]
            public partial System.Int32 M_VALUE { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Int32 m_passive
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_passive", "System.Int32")]
            public partial System.Int32 M_PASSIVE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."PointLvData"]
        /// </summary>
        partial struct Ptr_PointLvData
        {
            /// <summary>
            ///   System.Void .ctor(System.Int32 _id, System.Int32 _type, System.Int32 _lv, System.String _name, System.Int32 _value, System.Int32[] _effectId, System.Single[] _effectValue, System.Int32 _passive)
            /// </summary>
            /// <param name = "_id">struct System.Int32</param>
            /// <param name = "_type">struct System.Int32</param>
            /// <param name = "_lv">struct System.Int32</param>
            /// <param name = "_name">class System.String</param>
            /// <param name = "_value">struct System.Int32</param>
            /// <param name = "_effectId">class System.Int32[]</param>
            /// <param name = "_effectValue">class System.Single[]</param>
            /// <param name = "_passive">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single[]", 6)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 7)]
            public partial void CTOR(System.Int32 _id, System.Int32 _type, System.Int32 _lv, nint _name, System.Int32 _value, nint _effectId, nint _effectValue, System.Int32 _passive); 
*/
        }
    }
}