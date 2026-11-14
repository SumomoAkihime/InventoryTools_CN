using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Settings
{
    public class SaveBackgroundFilterSetting : BooleanSetting
    {
        public override bool DefaultValue { get; set; } = false;
        public override bool CurrentValue(InventoryToolsConfiguration configuration)
        {
            return configuration.SaveBackgroundFilter;
        }

        public override void UpdateFilterConfiguration(InventoryToolsConfiguration configuration, bool newValue)
        {
            configuration.SaveBackgroundFilter = newValue;
        }

        public override string Key { get; set; } = "SaveBackgroundFilter";
        public override string Name { get; set; } = "保留后台列表高亮";

        public override string HelpText { get; set; } =
            "退出游戏或停用插件时是否保存当前后台列表";
        
        public override string Version => "1.7.0.0";

        public SaveBackgroundFilterSetting(ILogger<SaveBackgroundFilterSetting> logger, ImGuiService imGuiService) : base(logger, imGuiService)
        {
        }
    }
}