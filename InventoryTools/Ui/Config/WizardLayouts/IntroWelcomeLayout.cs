using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.WizardLayouts;

public class IntroWelcomeLayout : ContentLayout
{
    public override PageLayout Build()
    {
        return Page("intro/welcome", "概览",
            Paragraph("Allagan Tools 提供三项主要功能。接下来几页将简要介绍，约需一分钟。更多说明可随时在帮助窗口查看。"),
            Section("追踪你的库存",
                Paragraph("在一个位置搜索角色、雇员、部队、陆行鸟鞍囊和投影台中的物品。")),
            Section("规划制作",
                Paragraph("将制作目标拆解为全部子材料，核对已有库存，并查找其余材料的购买或采集位置。")),
            Section("查询资料",
                Paragraph("涵盖物品、怪物、副本、NPC、飞空艇等内容的资料库，用于查询来源和用途。"))
        );
    }
}
