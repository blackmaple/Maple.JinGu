using Maple.Hook.Abstractions;
using Maple.Hook.WinMsg;
using Maple.ImGui.Backends.ImGuiCore;
using Maple.JinGu.Metadata;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.DllProxyDobbyHook;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.UnityAssistant.Context;
using Maple.UnityAssistant.Resource;
using Maple.XScheduler;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;
namespace Maple.JinGu.ImGui;

public sealed class GameContextService(
    ILogger<GameContextService> logger,
    MonoRuntimeContext runtimeContext,
    MonoTaskScheduler taskScheduler,
    WinMsgHookFactory winMsgHookFactory,
    MonoInternalCallService internalCallService,
     MonoGameSettings gameSettings,
    IHookFactory hookFactory,
    IXSchedulerFactory schedulerFactory)
    : GameContextService<GameMetadataContext>(logger, runtimeContext, taskScheduler, winMsgHookFactory, internalCallService, gameSettings, hookFactory, schedulerFactory)
{


    protected override GameMetadataContext LoadContextMetadata()
    {
        //foreach (var dic in InternalCallService.InternalCalls)
        //{
        //    this.Logger.LogInformation("InternalCall: {Key} - {Value:X8}", dic.Key, dic.Value);
        //}

        var searchService = new Maple.MonoGameAssistant.MetadataExtensions.MetadataService.MetadataCollectorSearchService();
        searchService.UpdateMetadata(new MonoDescriptionCollectionDTO()
        {
            Classes = GameMetadataContext.MonoJsonClassDTO,
            Methods = GameMetadataContext.MonoJsonMethodDTO,
            Fields = GameMetadataContext.MonoJsonFieldDTO,
        });
        return new GameMetadataContext(Logger, searchService, RuntimeContext);
    }


    


    //public   override void PlatformSetImeDataFn(bool on)
    //{
         
    //}

    //public override void BlockInput(IImGuiUIView view)
    //{
    //    //base.BlockInput(view);
    //}

    //public override bool TryGetImageInfo(string? category, string objectId, string? image, out nint nativePtr, out float u0, out float v0, out float u1, out float v1)
    //{
    //    Unsafe.SkipInit(out nativePtr);
    //    Unsafe.SkipInit(out u0);
    //    Unsafe.SkipInit(out v0);
    //    Unsafe.SkipInit(out u1);
    //    Unsafe.SkipInit(out v1);
    //    return false;


    //}

    ////  Dictionary<nint, ImageInfo> ImageCache { get; } = [];

    //public unsafe override bool TryDrawLauncher(out nint nativePtr, out float u0, out float v0, out float u1, out float v1)
    //{
    //    Unsafe.SkipInit(out nativePtr);
    //    Unsafe.SkipInit(out u0);
    //    Unsafe.SkipInit(out v0);
    //    Unsafe.SkipInit(out u1);
    //    Unsafe.SkipInit(out v1);

 



    //    return false;

    //}

    public required GameResourceCache Cache { get; set; }
    protected override async ValueTask LoadGameResourcesAsync()
    {
        this.Cache = await this.MTaskAsync(p => GameResourceCache.Create(p)).ConfigureAwait(false);
    }
    private async ValueTask LoadGameResources2Async()
    {

        //  this.Cache = await this.MTaskAsync(p => GameResourceCache.Create(p)).ConfigureAwait(false);

        //   this.GameCommonResources.AddRange(this.Cache.CurrencyResources);
        await this.XTaskAsync(p => p.LoadCurrencyResourceImages()).ConfigureAwait(false);
        //    await this.MTaskAsync((this),(p,context) => context.LoadCurrencyResourceImages()).ConfigureAwait(false);

        //  this.GameCommonResources.AddRange(this.Cache.InventoryResources);
        await this.XTaskAsync(p => p.LoadInventoryResourceImages()).ConfigureAwait(false);
        //   await this.MTaskAsync((this), (p, context) => context.LoadInventoryResourceImages()).ConfigureAwait(false);

        //   this.GameCommonResources.AddRange(this.Cache.NPCResources);
        await this.XTaskAsync(p => p.LoadNPCResourceImages()).ConfigureAwait(false);
        //  await this.MTaskAsync((this), (p, context) => context.LoadNPCResourceImages()).ConfigureAwait(false);

        //   this.GameCommonResources.AddRange(this.Cache.SkillResources.Where(p => p.DisplayCategory == nameof(Effect)));
        //      await this.XTaskAsync(p => p.LoadSkillResourceImages()).ConfigureAwait(false);

    }

    private GameImageResource? LoadImage(IGameCommonReource commonReource)
    {
      //  return default;
        if(UnityMetadataSearchService is null) { return default; }
        var imageCode = commonReource.DisplayImage;
        if (string.IsNullOrEmpty(imageCode)) { return default; }
        var imagePtr = commonReource.ImagePointer;
        if (this.ImageResources.ContainsKey(imageCode) == false
            && this.UnityMetadataSearchService.TryGetTextureInfo(imagePtr, out var imageRes))
        {
            
            this.ImageResources.TryAdd(imageCode, imageRes);
            return imageRes;
        }
        return default;
    }

    private void LoadCurrencyResourceImages()
    {
        foreach (var item in this.Cache.CurrencyResources)
        {
            var itemPtr = new ItemData.Ptr_ItemData(item.ObjectPointer);
            var id = itemPtr.M_ID;
            item.ImagePointer = UIUtlils.Ptr_UIUtlils.LOAD_ITEM(id);
            var imageRes = this.LoadImage(item);
            if (id == (int)ItemId.感悟点 && imageRes is not null)
            {
                this.ImageResources.TryAdd(nameof(GameImageResource), imageRes);
            }

        }
    }



    private void LoadInventoryResourceImages()
    {
        foreach (var item in this.Cache.InventoryResources)
        {
            var itemPtr = new ItemData.Ptr_ItemData(item.ObjectPointer);
            item.ImagePointer = UIUtlils.Ptr_UIUtlils.LOAD_ITEM(itemPtr.M_ID);
            this.LoadImage(item);
        }
    }
    private void LoadNPCResourceImages()
    {
        var mainPtr = UIUtlils.Ptr_UIUtlils.LOAD_LEADER_HEAD();
        this.LoadImage(new GameMonsterResource()
        {
            ObjectId = nameof(LearderInfo),
            //  DisplayCategory = nameof(LearderInfo),
            DisplayImage = nameof(LearderInfo),
            //  DisplayName = "1",
            ImagePointer = mainPtr,
        });
        //this.LoadImage(new GameMonsterResource()
        //{
        //    ObjectId = "1",
        //    DisplayCategory = nameof(LearderInfo),
        //    DisplayImage = nameof(GameImageResource),
        //    DisplayName = "1",
        //    ImagePointer = mainPtr,
        //});
        foreach (var item in this.Cache.NPCResources)
        {
            var characterData = new CharacterData.Ptr_CharacterData(item.CharacterPointer);
            item.ImagePointer = UIUtlils.Ptr_UIUtlils.LOAD_HEAD(characterData.M_BOOK);
            this.LoadImage(item);
        }
    }
    private void LoadSkillResourceImages()
    {
        foreach (var item in this.Cache.SkillResources.Where(p => p.DisplayCategory == nameof(Effect)))
        {
            var itemPtr = new EffectData.Ptr_EffectData(item.ObjectPointer);
            item.ImagePointer = UIUtlils.Ptr_UIUtlils.LOAD_EFFECT(itemPtr.M_ID);
            this.LoadImage(item);

        }
    }

    //protected override UnityMetadataContext? LoadUnityEngineContext()
    //{

    //    var cache = Maple.MonoGameAssistant.MetadataUnity.UnityMetadataContext_MONO.MethodOffsetCache;

    //    this.InternalCallService.TryGetInternalCall("UnityEngine.Graphics::Blit2", out var blit2Address);
    //    cache[Maple.MonoGameAssistant.MetadataUnity.Graphics.Code_FunctionPointerType_BLIT2_E9370053514A1DE4] = blit2Address ;

    //    this.InternalCallService.TryGetInternalCall("UnityEngine.ImageConversion::EncodeToPNG", out var encodeToPngAddress);
    //    cache[Maple.MonoGameAssistant.MetadataUnity.ImageConversion.Code_FunctionPointerType_ENCODE_TO_PNG_B997C8D2C1188DD2] = encodeToPngAddress ;



    //    this.InternalCallService.TryGetInternalCall("UnityEngine.Sprite::GetTextureRect_Injected", out var getTextureRect_Injected);
    //    cache[Maple.MonoGameAssistant.MetadataUnity.Sprite.Code_FunctionPointerType_GET_TEXTURE_RECT_INJECTED_991A7878D43EDC7F] = getTextureRect_Injected ;



    //    this.InternalCallService.TryGetInternalCall("UnityEngine.Texture2D::ReadPixelsImpl_Injected", out var readPixelsImpl_Injected);
    //    cache[Maple.MonoGameAssistant.MetadataUnity.Texture2D.Code_FunctionPointerType_READ_PIXELS_IMPL_INJECTED_3D6557C7BC276B18] = readPixelsImpl_Injected ;

    //    this.InternalCallService.TryGetInternalCall("UnityEngine.RenderTexture::GetTemporary_Internal_Injected", out var getTemporary_Internal_Injected);
    //    cache[Maple.MonoGameAssistant.MetadataUnity.RenderTexture.Code_FunctionPointerType_GET_TEMPORARY_A9166399B8D45F02] = getTemporary_Internal_Injected ;


    //    cache[Maple.MonoGameAssistant.MetadataUnity.Texture2D.Code_FunctionPointerType_CTOR_C8C2534E5BC1B363] = UnityMetadataContext_MONO.UnityPlayerBaseAddress;

    //    this.InternalCallService.TryGetInternalCall("UnityEngine.Texture::GetNativeTexturePtr", out var getNativeTexturePtr);
    //    cache[Maple.MonoGameAssistant.MetadataUnity.Texture2D.Code_FunctionPointerType_GET_NATIVE_TEXTURE_PTR_81841FE86C2B23E0] = getNativeTexturePtr ;

    //    this.InternalCallService.TryGetInternalCall("UnityEngine.Input::GetKeyDownString", out var GetKeyDownString);
    //    cache[Maple.MonoGameAssistant.MetadataUnity.Input.Code_FunctionPointerType_GET_KEY_DOWN_STRING_868655107A827883] = GetKeyDownString ;
    //    this.InternalCallService.TryGetInternalCall("UnityEngine.Input::GetKeyDownInt", out var GetKeyDownInt);
    //    cache[Maple.MonoGameAssistant.MetadataUnity.Input.Code_FunctionPointerType_GET_KEY_DOWN_INT_49C8675AD85C932A] = GetKeyDownInt ;

    //    this.InternalCallService.TryGetInternalCall("UnityEngine.Input::GetKeyInt", out var GetKeyInt);
    //    cache[Maple.MonoGameAssistant.MetadataUnity.Input.Code_FunctionPointerType_GET_KEY_INT_364226C2278E06B9] = GetKeyInt ;
    //    this.InternalCallService.TryGetInternalCall("UnityEngine.Input::GetKeyString", out var GetKeyString);
    //    cache[Maple.MonoGameAssistant.MetadataUnity.Input.Code_FunctionPointerType_GET_KEY_STRING_F5AA5E669534DDF0] = GetKeyString ;

    //    this.InternalCallService.TryGetInternalCall("UnityEngine.Input::GetKeyUpInt", out var GetKeyUpInt);
    //    cache[Maple.MonoGameAssistant.MetadataUnity.Input.Code_FunctionPointerType_GET_KEY_UP_INT_2E27C050DF037639] = GetKeyUpInt ;
    //    this.InternalCallService.TryGetInternalCall("UnityEngine.Input::GetKeyUpString", out var GetKeyUpString);
    //    cache[Maple.MonoGameAssistant.MetadataUnity.Input.Code_FunctionPointerType_GET_KEY_UP_STRING_45B9708814684170] = GetKeyUpString ;


    //    UnityMetadataContext.MethodAddressCallback = DefaultMethodAddressCallback;
    //    return UnityMetadataContext.CreateUnityMetadataContext(this.RuntimeContext, this.Logger);

    //}

    //private bool DefaultMethodAddressCallback(MonoRuntimeContext runtimeContext, ulong code, out nint address)
    //{
    //    Unsafe.SkipInit<nint>(out address);

    //    if (UnityMetadataContext_MONO.MethodOffsetCache.TryGetValue(code, out var value))
    //    {
    //        address = value;// UnityMetadataContext_MONO.UnityPlayerBaseAddress + value;
    //        return true;
    //    }
    //    else
    //    {

    //        this.Logger.LogInformation("NOT FOUND UNITY METHOD:{CODE:X8}", code);
    //    }

    //    return false;
    //}

    public override async ValueTask<GameSessionInfoDTO> GetSessionInfoAsync()
    {
        _ = await GetCheatServiceThrowIfNotInGameAsync().ConfigureAwait(false);
        await LoadGameResources2Async().ConfigureAwait(false);

        var sessionInfoDTO = await base.GetSessionInfoAsync().ConfigureAwait(false);

        return sessionInfoDTO;
    }


    private Task<GameEnvService> GetCheatServiceThrowIfNotInGameAsync()
    {
        return this.MonoTaskAsync((p) => GameEnvService.CreateGameEnvService(this.Cache));
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
        var info = await this.XTaskAsync((gameCheatService, monsterObjectDTO), (p, args) => args.gameCheatService.AddMonsterMember(args.monsterObjectDTO)).ConfigureAwait(false);
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

//public sealed class UnityMetadataSearcher_TEST(MonoRuntimeContext context, MonoInternalCallService internalCallService)
//    : UnityMetadataSearcher
//{
//    private MonoRuntimeContext Context { get; } = context;
//    private MonoInternalCallService InternalCallService { get; } = internalCallService;

//    public bool NewTryGetTextureInfo(nint ptr_Sprite, out nint native_ptr, out float u0, out float v0, out float u1, out float v1)
//    {
//        Unsafe.SkipInit<nint>(out native_ptr);
//        Unsafe.SkipInit<float>(out u0);
//        Unsafe.SkipInit<float>(out v0);
//        Unsafe.SkipInit<float>(out u1);
//        Unsafe.SkipInit<float>(out v1);
//        if (ptr_Sprite == IntPtr.Zero)
//        {
//            return false;
//        }

//        Sprite.Ptr_Sprite ptr_Sprite2 = new Sprite.Ptr_Sprite(ptr_Sprite);
//        Texture2D.Ptr_Texture2D ptr_Texture2D = PTR_FUNC_GET_TEXTURE.Delegate((nint)ptr_Sprite2);
//        //  this.Context.CreateMonoGCHandle(ptr_Texture2D);
//        if (ptr_Texture2D.IsNull())
//        {
//            return false;
//        }

//        native_ptr = PTR_FUNC_GET_NATIVE_TEXTURE_PTR.Delegate((nint)ptr_Texture2D);
//        if (native_ptr == IntPtr.Zero)
//        {
//            return false;
//        }

//        PTR_FUNC_GET_TEXTURE_RECT_INJECTED.Delegate((nint)ptr_Sprite2, MapleOut<Rect.Ref_Rect>.FromOut(out var data));
//        int num = PTR_FUNC_GET_WIDTH.Delegate((nint)ptr_Texture2D);
//        int num2 = PTR_FUNC_GET_HEIGHT.Delegate((nint)ptr_Texture2D);
//        u0 = data.m_XMin / (float)num;
//        v0 = data.m_YMin / (float)num2;
//        u1 = (data.m_XMin + data.m_Width) / (float)num;
//        v1 = (data.m_YMin + data.m_Height) / (float)num2;
//        return true;
//    }




//    public override nint GetMethodPointer(string code)
//    {
//        if (MethodSignatureCache.TryGetValue(code, out var methodSignature)
//            && this.InternalCallService.TryGetInternalCall(methodSignature, out var pointer))
//        {
//            return pointer;
//        }
//        return default;
//    }
//}



//public class UnityMetadataSearcher_Test(MonoInternalCallService internalCallService) : UnityMetadataSearcher
//{
//    public MonoInternalCallService InternalCallService { get; } = internalCallService;


//    public new PTR_FUNC_GET_TEXTURE_9E369564B1447B9B PTR_FUNC_GET_TEXTURE => base.PTR_FUNC_GET_TEXTURE;
//    public new PTR_FUNC_GET_TEXTURE_RECT_INJECTED_991A7878D43EDC7F PTR_FUNC_GET_TEXTURE_RECT_INJECTED => base.PTR_FUNC_GET_TEXTURE_RECT_INJECTED;

//    public new PTR_FUNC_GET_NATIVE_TEXTURE_PTR_81841FE86C2B23E0 PTR_FUNC_GET_NATIVE_TEXTURE_PTR => base.PTR_FUNC_GET_NATIVE_TEXTURE_PTR;
//    public new PTR_FUNC_GET_HEIGHT_CCDEA63084F82309 PTR_FUNC_GET_HEIGHT => base.PTR_FUNC_GET_HEIGHT;
//    public new PTR_FUNC_GET_WIDTH_BF4A4D382B19EF20 PTR_FUNC_GET_WIDTH => base.PTR_FUNC_GET_WIDTH;

//    public new PTR_FUNC_SET_IME_COMPOSITION_MODE_6F1C9D826DB1C736 PTR_FUNC_SET_IME_COMPOSITION_MODE => base.PTR_FUNC_SET_IME_COMPOSITION_MODE;

//    public override nint GetMethodPointer(string code)
//    {
//        if (MethodSignatureCache.TryGetValue(code, out var methodSignature)
//                && this.InternalCallService.TryGetInternalCall(methodSignature, out var pointer))
//        {
//            return pointer;
//        }
//        return default;
//    }
//}


public record class ImageInfo(nint nativePtr, float u0, float v0, float u1, float v1);