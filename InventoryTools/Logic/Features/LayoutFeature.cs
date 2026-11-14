using System.Collections.Generic;
using InventoryTools.Logic.Settings;
using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Ui.Config;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Logic.Features;

public class LayoutFeature : Feature
{
    public LayoutFeature(IEnumerable<ISetting> settings) : base(settings)
    {
    }

    public override PageLayout Build()
    {
        return Page("feature/layout", "布局",
            Paragraph("物品和制作窗口可使用顶部标签页或侧栏显示列表。列表较多时适合侧栏，较少时适合标签页。"),
            Setting<FiltersWindowLayoutSetting>("Items window"),
            Setting<CraftWindowLayoutSetting>("制作窗口")
        );
    }
}
