using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Settings;

public class TooltipDisplayGlamourReadySetSetting : BooleanSetting
{
    public override bool DefaultValue { get; set; } = false;

    public override bool CurrentValue(InventoryToolsConfiguration configuration)
    {
        return configuration.TooltipDisplayGlamourReadySet;
    }

    public override void UpdateFilterConfiguration(InventoryToolsConfiguration configuration, bool newValue)
    {
        configuration.TooltipDisplayGlamourReadySet = newValue;
    }

    public override string Key { get; set; } = "TooltipDisplayGlamourReadySet";
    public override string Name { get; set; } = "组合投影信息";

    public override string WizardName { get; } = "组合投影信息";

    public override string HelpText { get; set; } =
        "悬停物品时，显示其组合投影套装信息，以及兵装库或收藏柜中已拥有的部件。";
    
    public override string Version => "1.12.0.0";

    public TooltipDisplayGlamourReadySetSetting(ILogger<TooltipDisplayGlamourReadySetSetting> logger, ImGuiService imGuiService) : base(logger, imGuiService)
    {
    }
}
