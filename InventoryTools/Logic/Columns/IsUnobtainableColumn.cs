using InventoryTools.Logic.Columns.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Columns
{
    public class IsUnobtainableColumn : CheckboxColumn
    {
        public IsUnobtainableColumn(ILogger<IsUnobtainableColumn> logger, ImGuiService imGuiService) : base(logger, imGuiService)
        {
        }
        public override ColumnCategory ColumnCategory => ColumnCategory.Basic;

        public override bool? CurrentValue(ColumnConfiguration columnConfiguration, SearchResult searchResult)
        {
            return searchResult.Item.IsUnobtainable;
        }

        public override string Name { get; set; } = "是否已无法获得";
        [Newtonsoft.Json.JsonIgnore]
        public override string ExportName => "Is Unobtainable?";
        public override float Width { get; set; } = 100;
        public override string HelpText { get; set; } = "物品是否已无法获得";
        public override bool HasFilter { get; set; } = true;
        public override ColumnFilterType FilterType { get; set; } = ColumnFilterType.Boolean;
    }
}