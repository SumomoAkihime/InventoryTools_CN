using System.Collections.Generic;
using InventoryTools.Logic.Settings;
using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Ui.Config;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Logic.Features;

public class MarketboardIntegrationFeature : Feature
{
    public MarketboardIntegrationFeature(IEnumerable<ISetting> settings) : base(settings)
    {
    }

    public override PageLayout Build()
    {
        return Page("feature/marketboard", "市场布告板",
            Paragraph("价格来自 Universalis，插件下载后会保留本地副本。启用此项后自动下载价格，关闭时需点击“刷新市场价格”获取更新。"),
            Setting<AutomaticallyDownloadPricesSetting>("自动下载价格"),
            Setting<MarketRefreshTimeHoursSetting>("价格保留小时数"),
            Setting<MarketBoardSaleCountLimitSetting>("包含的成交历史天数")
        );
    }
}
