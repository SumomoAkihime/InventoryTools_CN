using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Logic.Settings.Abstract.Generic;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.WizardSettings;

public class CraftNotificationsReportToChatSetting : GenericBooleanSetting
{
    public override bool AppearsInConfigWindow => false;

    private bool _shouldAdd;

    public CraftNotificationsReportToChatSetting(ILogger<CraftNotificationsReportToChatSetting> logger,
        ImGuiService imGuiService) : base("CraftNotificationsReportToChat",
        "在聊天中报告获取进度",
        "获得制作清单所需物品时向聊天输出进度。需要激活制作清单才能触发通知。",
        true,
        "15.0.8",
        logger,
        imGuiService)
    {
    }

    public override bool CurrentValue(InventoryToolsConfiguration configuration)
    {
        return _shouldAdd;
    }

    public override void UpdateFilterConfiguration(InventoryToolsConfiguration configuration, bool newValue)
    {
        _shouldAdd = newValue;
    }
}