using System.Collections.Generic;
using CriticalCommonLib.Models;
using InventoryTools.Logic.Editors;
using InventoryTools.Logic.Filters.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Filters;

public class CraftSourceInventoriesFilter : InventoryScopeFilter
{
    public CraftSourceInventoriesFilter(InventoryScopePicker scopePicker, ILogger<CraftSourceInventoriesFilter> logger, ImGuiService imGuiService) : base(scopePicker, logger, imGuiService)
    {
    }

    public override string Key { get; set; } = "CraftSourceInventories";
    public override string Name { get; set; } = "取出物品的来源库存";

    public override string HelpText { get; set; } =
        "制作清单检查的取物来源库存。匹配物品显示在“雇员／背包中的物品”中，按清单配置在采集前或采集后取出。";

    public override FilterCategory FilterCategory { get; set; } = FilterCategory.Inventories;

    public override List<InventorySearchScope>? DefaultValue { get; set; } = null;

    public override FilterType AvailableIn { get; set; } = FilterType.CraftFilter;
    public override List<InventorySearchScope>? GenerateDefaultScope()
    {
        return new List<InventorySearchScope>()
        {
            new InventorySearchScope() { ActiveCharacter = true, Categories = [InventoryCategory.RetainerBags, InventoryCategory.FreeCompanyBags, InventoryCategory.CharacterSaddleBags, InventoryCategory.CharacterPremiumSaddleBags] }
        };
    }

    public override int Order { get; set; } = -3;
}