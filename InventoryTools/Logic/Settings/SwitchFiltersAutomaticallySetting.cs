using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Settings
{
    public class SwitchFiltersAutomaticallySetting : BooleanSetting
    {
        public override bool DefaultValue { get; set; } = true;
        public override bool CurrentValue(InventoryToolsConfiguration configuration)
        {
            return configuration.SwitchFiltersAutomatically;
        }

        public override void UpdateFilterConfiguration(InventoryToolsConfiguration configuration, bool newValue)
        {
            configuration.SwitchFiltersAutomatically = newValue;
        }

        public override string Key { get; set; } = "SwitchFiltersAutomatically";
        public override string Name { get; set; } = "自动切换列表";

        public override string HelpText { get; set; } =
            "查看其他列表时是否自动切换高亮，仅在已有活动高亮时生效。";
        
        public override string Version => "1.7.0.0";

        public SwitchFiltersAutomaticallySetting(ILogger<SwitchFiltersAutomaticallySetting> logger, ImGuiService imGuiService) : base(logger, imGuiService)
        {
        }
    }
}