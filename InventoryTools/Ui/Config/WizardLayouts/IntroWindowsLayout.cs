using InventoryTools.EquipmentSuggest;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.WizardLayouts;

public class IntroWindowsLayout : ContentLayout
{
    public override PageLayout Build()
    {
        return Page("intro/windows", "其他工具",
            Paragraph("列表、制作和图鉴之外还提供两个计算器，可从任意 Allagan Tools 窗口底部的菜单按钮打开。"),
            Section("陆行鸟染色计算器",
                Paragraph("选择陆行鸟的目标颜色，计算器会生成水果及喂食顺序。锁定顺序后可逐项勾选并追踪进度。"),
                OpenWindow<ChocoboColourWindow>("打开陆行鸟染色计算器")),
            Section("装备推荐",
                Paragraph("选择职业后，从全部角色和雇员持有的装备中比较品级及相关属性，推荐优于当前装备的物品。"),
                OpenWindow<EquipmentSuggestWindow>("打开装备推荐")),
            Section("需要了解的两件事",
                Paragraph("右键物品或表格行可查看更多操作，点击插件内任意物品图标可打开完整信息页。"))
        );
    }
}
