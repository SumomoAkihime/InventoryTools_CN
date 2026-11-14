using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.WizardLayouts;

public class FilteringHelpLayout : ContentLayout
{
    public override PageLayout Build()
    {
        return Page("help/filtering", "筛选",
            Section("高级搜索语法",
                Paragraph("创建列表或搜索列表结果时，可使用运算符细化条件。可用运算符取决于搜索字段。"),
                Bullet("! · 匹配不包含输入内容的结果，支持文本和数字。"),
                Bullet("< · 匹配小于输入值的数字结果。"),
                Bullet("> · 匹配大于输入值的数字结果。"),
                Bullet(">= · 匹配大于或等于输入值的数字结果。"),
                Bullet("<= · 匹配小于或等于输入值的数字结果。"),
                Bullet("= · 精确匹配输入内容，支持文本和数字。"),
                Bullet("&& 和 || 分别表示“且”和“或”，用于组合条件。"))
        );
    }
}
