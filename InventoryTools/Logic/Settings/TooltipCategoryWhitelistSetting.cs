using System.Collections.Generic;
using System.Linq;
using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Services;
using Lumina.Excel;
using Lumina.Excel.Sheets;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Settings;

public class TooltipCategoryWhitelistSetting : MultipleChoiceSetting<uint>
{
    private readonly ExcelSheet<ItemUICategory> _itemUiCategorySheet;

    public TooltipCategoryWhitelistSetting(ILogger<TooltipCategoryWhitelistSetting> logger, ImGuiService imGuiService, ExcelSheet<ItemUICategory> itemUiCategorySheet) : base(logger, imGuiService)
    {
        _itemUiCategorySheet = itemUiCategorySheet;
    }

    public override List<uint> DefaultValue { get; set; } = new();
    public override List<uint> CurrentValue(InventoryToolsConfiguration configuration)
    {
        return configuration.TooltipWhitelistCategories;
    }

    public override void UpdateFilterConfiguration(InventoryToolsConfiguration configuration, List<uint> newValue)
    {
        configuration.TooltipWhitelistCategories = newValue;
    }

    public override string Key { get; set; } = "TooltipWhitelistCategories";
    public override string Name { get; set; } = "物品提示类别白名单";
    public override string HelpText { get; set; } = "将物品提示增强限定于这些类别。勾选“类别黑名单”时反向应用。";
    
    public override Dictionary<uint, string> GetChoices(InventoryToolsConfiguration configuration)
    {
        return _itemUiCategorySheet
            .ToDictionary(c => c.RowId, c => c.Name.ExtractText());
    }

    public override bool HideAlreadyPicked { get; set; } = true;
    public override string Version => "1.7.0.0";

}