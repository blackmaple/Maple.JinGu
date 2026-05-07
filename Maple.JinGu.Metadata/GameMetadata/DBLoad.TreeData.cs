namespace Maple.JinGu.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp"."DBLoad"."TreeData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TreeData>, Ptr_TreeData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "DBLoad", "TreeData", "DBLoad.TreeData")]
    public partial class TreeData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TreeData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TreeData(System.IntPtr ptr) => new Ptr_TreeData(ptr);
            public static implicit operator System.IntPtr(Ptr_TreeData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TreeData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."TreeData"]
        /// </summary>
        partial struct Ptr_TreeData
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
            /// 0x18 System.Int32[] m_pre
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_pre", "System.Int32[]")]
            public partial nint M_PRE { get; set; } 
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
            /// 0x30 System.Int32 m_id
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_id", "System.Int32")]
            public partial System.Int32 M_ID { get; set; } 
*/

            /// <summary>
            /// 0x34 System.Int32 m_group
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_group", "System.Int32")]
            public partial System.Int32 M_GROUP { get; set; } 
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

            /// <summary>
            /// 0x3C System.Int32 m_cost
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_cost", "System.Int32")]
            public partial System.Int32 M_COST { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."TreeData"]
        /// </summary>
        partial struct Ptr_TreeData
        {
            /// <summary>
            ///   System.Void .ctor(System.Int32 _id, System.String _name, System.Int32 _group, System.Int32[] _pre, System.Int32[] _effectId, System.Single[] _effectValue, System.Int32 _passive, System.Int32 _cost)
            /// </summary>
            /// <param name = "_id">struct System.Int32</param>
            /// <param name = "_name">class System.String</param>
            /// <param name = "_group">struct System.Int32</param>
            /// <param name = "_pre">class System.Int32[]</param>
            /// <param name = "_effectId">class System.Int32[]</param>
            /// <param name = "_effectValue">class System.Single[]</param>
            /// <param name = "_passive">struct System.Int32</param>
            /// <param name = "_cost">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single[]", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 7)]
            public partial void CTOR(System.Int32 _id, nint _name, System.Int32 _group, nint _pre, nint _effectId, nint _effectValue, System.Int32 _passive, System.Int32 _cost); 
*/
        }
    }
}