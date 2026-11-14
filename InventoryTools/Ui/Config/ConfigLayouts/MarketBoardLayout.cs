using InventoryTools.Logic.Settings;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.ConfigLayouts;

public class MarketBoardLayout : ConfigLayout
{
    public override PageLayout Build()
    {
        return Page("marketboard", "市场布告板",
            Paragraph("市场价格来自 Universalis，插件会下载并缓存价格。"),
            Section("查询价格的服务器",
                Paragraph("以下附加服务器会与所属服务器和当前服务器合并为一个查询列表。"),
                Setting<MarketBoardUseHomeWorldSetting>("所属服务器"),
                Setting<MarketBoardUseActiveWorldSetting>("当前服务器"),
                Setting<MarketBoardExtraWorldsSetting>("附加服务器")),
            Section("下载中",
            Paragraph("是否自动下载价格数据，关闭时需点击“刷新市场价格”下载"),
                Setting<AutomaticallyDownloadPricesSetting>("自动下载价格"),
                Setting<MarketRefreshTimeHoursSetting>("价格保留时间（小时）"),
                Setting<MarketBoardSaleCountLimitSetting>("成交历史范围（天）"))
        );
    }
}
