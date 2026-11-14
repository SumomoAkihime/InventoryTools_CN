using InventoryTools.Logic.Settings;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.ConfigLayouts;

public class ItemIconsLayout : ConfigLayout
{
    public override PageLayout Build()
    {
        return Page("item-icons", "物品图标",
            Paragraph("物品存在多种相似来源或用途时，可将图标折叠成一个分组图标。各来源和用途可单独覆盖此默认设置。"),
            Section("来源",
                Scrollable("sourceIconGrouping", 320,
                    Setting<SourceIconGroupingSetting>())),
            Section("用途",
                Scrollable("useIconGrouping", 200,
                    Setting<UseIconGroupingSetting>()))
        );
    }
}