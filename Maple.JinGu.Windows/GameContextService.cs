using Maple.JinGu.Metadata;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.Windows.HotKey.HookWindowMessage;
using Maple.MonoGameAssistant.Windows.Service;
using Maple.MonoGameAssistant.Windows.UITask;
using Microsoft.Extensions.Logging;

namespace Maple.JinGu.Windows
{
    public sealed class GameContextService(ILogger<GameMetadataContext> logger, MonoRuntimeContext runtimeContext, MonoTaskScheduler monoTaskScheduler, MonoGameSettings gameSettings, HookWinMsgFactory hookWinMsgFactory)
                : GameContextService<GameMetadataContext>(logger, runtimeContext, monoTaskScheduler, gameSettings, hookWinMsgFactory)

    {

        protected override void HookWindowMessage()
        {
            // base.HookWindowMessage();
        }

        public override ValueTask<GameSessionInfoDTO> GetSessionInfoAsync()
        {
            this.ServiceException = default;
            return base.GetSessionInfoAsync();
        }

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

        public required GameResourceCache Cache { get; set; }
        protected override async ValueTask LoadGameDataAsync()
        {
            this.Cache = await this.MonoTaskAsync((p) => GameResourceCache.Create(p)).ConfigureAwait(false);
        }

        private Task<GameCheatService> GetCheatServiceThrowIfNotInGameAsync()
        {
            return this.MonoTaskAsync((p) => GameCheatService.CreateCheatService(this.Cache));
        }

        public override ValueTask<GameCurrencyDisplayDTO[]> GetListCurrencyDisplayAsync()
        {
            return new ValueTask<GameCurrencyDisplayDTO[]>(this.Cache.CurrencyResources);
        }
        public override async ValueTask<GameCurrencyInfoDTO> GetCurrencyInfoAsync(GameCurrencyObjectDTO currencyObjectDTO)
        {
            var gameCheatService = await this.GetCheatServiceThrowIfNotInGameAsync().ConfigureAwait(false);
            var info = await this.MonoTaskAsync((p, args) => args.gameCheatService.GetCurrencyInfoDTO(args.currencyObjectDTO), (gameCheatService, currencyObjectDTO)).ConfigureAwait(false);
            return info;
        }
        public override async ValueTask<GameCurrencyInfoDTO> UpdateCurrencyInfoAsync(GameCurrencyModifyDTO currencyModifyDTO)
        {
            var gameCheatService = await this.GetCheatServiceThrowIfNotInGameAsync().ConfigureAwait(false);
            var info = await this.MonoTaskAsync((p, args) => args.gameCheatService.UpdateCurrencyInfoDTO(args.currencyModifyDTO), (gameCheatService, currencyModifyDTO)).ConfigureAwait(false);
            return info;
        }

        public override ValueTask<GameInventoryDisplayDTO[]> GetListInventoryDisplayAsync()
        {
            return new ValueTask<GameInventoryDisplayDTO[]>(this.Cache.InventoryResources);
        }
        public override async ValueTask<GameInventoryInfoDTO> GetInventoryInfoAsync(GameInventoryObjectDTO inventoryObjectDTO)
        {
            var gameCheatService = await this.GetCheatServiceThrowIfNotInGameAsync().ConfigureAwait(false);
            var info = await this.MonoTaskAsync((p, args) => args.gameCheatService.GetInventoryInfoDTO(args.inventoryObjectDTO), (gameCheatService, inventoryObjectDTO)).ConfigureAwait(false);
            return info;
        }
        public override async ValueTask<GameInventoryInfoDTO> UpdateInventoryInfoAsync(GameInventoryModifyDTO inventoryModifyDTO)
        {
            var gameCheatService = await this.GetCheatServiceThrowIfNotInGameAsync().ConfigureAwait(false);
            var info = await this.MonoTaskAsync((p, args) => args.gameCheatService.UpdateInventoryInfoDTO(args.inventoryModifyDTO), (gameCheatService, inventoryModifyDTO)).ConfigureAwait(false);
            return info;
        }

        public override ValueTask<GameMonsterDisplayDTO[]> GetListMonsterDisplayAsync()
        {
            return new ValueTask<GameMonsterDisplayDTO[]>([.. this.Cache.NPCResources]);
        }
        public override async ValueTask<GameCharacterSkillDTO> AddMonsterMemberAsync(GameMonsterObjectDTO monsterObjectDTO)
        {
            var gameCheatService = await this.GetCheatServiceThrowIfNotInGameAsync().ConfigureAwait(false);
            var info = await this.UITaskAsync((p, args) => args.gameCheatService.AddMonsterMember(args.monsterObjectDTO), (gameCheatService, monsterObjectDTO)).ConfigureAwait(false);
            return info;
        }

        public override async ValueTask<GameCharacterDisplayDTO[]> GetListCharacterDisplayAsync()
        {
            var gameCheatService = await this.GetCheatServiceThrowIfNotInGameAsync().ConfigureAwait(false);
            var info = await this.MonoTaskAsync((p, gameCheatService) => gameCheatService.GetCharacterResources().ToArray(), gameCheatService).ConfigureAwait(false);
            return info;
        }
        public override async ValueTask<GameCharacterStatusDTO> GetCharacterStatusAsync(GameCharacterObjectDTO characterObjectDTO)
        {
            var gameCheatService = await this.GetCheatServiceThrowIfNotInGameAsync().ConfigureAwait(false);
            var info = await this.MonoTaskAsync((p, args) => args.gameCheatService.GetCharacterStatus(args.characterObjectDTO), (gameCheatService, characterObjectDTO)).ConfigureAwait(false);
            return info;
        }
        public override async ValueTask<GameCharacterStatusDTO> UpdateCharacterStatusAsync(GameCharacterModifyDTO characterModifyDTO)
        {
            var gameCheatService = await this.GetCheatServiceThrowIfNotInGameAsync().ConfigureAwait(false);
            var info = await this.MonoTaskAsync((p, args) => args.gameCheatService.UpdateCharacterStatus(args.characterModifyDTO), (gameCheatService, characterModifyDTO)).ConfigureAwait(false);
            return info;

        }

        public override ValueTask<GameSkillDisplayDTO[]> GetListSkillDisplayAsync()
        {
            return new ValueTask<GameSkillDisplayDTO[]>([.. this.Cache.SkillResources.Where(p => p.DisplayCategory == nameof(GlobalBuff))]);
        }
        public override async ValueTask<GameCharacterSkillDTO> GetCharacterSkillAsync(GameCharacterObjectDTO characterObjectDTO)
        {
            var gameCheatService = await this.GetCheatServiceThrowIfNotInGameAsync().ConfigureAwait(false);
            var info = await this.MonoTaskAsync((p, args) => args.gameCheatService.GetCharacterSkill(args.characterObjectDTO), (gameCheatService, characterObjectDTO)).ConfigureAwait(false);
            return info;
        }
        public override async ValueTask<GameCharacterSkillDTO> UpdateCharacterSkillAsync(GameCharacterModifyDTO characterModifyDTO)
        {
            var gameCheatService = await this.GetCheatServiceThrowIfNotInGameAsync().ConfigureAwait(false);
            var info = await this.MonoTaskAsync((p, args) => args.gameCheatService.UpdateCharacterSkill(args.characterModifyDTO), (gameCheatService, characterModifyDTO)).ConfigureAwait(false);
            return info;
        }
    }
}
