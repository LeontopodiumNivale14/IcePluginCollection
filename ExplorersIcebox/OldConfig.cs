using System.Text.Json.Serialization;
using ECommons.Configuration;

namespace ExplorersIcebox;

public class OldConfig : IEzConfig
{
    [JsonIgnore]
    public const int CurrentConfigVersion = 1;

    public int routeSelected = 1;
    public bool runInfinite = true;
    public int runAmount = 0;
    public bool everythingUnlocked = true;
    public bool XPGrind = true;
    public bool UseTickets = false;
    public bool SkipSell = false;
    //

    public void Save()
    {
        EzConfig.Save();
    }
}
