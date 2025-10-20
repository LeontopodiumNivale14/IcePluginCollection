using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPluginCollection.Config.ConfigTypes;
public class DebugConfig
{
    public uint PictoCircleColor { get; set; } = 0;
    public uint PictoLineColor { get; set; } = 0;
    public uint PictoWPColor { get; set; } = 0;
    public uint PictoTextCol { get; set; } = 0;
    public float DotRadius { get; set; } = 0f;
    public float LineWidth { get; set; } = 0f;
    public Vector2 DonutRadius { get; set; } = new Vector2(0.7f, 1.4f);
    public Vector2 FanPosition { get; set; } = new Vector2(0.0f, 6.283f);
    public float TextFloatPlus { get; set; } = 0.0f;
}
