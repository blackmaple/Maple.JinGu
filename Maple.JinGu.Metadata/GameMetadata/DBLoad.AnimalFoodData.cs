namespace Maple.JinGu.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp"."DBLoad"."AnimalFoodData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_AnimalFoodData>, Ptr_AnimalFoodData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "DBLoad", "AnimalFoodData", "DBLoad.AnimalFoodData")]
    public partial class AnimalFoodData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_AnimalFoodData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_AnimalFoodData(System.IntPtr ptr) => new Ptr_AnimalFoodData(ptr);
            public static implicit operator System.IntPtr(Ptr_AnimalFoodData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_AnimalFoodData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."AnimalFoodData"]
        /// </summary>
        partial struct Ptr_AnimalFoodData
        {
            /// <summary>
            /// 0x10 System.Int32 m_id
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_id", "System.Int32")]
            public partial System.Int32 M_ID { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Int32 m_type
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_type", "System.Int32")]
            public partial System.Int32 M_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32 m_exp
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_exp", "System.Int32")]
            public partial System.Int32 M_EXP { get; set; } 
*/

            /// <summary>
            /// 0x1C System.Int32 m_favor
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_favor", "System.Int32")]
            public partial System.Int32 M_FAVOR { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int32 m_siYu
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_siYu", "System.Int32")]
            public partial System.Int32 M_SI_YU { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."AnimalFoodData"]
        /// </summary>
        partial struct Ptr_AnimalFoodData
        {
            /// <summary>
            ///   System.Void .ctor(System.Int32 _id, System.Int32 _type, System.Int32 _exp, System.Int32 _favor, System.Int32 _siYu)
            /// </summary>
            /// <param name = "_id">struct System.Int32</param>
            /// <param name = "_type">struct System.Int32</param>
            /// <param name = "_exp">struct System.Int32</param>
            /// <param name = "_favor">struct System.Int32</param>
            /// <param name = "_siYu">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
            public partial void CTOR(System.Int32 _id, System.Int32 _type, System.Int32 _exp, System.Int32 _favor, System.Int32 _siYu); 
*/
        }
    }
}