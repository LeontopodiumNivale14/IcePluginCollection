using FFXIVClientStructs.FFXIV.Client.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPluginCollection.Util;

public class Helper_Player
{
    public static unsafe uint MainInventoryFreeSpace()
    {
        return InventoryManager.Instance()->GetEmptySlotsInBag();
    }

    public static unsafe int GetCollectableItemCount(uint itemId, int minCollectability = 400)
    {
        return InventoryManager.Instance()->GetInventoryItemCount(itemId, false, false, false, (short)minCollectability);
    }
}
