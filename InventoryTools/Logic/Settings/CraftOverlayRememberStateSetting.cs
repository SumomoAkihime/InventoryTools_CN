using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Logic.Settings.Abstract.Generic;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Settings;

public class CraftOverlayRememberStateSetting : GenericBooleanSetting
{
    public CraftOverlayRememberStateSetting(ILogger<CraftOverlayRememberStateSetting> logger,
        ImGuiService imGuiService) : base("CraftOverlayRememberState",
        "记住状态",
        "是否在插件或游戏重新加载后保持制作悬浮窗打开",
        true,
        "1.11.0.8",
        logger,
        imGuiService)
    {
    }
}