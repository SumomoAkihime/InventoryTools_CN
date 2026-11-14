using InventoryTools.Logic.GenericFilters;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Filters;

public class CraftReportTrackGatheringFilter : GenericBooleanFilter
{
    public CraftReportTrackGatheringFilter(ILogger<CraftReportTrackGatheringFilter> logger, ImGuiService imGuiService) :
        base(
            "CraftReportTrackGathering", "报告采集的物品",
            "采集此制作清单中的物品时报告进度。", FilterCategory.Notifications,
            null, null, logger, imGuiService)
    {
        DefaultValue = true;
        AvailableIn = FilterType.CraftFilter;
    }
}

public class CraftReportTrackCraftingFilter : GenericBooleanFilter
{
    public CraftReportTrackCraftingFilter(ILogger<CraftReportTrackCraftingFilter> logger, ImGuiService imGuiService) :
        base(
            "CraftReportTrackCrafting", "报告制作的物品",
            "制作此制作清单中的物品时报告进度。", FilterCategory.Notifications,
            null, null, logger, imGuiService)
    {
        DefaultValue = false;
        AvailableIn = FilterType.CraftFilter;
    }
}

public class CraftReportTrackShoppingFilter : GenericBooleanFilter
{
    public CraftReportTrackShoppingFilter(ILogger<CraftReportTrackShoppingFilter> logger, ImGuiService imGuiService) :
        base(
            "CraftReportTrackShopping", "报告购买的物品",
            "购买此制作清单中的物品时报告进度。", FilterCategory.Notifications,
            null, null, logger, imGuiService)
    {
        DefaultValue = false;
        AvailableIn = FilterType.CraftFilter;
    }
}

public class CraftReportTrackCombatDropFilter : GenericBooleanFilter
{
    public CraftReportTrackCombatDropFilter(ILogger<CraftReportTrackCombatDropFilter> logger, ImGuiService imGuiService)
        : base(
            "CraftReportTrackCombatDrop", "报告战斗掉落",
            "此制作清单中的物品通过战斗掉落时报告进度。",
            FilterCategory.Notifications,
            null, null, logger, imGuiService)
    {
        DefaultValue = false;
        AvailableIn = FilterType.CraftFilter;
    }
}

public class CraftReportTrackMarketBoardFilter : GenericBooleanFilter
{
    public CraftReportTrackMarketBoardFilter(ILogger<CraftReportTrackMarketBoardFilter> logger,
        ImGuiService imGuiService) : base(
        "CraftReportTrackMarketBoard", "报告市场购买记录",
        "从市场布告板购买此制作清单中的物品时报告进度。",
        FilterCategory.Notifications,
        null, null, logger, imGuiService)
    {
        DefaultValue = false;
        AvailableIn = FilterType.CraftFilter;
    }
}

public class CraftReportTrackOtherFilter : GenericBooleanFilter
{
    public CraftReportTrackOtherFilter(ILogger<CraftReportTrackOtherFilter> logger, ImGuiService imGuiService) : base(
        "CraftReportTrackOther", "报告其他获取记录",
        "此制作清单中的物品通过其他方式获得时报告进度。",
        FilterCategory.Notifications,
        null, null, logger, imGuiService)
    {
        DefaultValue = false;
        AvailableIn = FilterType.CraftFilter;
    }
}