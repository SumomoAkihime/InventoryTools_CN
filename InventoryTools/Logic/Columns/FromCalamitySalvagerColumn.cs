using System.Linq;
using InventoryTools.Logic.Columns.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Columns;

public class FromCalamitySalvagerColumn : CheckboxColumn
{
    public FromCalamitySalvagerColumn(ILogger<FromCalamitySalvagerColumn> logger, ImGuiService imGuiService) : base(logger, imGuiService)
    {
    }

    public override string Name { get; set; } = "是否来自遗失物管理人";
    [Newtonsoft.Json.JsonIgnore]
    public override string ExportName => "Is from Calamity Salvager?";
    public override float Width { get; set; } = 100;
    public override string HelpText { get; set; } = "物品是否可从遗失物管理人处获取";
    public override ColumnCategory ColumnCategory { get; } = ColumnCategory.Basic;
    public override bool HasFilter { get; set; } = true;
    public override ColumnFilterType FilterType { get; set; } = ColumnFilterType.Boolean;

    public override bool? CurrentValue(ColumnConfiguration columnConfiguration, SearchResult item)
    {
        return item.Item.CalamitySalvagerShops.Count != 0;
    }
}