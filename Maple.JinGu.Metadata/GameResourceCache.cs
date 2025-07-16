using Microsoft.Extensions.Logging;

namespace Maple.JinGu.Metadata
{
    public partial class GameResourceCache(GameMetadataContext context)
    {
        public GameMetadataContext Context { get; } = context;
        public ILogger Logger => Context.Logger;

    }
}
