using AllaganLib.GameSheets.Sheets.Rows;
using CriticalCommonLib.Models;

using InventoryTools.Logic.Filters.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Filters;

public class IgnoreHQFilter : BooleanFilter
{
    public override string Key { get; set; } = "IgnoreHQFilter";
    public override string Name { get; set; } = "忽略 HQ 筛选器";

    public override string HelpText { get; set; } =
        "整理堆叠时是否将 HQ 和 NQ 视为相同物品，主要用于查找可降低品质后合并的物品。";

    public override FilterCategory FilterCategory { get; set; } = FilterCategory.Advanced;
    public override FilterType AvailableIn { get; set; } = FilterType.SortingFilter;

    public override void UpdateFilterConfiguration(FilterConfiguration configuration, bool? newValue)
    {
        configuration.IgnoreHQWhenSorting = newValue;
    }

    public override bool? CurrentValue(FilterConfiguration configuration)
    {
        return configuration.IgnoreHQWhenSorting;
    }

    public override bool? FilterItem(FilterConfiguration configuration, InventoryItem item)
    {
        return true;
    }

    public override bool? FilterItem(FilterConfiguration configuration, ItemRow item)
    {
        return true;
    }

    public IgnoreHQFilter(ILogger<IgnoreHQFilter> logger, ImGuiService imGuiService) : base(logger, imGuiService)
    {
    }
}