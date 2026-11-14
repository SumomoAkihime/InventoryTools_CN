using InventoryTools.Logic.Columns.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Columns
{
    public class SearchCategoryColumn : TextColumn
    {
        public SearchCategoryColumn(ILogger<SearchCategoryColumn> logger, ImGuiService imGuiService) : base(logger, imGuiService)
        {
        }
        public override ColumnCategory ColumnCategory => ColumnCategory.Basic;
        public override string? CurrentValue(ColumnConfiguration columnConfiguration, SearchResult searchResult)
        {
            if (searchResult.Item.Base.ItemSearchCategory.IsValid)
            {
                return searchResult.Item.Base.ItemSearchCategory.Value.Name.ExtractText();
            }

            return "";
        }
        public override string Name { get; set; } = "类别（市场）";
        [Newtonsoft.Json.JsonIgnore]
        public override string ExportName => "Category (Marketboard)";
        public override string RenderName => "市场类别";
        public override float Width { get; set; } = 200.0f;

        public override string HelpText { get; set; } =
            "按市场布告板搜索分类确定的物品类别。";
        public override bool HasFilter { get; set; } = true;
        public override ColumnFilterType FilterType { get; set; } = ColumnFilterType.Text;
        public override FilterType DefaultIn => Logic.FilterType.GameItemFilter;
    }
}