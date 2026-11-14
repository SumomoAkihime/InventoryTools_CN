using System;
using System.Collections.Generic;
using System.Linq;
using AllaganLib.GameSheets.Sheets.Rows;
using CriticalCommonLib.Extensions;
using CriticalCommonLib.Models;
using CriticalCommonLib.Services;
using InventoryTools.Logic.Editors;
using InventoryTools.Logic.Filters.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Filters
{
    public class SourceInventoriesFilter : InventoryScopeFilter
    {
        public SourceInventoriesFilter(ILogger<SourceInventoriesFilter> logger, InventoryScopePicker scopePicker, ImGuiService imGuiService) : base(scopePicker, logger, imGuiService)
        {
        }
        public override int LabelSize { get; set; } = 240;
        public override string Key { get; set; } = "SourceInventories";
        public override string Name { get; set; } = "来源－库存";
        public override string HelpText { get; set; } =
            "按筛选器配置选择的整理来源库存列表";
        public override FilterCategory FilterCategory { get; set; } = FilterCategory.Inventories;

        public override List<InventorySearchScope>? DefaultValue { get; set; } = null;
        public override FilterType AvailableIn { get; set; } = FilterType.SearchFilter | FilterType.SortingFilter | FilterType.HistoryFilter;

        public override string GetName(FilterConfiguration configuration)
        {
            switch (configuration.FilterType)
            {
                case FilterType.SearchFilter:
                case FilterType.HistoryFilter:
                    return "搜索库存";
                case FilterType.SortingFilter:
                    return "来源库存";
            }

            return Name;
        }

        public override string GetHelpText(FilterConfiguration configuration)
        {
            switch (configuration.FilterType)
            {
                case FilterType.SearchFilter:
                    return
                        "定义要搜索并显示在列表中的库存。下方范围配置可查看已找到的库存。";
                case FilterType.HistoryFilter:
                    return
                        "定义库存变更历史列表中要显示的库存范围。";
                case FilterType.SortingFilter:
                    return
                        "定义要搜索的库存，插件将显示物品应移入的已选目标位置。下方范围配置可查看已找到的库存。";
            }

            return HelpText;
        }

        public override List<InventorySearchScope>? GenerateDefaultScope()
        {
            return null;
        }

    }
}