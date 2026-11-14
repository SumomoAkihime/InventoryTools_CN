using InventoryTools.Logic.GenericFilters;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Filters;

public class CraftReportProgressFilter : GenericBooleanFilter
{
    public CraftReportProgressFilter(ILogger<CraftReportProgressFilter> logger, ImGuiService imGuiService) : base(
        "CraftReportProgress", "在聊天中报告获取进度",
        "获得此制作清单中的物品时向聊天输出进度，例如“铁木原木还需 30 个”。需要激活清单。",
        FilterCategory.Notifications, null, null, logger, imGuiService)
    {
        DefaultValue = true;
        AvailableIn = FilterType.CraftFilter;
    }
}