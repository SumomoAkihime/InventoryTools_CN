using CriticalCommonLib.MarketBoard;
using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Settings
{
    public class MarketRefreshTimeHoursSetting : IntegerSetting
    {
        private readonly MarketCacheConfiguration _marketCacheConfiguration;

        public MarketRefreshTimeHoursSetting(ILogger<MarketRefreshTimeHoursSetting> logger, ImGuiService imGuiService, MarketCacheConfiguration marketCacheConfiguration) : base(logger, imGuiService)
        {
            _marketCacheConfiguration = marketCacheConfiguration;
        }

        public override int DefaultValue { get; set; } = 24;
        public override int CurrentValue(InventoryToolsConfiguration configuration)
        {
            return configuration.MarketRefreshTimeHours;
        }

        public override void UpdateFilterConfiguration(InventoryToolsConfiguration configuration, int newValue)
        {
            configuration.MarketRefreshTimeHours = newValue;
            _marketCacheConfiguration.CacheMaxAgeHours = newValue;
        }

        public override string Key { get; set; } = "MarketRefreshTime";
        public override string Name { get; set; } = "市场价格保留小时数";

        public override string WizardName { get; } = "缓存保留小时数";
        public override string HelpText { get; set; } = "从 Universalis 刷新前，市场价格的缓存保留时长";
        public override string Version => "1.7.0.0";
    }
}