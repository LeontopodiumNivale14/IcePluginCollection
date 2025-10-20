using ECommons.Reflection;

namespace MiniPluginCollection.Util;

public class Util_Plugin
{
    public static bool HasPlugin(string name) => DalamudReflector.TryGetDalamudPlugin(name, out _, false, true);
}
