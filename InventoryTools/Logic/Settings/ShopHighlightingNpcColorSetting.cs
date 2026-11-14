using System.Collections.Generic;
using FFXIVClientStructs.FFXIV.Client.Game.Object;
using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Logic.Settings.Abstract.Generic;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Settings;

public class ShopHighlightingNpcColorSetting : GenericEnumChoiceSetting<ObjectHighlightColor>
{
    public ShopHighlightingNpcColorSetting(ILogger<ShopHighlightingNpcColorSetting> logger, ImGuiService imGuiService) : base("ShopHighlightingNpcColor", "商店高亮－NPC 高亮颜色", "商店物品高亮时，场景中 NPC 的高亮颜色。", ObjectHighlightColor.Green, new Dictionary<ObjectHighlightColor, string>
    {
        { ObjectHighlightColor.Red,     "红色"     },
        { ObjectHighlightColor.Green,   "绿色"   },
        { ObjectHighlightColor.Blue,    "蓝色"    },
        { ObjectHighlightColor.Yellow,  "黄色"  },
        { ObjectHighlightColor.Orange,  "橙色"  },
        { ObjectHighlightColor.Magenta, "品红色" },
    }, "15.0.4", logger, imGuiService)
    {
    }
}
