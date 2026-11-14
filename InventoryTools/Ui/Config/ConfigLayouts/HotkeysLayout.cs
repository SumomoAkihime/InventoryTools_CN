using InventoryTools.Logic.Settings;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.ConfigLayouts;

public class HotkeysLayout : ConfigLayout
{
    public override PageLayout Build()
    {
        return Page("hotkeys", "快捷键",
            Section("切换窗口",
                Paragraph("可在任意位置使用。"),
                Setting<HotKeyListsWindowSetting>("列表"),
                Setting<HotkeyCraftWindowSetting>("制作"),
                Setting<HotkeyConfigWindowSetting>("设置"),
                Setting<HotkeyMobWindowSetting>("怪物"),
                Setting<HotkeyDutiesWindowSetting>("任务副本"),
                Setting<HotkeyAirshipWindowSetting>("飞空艇"),
                Setting<HotkeySubmarinesWindowSetting>("潜水艇"),
                Setting<HotkeyRetainerTasksWindowSetting>("雇员探险")),
            Section("鼠标悬停物品时",
                Paragraph("这些操作作用于光标下的物品，需要先悬停物品。"),
                Setting<HotkeyMoreInfoSetting>("更多信息"),
                Setting<HotkeyOpenItemLogSetting>("适用的游戏笔记"),
                Setting<HotkeyOpenCraftingLogSetting>("制作笔记"),
                Setting<HotkeyOpenGatheringLogSetting>("采集笔记"),
                Setting<HotkeyOpenFishingLogSetting>("钓鱼笔记"))
        );
    }
}
