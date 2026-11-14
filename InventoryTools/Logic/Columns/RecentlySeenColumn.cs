using InventoryTools.Extensions;
using InventoryTools.Logic.Columns.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Columns
{
    public class RecentlySeenColumn : TextColumn
    {
        private readonly PluginLogic _pluginLogic;

        public RecentlySeenColumn(ILogger<RecentlySeenColumn> logger, ImGuiService imGuiService, PluginLogic pluginLogic) : base(logger, imGuiService)
        {
            _pluginLogic = pluginLogic;
        }
        public override ColumnCategory ColumnCategory => ColumnCategory.Tools;

        public override string? CurrentValue(ColumnConfiguration columnConfiguration, SearchResult searchResult)
        {
            return _pluginLogic.GetLastSeenTime(searchResult.Item.RowId)?.ToHumanReadableString() ?? "";
        }
        public override string Name { get; set; } = "最后发现时间";
        [Newtonsoft.Json.JsonIgnore]
        public override string ExportName => "Last Seen Date/Time";
        public override string RenderName => "最后发现";
        public override float Width { get; set; } = 100;
        public override string HelpText { get; set; } = "显示最后发现物品的时间。";
        public override bool HasFilter { get; set; } = true;
        public override ColumnFilterType FilterType { get; set; } = ColumnFilterType.Text;
    }
}