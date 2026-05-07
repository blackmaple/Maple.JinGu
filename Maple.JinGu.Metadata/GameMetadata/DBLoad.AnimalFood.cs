namespace Maple.JinGu.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp"."DBLoad"."AnimalFood"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_AnimalFood>, Ptr_AnimalFood>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "DBLoad", "AnimalFood", "DBLoad.AnimalFood")]
    public partial class AnimalFood
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_AnimalFood(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_AnimalFood(System.IntPtr ptr) => new Ptr_AnimalFood(ptr);
            public static implicit operator System.IntPtr(Ptr_AnimalFood ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_AnimalFood ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."AnimalFood"]
        /// </summary>
        partial struct Ptr_AnimalFood
        {
            /// <summary>
            /// 0x0 System.Collections.Generic.Dictionary<System.Int32 , DBLoad.AnimalFoodData> m_dic
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , DBLoad.AnimalFoodData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_dic", "System.Collections.Generic.Dictionary<System.Int32,DBLoad.AnimalFoodData>")]
            public static partial nint M_DIC { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."AnimalFood"]
        /// </summary>
        partial struct Ptr_AnimalFood
        {
            /// <summary>
            /// static  DBLoad.AnimalFoodData Get(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class DBLoad.AnimalFoodData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Get", "DBLoad.AnimalFoodData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial nint GET(System.Int32 id); 
*/
            /// <summary>
            /// static  System.Collections.Generic.Dictionary<System.Int32 , DBLoad.AnimalFoodData> get_Dic()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , DBLoad.AnimalFoodData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Dic", "System.Collections.Generic.Dictionary<System.Int32,DBLoad.AnimalFoodData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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