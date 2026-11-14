using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Settings
{
    public class ColourRetainerListSetting : BooleanSetting
    {
        public override bool DefaultValue { get; set; } = true;
        public override bool CurrentValue(InventoryToolsConfiguration configuration)
        {
            return configuration.ColorRetainerList;
        }

        public override void UpdateFilterConfiguration(InventoryToolsConfiguration configuration, bool newValue)
        {
            configuration.ColorRetainerList = newValue;
        }

        public override string Key { get; set; } = "ColourRetainerList";
        public override string Name { get; set; } = "为雇员列表名称着色";
        public override string HelpText { get; set; } = "雇员库存存在相关物品或待整理物品时，是否为传唤铃列表中的雇员名称着色";
        public override string Version => "1.7.0.0";

        public ColourRetainerListSetting(ILogger<ColourRetainerListSetting> logger, ImGuiService imGuiService) : base(logger, imGuiService)
        {
        }
    }
}