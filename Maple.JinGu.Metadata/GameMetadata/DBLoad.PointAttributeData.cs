namespace Maple.JinGu.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp"."DBLoad"."PointAttributeData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_PointAttributeData>, Ptr_PointAttributeData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "DBLoad", "PointAttributeData", "DBLoad.PointAttributeData")]
    public partial class PointAttributeData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_PointAttributeData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_PointAttributeData(System.IntPtr ptr) => new Ptr_PointAttributeData(ptr);
            public static implicit operator System.IntPtr(Ptr_PointAttributeData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_PointAttributeData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."PointAttributeData"]
        /// </summary>
        partial struct Ptr_PointAttributeData
        {
            /// <summary>
            /// 0x10 System.Int32[] m_effectId
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_effectId", "System.Int32[]")]
            public partial nint M_EFFECT_ID { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Single[] m_effectValue
            /// class ["mscorlib"."System"."Single[]"]
            /// </summary>
            /// <returns>class System.Single[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_effectValue", "System.Single[]")]
            public partial nint M_EFFECT_VALUE { get; set; } 
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
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."PointAttributeData"]
        /// </summary>
        partial struct Ptr_PointAttributeData
        {
            /// <summary>
            ///   System.Void .ctor(System.Int32 _id, System.Int32[] _effectId, System.Single[] _effectValue)
            /// </summary>
            /// <param name = "_id">struct System.Int32</param>
            /// <param name = "_effectId">class System.Int32[]</param>
            /// <param name = "_effectValue">class System.Single[]</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single[]", 2)]
            public partial void CTOR(System.Int32 _id, nint _effectId, nint _effectValue); 
*/
        }
    }
}