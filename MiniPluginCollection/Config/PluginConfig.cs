using MiniPluginCollection.Config.ConfigTypes;
using System.IO;

namespace MiniPluginCollection.Config;

public class PluginConfig : IYamlConfig
{
    public DebugConfig Debug { get; set; } = new();

    public static string ConfigPath => Path.Combine(Svc.PluginInterface.ConfigDirectory.FullName, "MiniPluginCollection.yaml");
    public void Save() => YamlConfig.Save(this, ConfigPath);
}
