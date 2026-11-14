using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.WizardLayouts;

public class ListBasicsHelpLayout : ContentLayout
{
    public override PageLayout Build()
    {
        return Page("help/list-basics", "列表基础",
            Paragraph("列表用于查看、查找和整理物品。目前可创建三类列表。"),
            Section("搜索列表",
                Paragraph("在全部库存中搜索指定物品。适用于仅需查找物品的情况。"),
                Paragraph("使用示例："),
                Bullet("寻找制作所需材料。"),
                Bullet("寻找存放在某处的家具。"),
                Bullet("查看刚获得物品的价值。"),
                Bullet("检查指定物品是否已存入投影台或收藏柜。"),
                Bullet("无需前往传唤铃即可查看雇员装备。"),
                Bullet("检查持有物品中可放入收藏柜的物品。")),
            Section("整理列表",
                Paragraph("在搜索列表基础上选择整理的目标库存，插件将尝试规划最佳存放方式。"),
                Paragraph("使用示例："),
                Bullet("制作后整理剩余材料，避免分散成多堆。"),
                Bullet("将超过指定品级的物品存入陆行鸟鞍囊以备后用。"),
                Bullet("寻找部队仓库特有的物品并将其放回仓库。")),
            Section("游戏物品列表",
                Paragraph("搜索游戏物品目录中的全部物品。"),
                Paragraph("使用示例："),
                Bullet("搜索投影外观。"),
                Bullet("查看尚未获得的坐骑和宠物。"),
                Bullet("追踪游戏中全部物品的价格。"))
        );
    }
}
