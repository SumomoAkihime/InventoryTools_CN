using AllaganLib.GameSheets.Sheets.Rows;
using CriticalCommonLib.Models;
using InventoryTools.Logic.Filters.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Filters;

public class CraftTrackerTrackShoppingFilter : BooleanFilter
{
    public CraftTrackerTrackShoppingFilter(ILogger<CraftTrackerTrackShoppingFilter> logger, ImGuiService imGuiService) : base(logger, imGuiService)
    {
    }
    
    public override bool? DefaultValue { get; set; } = true;
    
    public override FilterType AvailableIn { get; set; } = FilterType.CraftFilter;
    
    public override string Key { get; set; } = "CraftTrackerTrackShopping";
    public override string Name { get; set; } = "追踪购物";
    
    public override string HelpText { get; set; } =
        "从商店购买清单成品时，是否减少对应需求数量。需要激活制作清单才会统计。";
    
    public override FilterCategory FilterCategory { get; set; } = FilterCategory.CompletionTracking;
    public override bool? FilterItem(FilterConfiguration configuration, InventoryItem item)
    {
        return null;
    }
    
    public override bool? FilterItem(FilterConfiguration configuration, ItemRow item)
    {
        return null;
    }
}