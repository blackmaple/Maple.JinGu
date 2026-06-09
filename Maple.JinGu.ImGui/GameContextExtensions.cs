using Maple.UnityAssistant.Context.D3D11;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.JinGu.ImGui
{
    public static class GameContextExtensions
    {
  

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)/*, typeof(CallConvSuppressGCTransition)*/], EntryPoint = nameof(Maple))]
        [return: MarshalAs(UnmanagedType.I4)]
        public static int Maple()
        {
            D3D11GameContextExtensions.Run<GameContextService>(p =>
            {
                p.GameName = "今古群侠传";
                p.QQ = "QQ:75351663";
            },millisecondsTimeout:8000);
            return default;
        }
    }
}
