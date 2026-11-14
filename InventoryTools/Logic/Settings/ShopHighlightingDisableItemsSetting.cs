using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Logic.Settings.Abstract.Generic;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Settings;

public class ShopHighlightingDisableItemsSetting : GenericBooleanSetting
{
    public ShopHighlightingDisableItemsSetting(ILogger<ShopHighlightingDisableItemsSetting> logger, ImGuiService imGuiService) : base("ShopHighlightingDisableItems", "商店高亮－调暗物品", "高亮商店物品时，是否调暗未匹配的物品", false, "15.0.4", logger, imGuiService)
    {
    }
}