using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Logic.Settings.Abstract.Generic;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Settings;

public class CraftOverlayMaxExpandedItemsSetting : GenericIntegerSetting
{
    public CraftOverlayMaxExpandedItemsSetting(ILogger<CraftOverlayMaxExpandedItemsSetting> logger,
        ImGuiService imGuiService) : base("CraftOverlayMaxItems",
        "展开时的物品数量上限",
        "制作悬浮窗展开时显示的物品数量",
        5,
        "1.11.0.8",
        logger,
        imGuiService)
    {
    }
}