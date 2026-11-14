using InventoryTools.Logic.Settings;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.ConfigLayouts;

public class HighlightingLayout : ConfigLayout
{
    public override PageLayout Build()
    {
        return Page("highlighting", "高亮",
            Paragraph("列表匹配物品时会为库存格子和背包标签着色。以下是默认设置，各列表可覆盖其中多数选项。"),
            Section("活动列表",
                Paragraph("通常可通过各窗口中的“高亮”按钮或斜杠命令控制高亮，也可在此切换。"),
                Setting<WindowFilterSetting>(),
                Setting<BackgroundFilterSetting>(),
                Setting<SaveBackgroundFilterSetting>("Remember the choice between sessions")
            ),
            Section("高亮条件",
                Setting<HighlightWhenSetting>(),
                Setting<InvertHighlightingSetting>(),
                Setting<InvertTabHighlightingSetting>()),
            Section("颜色",
                Setting<HighlightColourSetting>("匹配物品颜色"),
                Setting<TabHighlightColourSetting>("匹配标签页颜色")),
            Section("目标位置",
                Paragraph("整理列表记录物品的目标位置，可同时高亮来源和目标背包，方便查看移动的两端。"),
                Setting<HighlightDestinationSetting>(),
                EnabledBy<HighlightDestinationSetting>(
                    Setting<HighlightDestinationEmptySetting>(),
                    Setting<InvertDestinationHighlightingSetting>(),
                    Setting<HighlightDestinationColourSetting>("目标位置颜色"))),
            Section("雇员列表",
                Paragraph("雇员持有列表关注的物品时，可在传唤铃列表添加标注，方便选择需要打开的雇员。"),
                Setting<ColourRetainerListSetting>("为雇员名称着色"),
                EnabledBy<ColourRetainerListSetting>(
                    Setting<RetainerListColourSetting>("名称颜色")),
                Setting<ShowItemNumberRetainerListSetting>("显示物品数量")),
            Section("商店高亮",
                Paragraph("商店窗口打开时，可高亮列表匹配的物品，并标记场景中出售这些物品的商人。"),
                Setting<ShopHighlightingDisableItemsSetting>("调暗不匹配的物品"),
                Setting<ShopHighlightingNpcSetting>("高亮场景中的商人 NPC"),
                EnabledBy<ShopHighlightingNpcSetting>(
                    Setting<ShopHighlightingNpcColorSetting>("高亮颜色"),
                    Setting<ShopHighlightingNpcNameplateIconSetting>("在名牌上显示图标")))
        );
    }
}