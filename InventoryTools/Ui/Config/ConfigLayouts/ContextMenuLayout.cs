using InventoryTools.Logic.Settings;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.ConfigLayouts;

public class ContextMenuLayout : ConfigLayout
{
    public override PageLayout Build()
    {
        return Page("context-menu", "右键菜单",
            Paragraph("Allagan Tools 添加到游戏右键菜单的选项。每项可单独启用。"),
            Section("列表",
                Setting<ContextMenuAddToCraftListSetting>("添加到制作清单"),
                Setting<ContextMenuAddToActiveCraftListSetting>("添加到当前制作清单"),
                Setting<ContextMenuAddToCuratedListSetting>("添加到精选列表"),
                Setting<ContextMenuAddToFavouritesSetting>("添加或取消收藏")),
            Section("更多信息",
                Paragraph("为右键选中的对象打开 Allagan Tools 信息窗口。"),
                Setting<ContextMenuMoreInformationSetting>("物品"),
                Setting<ContextMenuMoreInformationNpcsSetting>("NPC"),
                Setting<ContextMenuMoreInformationMonstersSetting>("怪物")),
            Section("在游戏中打开",
                Paragraph("打开各类游戏笔记的快捷操作。"),
                Setting<ContextMenuOpenCraftingLogSetting>("制作笔记"),
                Setting<ContextMenuOpenGatheringLogSetting>("采集笔记"),
                Setting<ContextMenuOpenFishingLogSetting>("钓鱼笔记")),
            Section("搜索",
                Paragraph("搜索位置设置也适用于 Allagan Tools 自有菜单发起的搜索。"),
                Paragraph("此搜索覆盖插件已知的全部角色。"),
                Setting<ContextMenuItemSearchSetting>("搜索此物品"),
                Paragraph("可通过下方搜索范围限定搜索位置。"),
                Setting<ContextMenuItemSearchScopeSetting>("搜索以下位置")),
            Section("其他",
                Setting<ContextMenuCopyNameSetting>("复制物品名称"))
        );
    }
}
