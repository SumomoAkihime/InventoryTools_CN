using InventoryTools.Logic.Columns.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Columns
{
    public class CanBeGatheredColumn : CheckboxColumn
    {
        public CanBeGatheredColumn(ILogger<CanBeGatheredColumn> logger, ImGuiService imGuiService) : base(logger, imGuiService)
        {
        }
        public override ColumnCategory ColumnCategory => ColumnCategory.Basic;
        public override bool? CurrentValue(ColumnConfiguration columnConfiguration, SearchResult searchResult)
        {
            return searchResult.Item.ObtainedGathering || searchResult.Item.ObtainedFishing;
        }
        public override string Name { get; set; } = "是否可采集";
        [Newtonsoft.Json.JsonIgnore]
        public override string ExportName => "Is Gatherable?";
        public override float Width { get; set; } = 80.0f;
        public override string HelpText { get; set; } = "物品是否可采集";
        public override bool HasFilter { get; set; } = true;
        public override ColumnFilterType FilterType { get; set; } = ColumnFilterType.Boolean;
        public override FilterType DefaultIn => Logic.FilterType.GameItemFilter;
    }
}