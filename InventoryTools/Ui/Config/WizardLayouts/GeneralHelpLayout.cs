using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.WizardLayouts;

public class GeneralHelpLayout : ContentLayout
{
    public override PageLayout Build()
    {
        return Page("help/general", "常规",
            Paragraph("Allagan Tools 提供三项主要功能，包括追踪和显示库存、规划制作以及查询物品信息。"),
            Paragraph("设计参考了 Teamcraft 和 Garland Tools 的部分功能。"),
            Section("库存追踪",
                Paragraph("插件会尽力追踪库存，部分库存需要首次打开后才会缓存。若看不到雇员、部队或投影台等内容，请先在游戏中打开对应库存。"),
                Paragraph("记录物品后，即可创建列表，缩小搜索范围、辅助整理并使用更多功能。")),
            Section("制作规划",
                Paragraph("制作窗口可创建目标物品清单，生成逐级材料计划，显示缺少的物品、已有材料位置，以及其余材料的查找或购买位置。"),
                Paragraph("使用过 Teamcraft 的用户会很熟悉这些操作。")),
            Section("物品信息",
                Paragraph("插件提供详细物品资料，内容与 Garland Tools 类似。点击插件内任意物品图标可打开物品信息窗口。")),
            Section("高亮",
                Paragraph("物品列表和制作清单均可启用游戏内高亮。插件窗口可见时勾选“高亮”，通过宏使用时请查看帮助中的命令部分，启用 background 后台高亮。")),
            Section("更多",
                Paragraph("这是基础指南，更多信息请查看 Wiki。"),
                Link("打开 Wiki", "https://github.com/Critical-Impact/InventoryTools/wiki/1.-Overview"))
        );
    }
}
