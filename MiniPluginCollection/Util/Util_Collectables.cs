using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPluginCollection.Util;

public class Util_Collectables
{
    public enum CollectableKind
    {
        Purple,
        Orange,
    }

    public class CollectableType
    {
        public CollectableKind Kind { get; set; }
        public uint ItemId { get; set; }
        public uint Level { get; set; }
    }

    /// <summary>
    /// Key = Class Type
    /// Value = A list of all inputted collectables
    /// </summary>
    public static Dictionary<uint, List<CollectableType>> Collectable_Dict = new()
    {
        [8] = new List<CollectableType>()
        {
            new()
            {
                Kind = CollectableKind.Orange,
                ItemId = 44190,
                Level = 100,
            },
            new()
            {
                Kind = CollectableKind.Purple,
                ItemId = 44189,
                Level = 99,
            },
            new()
            {
                Kind = CollectableKind.Purple,
                ItemId = 44188,
                Level = 97
            }
        },
        [9] = new List<CollectableType>()
        {
            new()
            {
                Kind = CollectableKind.Orange,
                ItemId = 44190,
                Level = 100,
            },
            new()
            {
                Kind = CollectableKind.Purple,
                ItemId = 44189,
                Level = 99,
            },
            new()
            {
                Kind = CollectableKind.Purple,
                ItemId = 44188,
                Level = 97
            }
        },
        [10] = new List<CollectableType>()
        {
            new()
            {
                Kind = CollectableKind.Orange,
                ItemId = 44196,
                Level = 100,
            },
            new()
            {
                Kind = CollectableKind.Purple,
                ItemId = 44195,
                Level = 99,
            },
            new()
            {
                Kind = CollectableKind.Purple,
                ItemId = 44194,
                Level = 97
            }
        },
        [11] = new List<CollectableType>()
        {
            new()
            {
                Kind = CollectableKind.Orange,
                ItemId = 44202,
                Level = 100,
            },
            new()
            {
                Kind = CollectableKind.Purple,
                ItemId = 44201,
                Level = 99,
            },
            new()
            {
                Kind = CollectableKind.Purple,
                ItemId = 44200,
                Level = 97
            }
        },
        [12] = new List<CollectableType>()
        {
            new()
            {
                Kind = CollectableKind.Orange,
                ItemId = 44208,
                Level = 100,
            },
            new()
            {
                Kind = CollectableKind.Purple,
                ItemId = 44207,
                Level = 99,
            },
            new()
            {
                Kind = CollectableKind.Purple,
                ItemId = 44206,
                Level = 97
            }
        },
        [13] = new List<CollectableType>()
        {
            new()
            {
                Kind = CollectableKind.Orange,
                ItemId = 44214,
                Level = 100,
            },
            new()
            {
                Kind = CollectableKind.Purple,
                ItemId = 44213,
                Level = 99,
            },
            new()
            {
                Kind = CollectableKind.Purple,
                ItemId = 44212,
                Level = 97
            }
        },
        [14] = new List<CollectableType>()
        {
            new()
            {
                Kind = CollectableKind.Orange,
                ItemId = 44220,
                Level = 100,
            },
            new()
            {
                Kind = CollectableKind.Purple,
                ItemId = 44219,
                Level = 99,
            },
            new()
            {
                Kind = CollectableKind.Purple,
                ItemId = 44218,
                Level = 97
            }
        },
        [15] = new List<CollectableType>()
        {
            new()
            {
                Kind = CollectableKind.Orange,
                ItemId = 44226,
                Level = 100,
            },
            new()
            {
                Kind = CollectableKind.Purple,
                ItemId = 44225,
                Level = 99,
            },
            new()
            {
                Kind = CollectableKind.Purple,
                ItemId = 44224,
                Level = 97
            }
        },
        [16] = new List<CollectableType>()
        {
            new()
            {
                Kind = CollectableKind.Orange,
                ItemId = 44232,
                Level = 100,
            },
            new()
            {
                Kind = CollectableKind.Purple,
                ItemId = 44231,
                Level = 99,
            },
            new()
            {
                Kind = CollectableKind.Purple,
                ItemId = 44230,
                Level = 97
            }
        },
    };
}
