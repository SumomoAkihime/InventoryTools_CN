using System;
using AllaganLib.GameSheets.Sheets.Rows;
using CriticalCommonLib.Models;
using InventoryTools.Logic.GenericFilters;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Filters;

public class CanBeHighQualityFilter : GenericBooleanFilter
{
    public CanBeHighQualityFilter(ILogger<CanBeHighQualityFilter> logger, ImGuiService imGuiService) : base("CanBeHq", "是否可为高品质", "物品是否可为高品质", FilterCategory.Basic, item => item.Item.Base.CanBeHq, item => item.Base.CanBeHq, logger, imGuiService)
    {
    }
}