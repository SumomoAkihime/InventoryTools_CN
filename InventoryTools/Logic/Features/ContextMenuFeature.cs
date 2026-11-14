using System.Collections.Generic;
using InventoryTools.Logic.Settings;
using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Ui.Config;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Logic.Features;

public class ContextMenuFeature : Feature
{
    public ContextMenuFeature(IEnumerable<ISetting> settings) : base(settings)
    {
    }

    public override PageLayout Build()
    {
        return Page("feature/context-menu", "右键菜单",
            Paragraph("插件可在物品右键菜单中添加以下项目。"),
            Section("更多信息",
                Setting<ContextMenuMoreInformationSetting>("物品"),
                Setting<ContextMenuMoreInformationNpcsSetting>("NPC"),
                Setting<ContextMenuMoreInformationMonstersSetting>("怪物")),
            Section("打开游戏笔记",
                Setting<ContextMenuOpenCraftingLogSetting>("制作笔记"),
                Setting<ContextMenuOpenGatheringLogSetting>("采集笔记"),
                Setting<ContextMenuOpenFishingLogSetting>("钓鱼笔记")),
            Section("列表",
                Setting<ContextMenuAddToCraftListSetting>("添加到制作清单"),
                Setting<ContextMenuAddToActiveCraftListSetting>("添加到当前制作清单"),
                Setting<ContextMenuAddToCuratedListSetting>("添加到精选列表"),
                Setting<ContextMenuAddToFavouritesSetting>("添加或取消收藏")),
            Section("其他",
                Setting<ContextMenuCopyNameSetting>("复制物品名称"))
        );
    }
}
