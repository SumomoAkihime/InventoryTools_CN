using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Services;
using Lumina.Excel;
using Lumina.Excel.Sheets;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Settings
{
    public class TooltipColorSetting : GameColorSetting
    {
        public TooltipColorSetting(ILogger<TooltipColorSetting> logger, ImGuiService imGuiService, ExcelSheet<UIColor> uiColorSheet) : base(logger, imGuiService, uiColorSheet)
        {
        }
        public override uint? DefaultValue { get; set; } = null;
        public override uint? CurrentValue(InventoryToolsConfiguration configuration)
        {
            return configuration.TooltipColor;
        }

        public override void UpdateFilterConfiguration(InventoryToolsConfiguration configuration, uint? newValue)
        {
            configuration.TooltipColor = newValue;
        }

        public override string Key { get; set; } = "TooltipColor";
        public override string Name { get; set; } = "文字颜色";
        public override string HelpText { get; set; } = "插件附加到物品提示的默认文字颜色，各模块可在自身设置中覆盖。";
        public override string Version => "1.7.0.0";
    }
}