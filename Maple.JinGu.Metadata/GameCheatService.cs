using Microsoft.Extensions.Logging;

namespace Maple.JinGu.Metadata
{
    public partial class GameCheatService(GameResourceCache cache)
    {
        public GameResourceCache Cache { get; } = cache;
        public GameMetadataContext Context => Cache.Context;
        private ILogger Logger => Context.Logger;

    }
}
