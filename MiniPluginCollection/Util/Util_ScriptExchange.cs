using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPluginCollection.Util;

public class Util_ScriptExchange
{
    public class ShopItem
    {
        public string Name { get; set; } = string.Empty;
        public int Cost { get; set; }
        public int PageType { get; set; }
        public int ItemType { get; set; }
        public bool RequiresQuest { get; set; } = false;
        public bool AffectedByQuest { get; set; } = false;

        public static ShopItem Create(string name, int cost, PageInfo page)
        {
            return new ShopItem
            {
                Name = name,
                Cost = cost,
                PageType = page.PageType,
                ItemType = page.ItemType,
                AffectedByQuest = page.AffectedByQuest,
                RequiresQuest = page.RequiresQuest
            };
        }
    }

    public class PageInfo
    {
        public int PageType { get; set; }
        public int ItemType { get; set; }
        public bool RequiresQuest { get; set; } = false;
        public bool AffectedByQuest { get; set; } = false;

        public PageInfo(int pageType, int itemType, bool affectedByQuest = false, bool requiresQuest = false)
        {
            PageType = pageType;
            ItemType = itemType;
            AffectedByQuest = affectedByQuest;
            RequiresQuest = requiresQuest;
        }
    }

    public static class ShopPages
    {
        // Common pages to reference for items
        public static readonly PageInfo SkysteelLv80 = new(1, 8, requiresQuest: true);
        public static readonly PageInfo PurpleScriptLv90 = new(1, 9, affectedByQuest: true);
        public static readonly PageInfo PurpleScriptLv100 = new(1, 10, affectedByQuest: true);
        public static readonly PageInfo OrangeScriptLv100 = new(1, 11, affectedByQuest: true);

        public static readonly PageInfo CrafterPurpleMateria = new(2, 1);
        public static readonly PageInfo CrafterOrangeMateria = new(2, 2);
    }

    public static readonly Dictionary<uint, ShopItem> ScriptItems = new()
    {
        // 13, 10 - Purple Script Exchange Lv. 100 Materials
        [46252] = ShopItem.Create("Mason's Abrasive", 500, ShopPages.PurpleScriptLv100),

        // 13, 11 - Orange Script Exchange Lv. 100 Materials/Furnishing
        [45993] = ShopItem.Create("Queso Fresco", 15, ShopPages.OrangeScriptLv100),
        [45994] = ShopItem.Create("Woolback Loin", 15, ShopPages.OrangeScriptLv100),
        [45990] = ShopItem.Create("Cassava", 15, ShopPages.OrangeScriptLv100),
        [45991] = ShopItem.Create("Splended Mate Leaves", 15, ShopPages.OrangeScriptLv100),
        [45992] = ShopItem.Create("Aji Amarillo", 15, ShopPages.OrangeScriptLv100),
        [44848] = ShopItem.Create("Condensed Solution", 125, ShopPages.OrangeScriptLv100),
        [44170] = ShopItem.Create("Rumpless Chicken", 10, ShopPages.OrangeScriptLv100),
        [44173] = ShopItem.Create("Navel Orange", 10, ShopPages.OrangeScriptLv100),
        [44172] = ShopItem.Create("Wild Coffee Beans", 10, ShopPages.OrangeScriptLv100),
        [44171] = ShopItem.Create("Brown Cardamom", 10, ShopPages.OrangeScriptLv100),
        [44174] = ShopItem.Create("Royal Lobster", 10, ShopPages.OrangeScriptLv100),
        [41146] = ShopItem.Create("Hingan Rock Garden", 1000, ShopPages.OrangeScriptLv100),
        [44876] = ShopItem.Create("Sweet Dreamer's Stall", 500, ShopPages.OrangeScriptLv100),

        // 
    };

    // Gets the items via the page that I'm calling upon
    public static List<ShopItem> GetItemsOnPage(PageInfo page)
    {
        return ScriptItems.Values
            .Where(item => item.PageType == page.PageType && item.ItemType == page.ItemType)
            .ToList();
    }

    // Get items with their IDs
    public static Dictionary<uint, ShopItem> GetItemsOnPageWithIds(int pageType, int itemType)
    {
        return ScriptItems
            .Where(kvp => kvp.Value.PageType == pageType && kvp.Value.ItemType == itemType)
            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
    }
}
