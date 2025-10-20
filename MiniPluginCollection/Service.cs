using Dalamud.Plugin.Services;
using MiniPluginCollection.Config;

namespace MiniPluginCollection
{
    internal class Service
    {
        internal static IDalamudPluginInterface PluginInterface { get; set; } = null!;
        public static IObjectTable ObjectTable { get; private set; } = null!;
    }
}
