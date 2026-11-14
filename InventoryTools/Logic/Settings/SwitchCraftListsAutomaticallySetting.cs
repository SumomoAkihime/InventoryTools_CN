using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Settings
{
    public class SwitchCraftListsAutomaticallySetting : BooleanSetting
    {
        public override bool DefaultValue { get; set; } = true;
        public override bool CurrentValue(InventoryToolsConfiguration configuration)
        {
            return configuration.SwitchCraftListsAutomatically;
        }

        public override void UpdateFilterConfiguration(InventoryToolsConfiguration configuration, bool newValue)
        {
            configuration.SwitchCraftListsAutomatically = newValue;
        }

        public override string Key { get; set; } = "SwitchCraftListsAutomatically";
        public override string Name { get; set; } = "自动切换制作清单";

        public override string HelpText { get; set; } =
            "切换制作清单窗口时是否自动切换当前活动清单，仅在已有活动清单时生效";

        public override string Version => "1.7.0.0";

        public SwitchCraftListsAutomaticallySetting(ILogger<SwitchCraftListsAutomaticallySetting> logger, ImGuiService imGuiService) : base(logger, imGuiService)
        {
        }
    }
}