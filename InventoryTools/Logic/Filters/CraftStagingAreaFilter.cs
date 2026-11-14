using System.Collections.Generic;
using CriticalCommonLib.Models;
using InventoryTools.Logic.Editors;
using InventoryTools.Logic.Filters.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Filters;

public class CraftStagingAreaFilter : InventoryScopeFilter
{
    public CraftStagingAreaFilter(InventoryScopePicker scopePicker, ILogger<CraftStagingAreaFilter> logger, ImGuiService imGuiService) : base(scopePicker, logger, imGuiService)
    {
    }

    public override string Key { get; set; } = "CraftStagingArea";
    public override string Name { get; set; } = "暂存区";

    public override string HelpText { get; set; } =
        "制作时视为暂存区的库存。暂存区物品计入用户库存，默认包含当前角色背包、水晶和货币，也可加入陆行鸟鞍囊等。";

    public override FilterCategory FilterCategory { get; set; } = FilterCategory.Inventories;

    public override List<InventorySearchScope>? DefaultValue { get; set; } = null;

    public override FilterType AvailableIn { get; set; } = FilterType.CraftFilter;
    public override List<InventorySearchScope>? GenerateDefaultScope()
    {
        return new List<InventorySearchScope>()
        {
            new InventorySearchScope() { ActiveCharacter = true, CharacterTypes = [CharacterType.Character], Categories = [InventoryCategory.CharacterBags, InventoryCategory.Currency, InventoryCategory.Crystals] }
        };
    }

    public override int Order { get; set; } = -1;
}