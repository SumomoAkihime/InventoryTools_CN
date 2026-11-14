using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.WizardLayouts;

public class IntroInventoriesLayout : ContentLayout
{
    public override PageLayout Build()
    {
        return Page("intro/inventories", "你的物品",
            Paragraph("游戏至少显示过一次的库存才能被插件记录，这是游戏发送数据的方式决定的。"),
            Section("如果内容缺失",
                Paragraph("在游戏中打开一次后即可记录。常见操作如下。"),
                Bullet("雇员·使用传唤铃并打开每位雇员的库存。"),
                Bullet("部队仓库·打开需要记录的各个标签页。"),
                Bullet("投影台和收藏柜。"),
                Bullet("陆行鸟鞍囊。")),
            Section("随后",
                Paragraph("插件保留库存副本，方便随时搜索雇员物品。"))
        );
    }
}
