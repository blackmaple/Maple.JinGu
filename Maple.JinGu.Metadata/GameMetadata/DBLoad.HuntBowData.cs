namespace Maple.JinGu.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp"."DBLoad"."HuntBowData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_HuntBowData>, Ptr_HuntBowData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "DBLoad", "HuntBowData", "DBLoad.HuntBowData")]
    public partial class HuntBowData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_HuntBowData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_HuntBowData(System.IntPtr ptr) => new Ptr_HuntBowData(ptr);
            public static implicit operator System.IntPtr(Ptr_HuntBowData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_HuntBowData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."HuntBowData"]
        /// </summary>
        partial struct Ptr_HuntBowData
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
            /// 0x14 System.Int32 m_speed
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_speed", "System.Int32")]
            public partial System.Int32 M_SPEED { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32 m_shootSpeed
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_shootSpeed", "System.Int32")]
            public partial System.Int32 M_SHOOT_SPEED { get; set; } 
*/

            /// <summary>
            /// 0x1C System.Int32 m_damage
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_damage", "System.Int32")]
            public partial System.Int32 M_DAMAGE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."HuntBowData"]
        /// </summary>
        partial struct Ptr_HuntBowData
        {
            /// <summary>
            ///   System.Void .ctor(System.Int32 _id, System.Int32 _speed, System.Int32 _shootSpeed, System.Int32 _damage)
            /// </summary>
            /// <param name = "_id">struct System.Int32</param>
            /// <param name = "_speed">struct System.Int32</param>
            /// <param name = "_shootSpeed">struct System.Int32</param>
            /// <param name = "_damage">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            public partial void CTOR(System.Int32 _id, System.Int32 _speed, System.Int32 _shootSpeed, System.Int32 _damage); 
*/
        }
    }
}