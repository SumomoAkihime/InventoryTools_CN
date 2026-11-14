using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.WizardLayouts;

public class IntroListsLayout : ContentLayout
{
    public override PageLayout Build()
    {
        return Page("intro/lists", "列表",
            Paragraph("插件的大部分功能围绕列表展开。列表是保存的物品搜索条件，可用于游戏内高亮、整理和追踪。"),
            Section("三种类型",
                Bullet("搜索列表·搜索各处库存中的物品。"),
                Bullet("整理列表·查找物品并确定移动的目标位置。"),
                Bullet("游戏物品列表·搜索游戏中的全部物品。")),
            Section("查看",
                Paragraph("物品窗口用于管理列表，也可安装示例列表。"),
                OpenWindow<FiltersWindow>("打开物品窗口"))
        );
    }
}
