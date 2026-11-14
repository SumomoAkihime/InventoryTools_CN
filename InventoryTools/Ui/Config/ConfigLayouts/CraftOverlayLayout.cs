using InventoryTools.Logic.Settings;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.ConfigLayouts;

public class CraftOverlayLayout : ConfigLayout
{
    public override PageLayout Build()
    {
        return Page("craft-overlay", "制作悬浮窗",
            Paragraph("游戏内跟随当前制作清单的紧凑面板，可直接查看尚缺的物品。"),
            Section("显示",
                Setting<CraftOverlayMaxExpandedItemsSetting>("展开时显示的物品"),
                Setting<CraftOverlayHideSetting>("副本及过场动画中隐藏")),
            Section("行为",
                Setting<CraftOverlayRememberStateSetting>("重新加载后保持打开"))
        );
    }
}
