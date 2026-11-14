using InventoryTools.Compendium.Windows;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.WizardLayouts;

public class IntroCompendiumLayout : ContentLayout
{
    public override PageLayout Build()
    {
        return Page("intro/compendium", "图鉴",
            Paragraph("图鉴使用插件已有的数据展示游戏内容，可用于查询对象信息、来源及掉落。"),
            Section("包含内容",
                Bullet("物品、任务和成就。"),
                Bullet("坐骑、宠物和投影套装。"),
                Bullet("副本、理符、友好部族和老主顾交易。"),
                Bullet("古代武器与工具、秘籍、传承录和灵魂水晶。"),
                Bullet("NPC、区域、飞空艇及潜水艇航线。"),
                Bullet("职业、套装、陆行鸟物品及更多内容。")),
            Section("查看",
                Paragraph("条目可链接到相关内容，方便从物品查询掉落副本，再查找出售其他材料的 NPC。"),
                OpenWindow<CompendiumTypesWindow>("打开图鉴"),
                Paragraph("也可从物品或制作窗口的“图鉴”菜单，或使用 /compendium 命令打开。"))
        );
    }
}
