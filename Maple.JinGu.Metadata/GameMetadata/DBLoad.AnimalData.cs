namespace Maple.JinGu.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp"."DBLoad"."AnimalData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_AnimalData>, Ptr_AnimalData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "DBLoad", "AnimalData", "DBLoad.AnimalData")]
    public partial class AnimalData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_AnimalData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_AnimalData(System.IntPtr ptr) => new Ptr_AnimalData(ptr);
            public static implicit operator System.IntPtr(Ptr_AnimalData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_AnimalData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."AnimalData"]
        /// </summary>
        partial struct Ptr_AnimalData
        {
            /// <summary>
            /// 0x10 System.Int32[] m_foodType
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_foodType", "System.Int32[]")]
            public partial nint M_FOOD_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x18 System.String m_skin
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_skin", "System.String")]
            public partial nint M_SKIN { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int32 m_id
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_id", "System.Int32")]
            public partial System.Int32 M_ID { get; set; } 


            /// <summary>
            /// 0x24 System.Int32 m_npcId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_npcId", "System.Int32")]
            public partial System.Int32 M_NPC_ID { get; set; } 


            /// <summary>
            /// 0x28 System.Int32 m_level
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             
             [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_level", "System.Int32")]
             public partial System.Int32 M_LEVEL { get; set; } 


            /// <summary>
            /// 0x2C System.Int32 m_exp
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             
            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_exp", "System.Int32")]
            //public partial System.Int32 M_EXP { get; set; } 


            /// <summary>
            /// 0x30 System.Int32 m_characterId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_characterId", "System.Int32")]
            public partial System.Int32 M_CHARACTER_ID { get; set; } 


            /// <summary>
            /// 0x34 System.Single m_size
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_size", "System.Single")]
            public partial System.Single M_SIZE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."AnimalData"]
        /// </summary>
        partial struct Ptr_AnimalData
        {
            /// <summary>
            ///   System.Void .ctor(System.Int32 _id, System.Int32 _npcId, System.Int32 _level, System.Int32 _exp, System.Int32 _characterId, System.Int32[] _foodType, System.Single _size, System.String _skin)
            /// </summary>
            /// <param name = "_id">struct System.Int32</param>
            /// <param name = "_npcId">struct System.Int32</param>
            /// <param name = "_level">struct System.Int32</param>
            /// <param name = "_exp">struct System.Int32</param>
            /// <param name = "_characterId">struct System.Int32</param>
            /// <param name = "_foodType">class System.Int32[]</param>
            /// <param name = "_size">struct System.Single</param>
            /// <param name = "_skin">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 6)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 7)]
            public partial void CTOR(System.Int32 _id, System.Int32 _npcId, System.Int32 _level, System.Int32 _exp, System.Int32 _characterId, nint _foodType, System.Single _size, nint _skin); 
*/
        }
    }
}