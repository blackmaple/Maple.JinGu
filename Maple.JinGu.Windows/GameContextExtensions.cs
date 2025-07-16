using Maple.MonoGameAssistant.WebApi;
using Maple.MonoGameAssistant.Windows.Service;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.JinGu.Windows
{
    public static class GameContextExtensions
    {
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)/*, typeof(CallConvSuppressGCTransition)*/], EntryPoint = nameof(Maple))]
        [return: MarshalAs(UnmanagedType.I4)]
        public static int Maple()
        {
            var webapp = WebApiServiceExtensions.AsRunWebApiService(p =>
            {
                p.GameName = "今古群侠传";
                p.QQ = "QQ:75351663/QQGroup:41426227";
                p.Http = true;
                p.NamedPipe = true;
                p.AutoOpenUrl = true;

            }, services =>
            {
                services.UseGameContextService<GameContextService>();
            });

            //延迟启动
            Thread.Sleep(8000);
            webapp.Run();

            return 1;
        }

    }
}
