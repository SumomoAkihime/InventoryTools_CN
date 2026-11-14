using InventoryTools.Boot;
using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Logic.Settings.Abstract.Generic;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Settings;

public class PersistDataSetting : GenericBooleanSetting
{
    private readonly BootConfiguration _bootConfiguration;

    public PersistDataSetting(ILogger<PersistDataSetting> logger, BootConfiguration bootConfiguration, ImGuiService imGuiService) : base("PersistData", "持久化缓存数据", "Allagan Tools 首次启动需要计算数据，视电脑性能可能耗时 5～10 秒或更久。启用此项可在更新间保留数据，加快插件启动。", true, "14.0.5", logger, imGuiService)
    {
        _bootConfiguration = bootConfiguration;
    }

    public override bool CurrentValue(InventoryToolsConfiguration configuration)
    {
        return _bootConfiguration.PersistLuminaCache;
    }

    public override void UpdateFilterConfiguration(InventoryToolsConfiguration configuration, bool newValue)
    {
        _bootConfiguration.PersistLuminaCache = newValue;
    }
}