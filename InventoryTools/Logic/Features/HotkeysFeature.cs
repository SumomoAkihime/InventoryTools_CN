using System.Collections.Generic;
using InventoryTools.Logic.Settings;
using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Ui.Config;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Logic.Features;

public class HotkeysFeature : Feature
{
    public HotkeysFeature(IEnumerable<ISetting> settings) : base(settings)
    {
    }

    public override PageLayout Build()
    {
        return Page("feature/hotkeys", "快捷键",
            Paragraph("快捷键可选，字段留空表示不设置快捷键。"),
            Section("显示或隐藏窗口",
                Setting<HotKeyListsWindowSetting>("列表"),
                Setting<HotkeyCraftWindowSetting>("制作"),
                Setting<HotkeyConfigWindowSetting>("设置"),
                Setting<HotkeyMobWindowSetting>("怪物"),
                Setting<HotkeyDutiesWindowSetting>("任务副本"),
                Setting<HotkeyAirshipWindowSetting>("飞空艇"),
                Setting<HotkeySubmarinesWindowSetting>("潜水艇"),
                Setting<HotkeyRetainerTasksWindowSetting>("雇员探险")),
            Section("鼠标悬停物品时",
                Paragraph("这些快捷键作用于光标下的物品，需要先悬停物品。"),
                Setting<HotkeyMoreInfoSetting>("更多信息"),
                Setting<HotkeyOpenItemLogSetting>("物品对应的游戏笔记"),
                Setting<HotkeyOpenCraftingLogSetting>("制作笔记"),
                Setting<HotkeyOpenGatheringLogSetting>("采集笔记"),
                Setting<HotkeyOpenFishingLogSetting>("钓鱼笔记"))
        );
    }
}
