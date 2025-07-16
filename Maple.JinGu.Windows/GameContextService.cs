using Maple.JinGu.Metadata;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.Windows.HotKey.HookWindowMessage;
using Maple.MonoGameAssistant.Windows.Service;
using Microsoft.Extensions.Logging;

namespace Maple.JinGu.Windows
{
    public sealed class GameContextService(ILogger<GameMetadataContext> logger, MonoRuntimeContext runtimeContext, MonoTaskScheduler monoTaskScheduler, MonoGameSettings gameSettings, HookWinMsgFactory hookWinMsgFactory)
                : GameContextService<GameMetadataContext>(logger, runtimeContext, monoTaskScheduler, gameSettings, hookWinMsgFactory)

    {
        protected override GameMetadataContext LoadGameContext()
        {
            var searchService = new MonoGameAssistant.MetadataExtensions.MetadataService.MetadataCollectorSearchService();
            searchService.UpdateMetadata(new MonoDescriptionCollectionDTO()
            {
                Classes = GameMetadataContext.MonoJsonClassDTO,
                Methods = GameMetadataContext.MonoJsonMethodDTO,
                Fields = GameMetadataContext.MonoJsonFieldDTO,
            });
            return new GameMetadataContext(Logger, searchService, RuntimeContext);
        }

        protected override IUnityPlayerNativeMethods? LoadUnityEngineContext()
        {
            var cache = Maple.MonoGameAssistant.MetadataUnity.UnityMetadataContext_MONO.MethodOffsetCache;
            cache[Maple.MonoGameAssistant.MetadataUnity.Graphics.Code_FunctionPointerType_BLIT2_E9370053514A1DE4] = 0x9FAD0;
            cache[Maple.MonoGameAssistant.MetadataUnity.ImageConversion.Code_FunctionPointerType_ENCODE_TO_PNG_B997C8D2C1188DD2] = 0x1C38B0;
            cache[Maple.MonoGameAssistant.MetadataUnity.Sprite.Code_FunctionPointerType_GET_TEXTURE_RECT_INJECTED_991A7878D43EDC7F] = 0x120B70;
            cache[Maple.MonoGameAssistant.MetadataUnity.Texture2D.Code_FunctionPointerType_READ_PIXELS_IMPL_INJECTED_3D6557C7BC276B18] = 0xC5830;

            return Maple.MonoGameAssistant.MetadataUnity.UnityMetadataContext.CreateUnityMetadataContext(this.RuntimeContext, this.Logger);
        }
    }
}
