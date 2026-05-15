using Maple.MonoGameAssistant.Core;

namespace Maple.JinGu.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp"."DBLoad"."AchieveData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_AchieveData>, Ptr_AchieveData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "DBLoad", "AchieveData", "DBLoad.AchieveData")]
    public partial class AchieveData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_AchieveData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_AchieveData(System.IntPtr ptr) => new Ptr_AchieveData(ptr);
            public static implicit operator System.IntPtr(Ptr_AchieveData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_AchieveData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."AchieveData"]
        /// </summary>
        partial struct Ptr_AchieveData
        {
            /// <summary>
            /// 0x10 System.String m_name
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_name", "System.String")]
            public partial PMonoString M_NAME { get; set; } 


            /// <summary>
            /// 0x18 System.String m_desc
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_desc", "System.String")]
            public partial PMonoString M_DESC { get; set; } 


            /// <summary>
            /// 0x20 System.Int32 m_id
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_id", "System.Int32")]
            public partial System.Int32 M_ID { get; set; } 


            /// <summary>
            /// 0x24 System.Int32 m_type
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_type", "System.Int32")]
            public partial System.Int32 M_TYPE { get; set; } 


            /// <summary>
            /// 0x28 System.Int32 m_hide
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_hide", "System.Int32")]
            public partial System.Int32 M_HIDE { get; set; } 
*/

            /// <summary>
            /// 0x2C System.Int32 m_reward
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_reward", "System.Int32")]
            public partial System.Int32 M_REWARD { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Int32 m_custom
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_custom", "System.Int32")]
            public partial System.Int32 M_CUSTOM { get; set; } 
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
        }

        /// <summary>
        /// class ["Assembly-CSharp"."DBLoad"."AchieveData"]
        /// </summary>
        partial struct Ptr_AchieveData
        {
            /// <summary>
            ///   System.Void .ctor(System.Int32 _id, System.String _name, System.Int32 _type, System.String _desc, System.Int32 _hide, System.Int32 _reward, System.Int32 _custom, System.Int32 _value)
            /// </summary>
            /// <param name = "_id">struct System.Int32</param>
            /// <param name = "_name">class System.String</param>
            /// <param name = "_type">struct System.Int32</param>
            /// <param name = "_desc">class System.String</param>
            /// <param name = "_hide">struct System.Int32</param>
            /// <param name = "_reward">struct System.Int32</param>
            /// <param name = "_custom">struct System.Int32</param>
            /// <param name = "_value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 7)]
            public partial void CTOR(System.Int32 _id, nint _name, System.Int32 _type, nint _desc, System.Int32 _hide, System.Int32 _reward, System.Int32 _custom, System.Int32 _value); 
*/
        }
    }
}