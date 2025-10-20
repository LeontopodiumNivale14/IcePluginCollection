using System.Collections.Generic;
using System.IO;

namespace MiniPluginCollection.Config;

public class GeneralConfig : IYamlConfig
{

    // Debug Stuff
    public uint PictoCircleColor { get; set; } = 0;
    public uint PictoLineColor { get; set; } = 0;
    public uint PictoWPColor { get; set; } = 0;
    public uint PictoTextCol { get; set; } = 0;
    public float DotRadius { get; set; } = 0f;
    public float LineWidth { get; set; } = 0f;
    public Vector2 DonutRadius { get; set; } = new Vector2(0.7f, 1.4f);
    public Vector2 FanPosition { get; set; } = new Vector2(0.0f, 6.283f);
    public float TextFloatPlus { get; set; } = 0.0f;

    // General Save

    public static string ConfigPath => Path.Combine(Svc.PluginInterface.ConfigDirectory.FullName, "MiniPluginCollection.yaml");
    public void Save() => YamlConfig.Save(this, ConfigPath);
}
