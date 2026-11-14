using InventoryTools.Logic.GenericFilters;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Filters;

public class CraftReportCompletionOnlyFilter : GenericBooleanFilter
{
    public CraftReportCompletionOnlyFilter(ILogger<CraftReportCompletionOnlyFilter> logger, ImGuiService imGuiService) :
        base(
            "CraftReportCompletionOnly", "仅在物品完成时报告",
            "物品达到所需数量时才输出消息。",
            FilterCategory.Notifications, null, null, logger, imGuiService)
    {
        DefaultValue = false;
        AvailableIn = FilterType.CraftFilter;
    }
}