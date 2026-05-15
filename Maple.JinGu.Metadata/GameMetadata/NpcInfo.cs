namespace Maple.JinGu.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."NpcInfo"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_NpcInfo>, Ptr_NpcInfo>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "NpcInfo", "NpcInfo")]
    public partial class NpcInfo
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_NpcInfo(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_NpcInfo(System.IntPtr ptr) => new Ptr_NpcInfo(ptr);
            public static implicit operator System.IntPtr(Ptr_NpcInfo ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_NpcInfo ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."NpcInfo"]
        /// </summary>
        partial struct Ptr_NpcInfo
        {
            /// <summary>
            /// 0x10 SerializedDictionary<System.Int32 , System.Int32> m_itemDic
            /// class ["Assembly-CSharp".""."SerializedDictionary`2"]
            /// </summary>
            /// <returns>class SerializedDictionary<System.Int32 , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_itemDic", "SerializedDictionary<System.Int32,System.Int32>")]
            public partial nint M_ITEM_DIC { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32 m_id
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_id", "System.Int32")]
            public partial System.Int32 M_ID { get; set; } 


            /// <summary>
            /// 0x1C System.Boolean m_robed
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_robed", "System.Boolean")]
            public partial System.Boolean M_ROBED { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int32 m_money
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_money", "System.Int32")]
            public partial System.Int32 M_MONEY { get; set; } 
*/

            /// <summary>
            /// 0x24 System.Boolean m_show
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_show", "System.Boolean")]
            public partial System.Boolean M_SHOW { get; set; } 
*/

            /// <summary>
            /// 0x25 System.Boolean m_deaded
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_deaded", "System.Boolean")]
            public partial System.Boolean M_DEADED { get; set; } 


            /// <summary>
            /// 0x28 System.Int32 m_favo
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_favo", "System.Int32")]
            public partial System.Int32 M_FAVO { get; set; } 


            /// <summary>
            /// 0x2C DBLoad.NpcCamp m_camp
            /// enum ["Assembly-CSharp"."DBLoad"."NpcCamp"]
            /// </summary>
            /// <returns>enum DBLoad.NpcCamp</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_camp", "DBLoad.NpcCamp")]
            public partial DBLoad.NpcCamp M_CAMP { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."NpcInfo"]
        /// </summary>
        partial struct Ptr_NpcInfo
        {
            /// <summary>
            ///   System.Void .ctor(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void CTOR(System.Int32 id); 
*/
            /// <summary>
            ///   System.Void ChangeItem(System.Int32 id, System.Int32 num, System.Boolean moneyChange)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "num">struct System.Int32</param>
            /// <param name = "moneyChange">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void CHANGE_ITEM(System.Int32 id, System.Int32 num, System.Boolean moneyChange); 
*/
            /// <summary>
            ///   System.Void ChangeItem(System.Collections.Generic.List<ItemInfo> list)
            /// </summary>
            /// <param name = "list">class System.Collections.Generic.List<ItemInfo></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<ItemInfo>", 0)]
            public partial void CHANGE_ITEM(nint list); 
*/
            /// <summary>
            ///   System.Void Deal(System.Collections.Generic.List<ItemInfo> buys, System.Collections.Generic.List<ItemInfo> sells)
            /// </summary>
            /// <param name = "buys">class System.Collections.Generic.List<ItemInfo></param>
            /// <param name = "sells">class System.Collections.Generic.List<ItemInfo></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Deal", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<ItemInfo>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<ItemInfo>", 1)]
            public partial void DEAL(nint buys, nint sells); 
*/
            /// <summary>
            ///   System.Boolean get_Deaded()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Deaded", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_DEADED(); 
*/
            /// <summary>
            ///   System.Int32 get_Favo()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Favo", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_FAVO(); 
*/
            /// <summary>
            ///   SerializedDictionary<System.Int32 , System.Int32> get_ItemDic()
            /// </summary>
            /// <returns>class SerializedDictionary<System.Int32 , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ItemDic", "SerializedDictionary<System.Int32,System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ITEM_DIC(); 
*/
            /// <summary>
            ///   System.String get_Name()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Name", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_NAME(); 
*/
            /// <summary>
            ///   System.Boolean get_Show()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Show", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_SHOW(); 
*/
            /// <summary>
            ///   System.Void Kill()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Kill", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void KILL(); 
*/
            /// <summary>
            ///   System.Void RefreshStore()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RefreshStore", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void REFRESH_STORE(); 
*/
            /// <summary>
            ///   System.Void Robe()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Robe", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ROBE(); 
*/
            /// <summary>
            ///   System.Void Robed()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Robed", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ROBED(); 
*/
            /// <summary>
            ///   System.Void set_Deaded(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Deaded", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_DEADED(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_Favo(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Favo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_FAVO(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_Show(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Show", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_SHOW(System.Boolean value); 
*/
        }
    }
}