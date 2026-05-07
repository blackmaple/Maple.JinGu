namespace Maple.JinGu.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp"."DBLoad"."Animal"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_Animal>, Ptr_Animal>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "DBLoad", "Animal", "DBLoad.Animal")]
    public partial class Animal
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_Animal(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_Animal(System.IntPtr ptr) => new Ptr_Animal(ptr);
            public static implicit operator System.IntPtr(Ptr_Animal ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_Animal ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."Animal"]
        /// </summary>
        partial struct Ptr_Animal
        {
            /// <summary>
            /// 0x0 System.Collections.Generic.Dictionary<System.Int32 , DBLoad.AnimalData> m_dic
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , DBLoad.AnimalData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_dic", "System.Collections.Generic.Dictionary<System.Int32,DBLoad.AnimalData>")]
            public static partial nint M_DIC { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."Animal"]
        /// </summary>
        partial struct Ptr_Animal
        {
            /// <summary>
            /// static  DBLoad.AnimalData Get(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class DBLoad.AnimalData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Get", "DBLoad.AnimalData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial nint GET(System.Int32 id); 
*/
            /// <summary>
            /// static  System.Collections.Generic.Dictionary<System.Int32 , DBLoad.AnimalData> get_Dic()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , DBLoad.AnimalData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Dic", "System.Collections.Generic.Dictionary<System.Int32,DBLoad.AnimalData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_DIC(); 
*/
            /// <summary>
            /// static  System.Void Init()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Init", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial void INIT(); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
        }
    }
}