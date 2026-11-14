using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Logic.Settings.Abstract.Generic;
using InventoryTools.Services;
using InventoryTools.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Settings;

public class TooltipDisplayCuratedListsSetting : GenericBooleanSetting
{
    public TooltipDisplayCuratedListsSetting(ILogger<TooltipDisplayCuratedListsSetting> logger,
        ImGuiService imGuiService) : base(
        "TooltipDisplayCuratedLists",
        "精选列表信息",
        "悬停物品时，显示已包含此物品的精选列表。",
        false,
        "15.0.12",
        logger,
        imGuiService)
    {
    }
}

public class TooltipCuratedListsSetting : MultipleListChoiceSetting
{
    public TooltipCuratedListsSetting(ILogger<TooltipCuratedListsSetting> logger, ImGuiService imGuiService,
        IListService listService) : base(logger, imGuiService, listService)
    {
    }

    public override FilterType? ListFilterType => FilterType.CuratedList;

    public override string Key { get; set; } = "TooltipCuratedLists";
    public override string Name { get; set; } = "要检查的精选列表";

    public override string HelpText { get; set; } =
        "要检查的精选列表，未选择时检查全部精选列表。";

    public override string Version => "15.0.12";
}

public class TooltipCuratedListsMatchQualitySetting : GenericBooleanSetting
{
    public TooltipCuratedListsMatchQualitySetting(ILogger<TooltipCuratedListsMatchQualitySetting> logger,
        ImGuiService imGuiService) : base(
        "TooltipCuratedListsMatchQuality",
        "匹配物品品质",
        "悬停物品的品质是否必须与精选列表条目一致，关闭时 NQ 和 HQ 可互相匹配",
        false,
        "15.0.12",
        logger,
        imGuiService)
    {
    }
}