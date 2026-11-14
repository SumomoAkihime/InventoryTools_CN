using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Logic.Settings.Abstract.Generic;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Settings;

public class ContextMenuAddToFavouritesSetting : GenericBooleanSetting
{
    public ContextMenuAddToFavouritesSetting(ILogger<ContextMenuAddToFavouritesSetting> logger,
        ImGuiService imGuiService) : base("AddToFavouritesContextMenu",
        "右键菜单－添加／取消收藏",
        "添加物品收藏管理子菜单",
        false,
        "1.13.1.9",
        logger,
        imGuiService)
    {
    }

    public override string WizardName { get; } = "添加／取消收藏";

}