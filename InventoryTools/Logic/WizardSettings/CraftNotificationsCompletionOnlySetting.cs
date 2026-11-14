using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Logic.Settings.Abstract.Generic;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.WizardSettings;

public class CraftNotificationsCompletionOnlySetting : GenericBooleanSetting
{
    public override bool AppearsInConfigWindow => false;

    private bool _shouldAdd;

    public CraftNotificationsCompletionOnlySetting(ILogger<CraftNotificationsCompletionOnlySetting> logger,
        ImGuiService imGuiService) : base("CraftNotificationsCompletionOnly",
        "仅在物品完成时报告",
        "物品达到所需数量时才输出消息。需要激活制作清单才能触发通知。",
        false,
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