using CriticalCommonLib.MarketBoard;
using CriticalCommonLib.Services;

using InventoryTools.Logic.Columns.Abstract;
using InventoryTools.Logic.Columns.ColumnSettings;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Columns
{
    public class MarketBoardMinPriceColumn : MarketBoardPriceColumn
    {
        private readonly ICharacterMonitor _characterMonitor;
        private readonly IMarketCache _marketCache;

        public MarketBoardMinPriceColumn(ILogger<MarketBoardMinPriceColumn> logger, ImGuiService imGuiService, MarketboardWorldSetting marketboardWorldSetting, ICharacterMonitor characterMonitor, IMarketCache marketCache) : base(logger, imGuiService, marketboardWorldSetting, characterMonitor, marketCache)
        {
            _characterMonitor = characterMonitor;
            _marketCache = marketCache;
        }
        public override ColumnCategory ColumnCategory => ColumnCategory.Market;

        public override string HelpText { get; set; } =
            "显示 NQ 和 HQ 的最低价格。未选择服务器时使用所属服务器，数据来自 Universalis。";

        public override (int, int)? CurrentValue(ColumnConfiguration columnConfiguration, SearchResult searchResult)
        {
            var activeCharacter = _characterMonitor.ActiveCharacter;

            if (searchResult.InventoryItem != null)
            {
                if (!searchResult.InventoryItem.CanBeTraded)
                {
                    return (Untradable, Untradable);
                }

                if (activeCharacter != null)
                {
                    var selectedWorldId = MarketboardWorldSetting.SelectedWorldId(columnConfiguration, activeCharacter);

                    var marketBoardData = _marketCache.GetPricing(searchResult.InventoryItem.ItemId, selectedWorldId, false);
                    if (marketBoardData != null)
                    {
                        var nq = marketBoardData.MinPriceNq;
                        var hq = marketBoardData.MinPriceHq;
                        return ((int) nq, (int) hq);
                    }
                }

                return (Loading, Loading);
            }
            if (!searchResult.Item.CanBePlacedOnMarket)
            {
                return (Untradable, Untradable);
            }
            if (activeCharacter != null)
            {
                var selectedWorldId = MarketboardWorldSetting.SelectedWorldId(columnConfiguration, activeCharacter);

                var marketBoardData = _marketCache.GetPricing(searchResult.Item.RowId, selectedWorldId, false);
                if (marketBoardData != null)
                {
                    var nq = marketBoardData.MinPriceNq;
                    var hq = marketBoardData.MinPriceHq;
                    return ((int)nq, (int)hq);
                }
            }

            return (Loading, Loading);
        }
        public override string Name { get; set; } = "市场最低价格 NQ／HQ";
        [Newtonsoft.Json.JsonIgnore]
        public override string ExportName => "Market Board Minimum Price NQ/HQ";
        public override string RenderName => "市场最低价 NQ／HQ";

        public override FilterType DefaultIn => Logic.FilterType.CraftFilter;
    }
}