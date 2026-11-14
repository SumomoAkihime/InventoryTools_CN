using AllaganLib.GameSheets.Caches;
using InventoryTools.Logic.Columns.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Columns;

public class IsGlamourReadySetItemColumn : CheckboxColumn
{
    public IsGlamourReadySetItemColumn(ILogger<IsGlamourReadySetItemColumn> logger, ImGuiService imGuiService) : base(logger, imGuiService)
    {
    }

    public override ColumnCategory ColumnCategory => ColumnCategory.Basic;
    public override bool HasFilter { get; set; } = true;
    public override ColumnFilterType FilterType { get; set; } = ColumnFilterType.Boolean;

    public override bool? CurrentValue(ColumnConfiguration columnConfiguration, SearchResult searchResult)
    {
        return searchResult.Item.HasUsesByType(ItemInfoType.GlamourReadySetItem);
    }

    public override string Name { get; set; } = "是否为组合投影物品";
    [Newtonsoft.Json.JsonIgnore]
    public override string ExportName => "Is Outfit Glamour Item?";
    public override float Width { get; set; } = 100;
    public override string HelpText { get; set; } = "物品是否属于组合投影物品";
}