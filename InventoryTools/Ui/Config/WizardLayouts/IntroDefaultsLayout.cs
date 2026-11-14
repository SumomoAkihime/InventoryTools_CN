using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.WizardLayouts;

public class IntroDefaultsLayout : ContentLayout
{
    public override PageLayout Build()
    {
        return Page("intro/defaults", "默认值",
            Paragraph("插件默认启用一组预设功能。"),
            Paragraph("接下来将配置最常用的功能。"),
            Paragraph("将鼠标悬停在 ? 图标上可查看各设置的详细说明。")
        );
    }
}