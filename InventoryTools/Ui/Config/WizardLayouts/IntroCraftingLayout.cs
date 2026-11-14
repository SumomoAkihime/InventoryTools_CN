using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.WizardLayouts;

public class IntroCraftingLayout : ContentLayout
{
    public override PageLayout Build()
    {
        return Page("intro/crafting", "制作",
            Paragraph("制作清单将目标成品拆解为各级中间素材和原材料，并与已有库存比较。"),
            Section("可获得内容",
                Bullet("展示包含各级素材的完整材料树。"),
                Bullet("已拥有的物品及其所在角色或雇员。"),
                Bullet("缺少物品的购买或采集位置。"),
                Bullet("获取物品后剩余需求会随之减少。")),
            Section("查看",
                OpenWindow<CraftsWindow>("打开制作窗口"))
        );
    }
}
