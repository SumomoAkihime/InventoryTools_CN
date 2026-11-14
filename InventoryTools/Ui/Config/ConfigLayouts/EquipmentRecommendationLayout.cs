using InventoryTools.EquipmentSuggest;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.ConfigLayouts;

public class EquipmentRecommendationLayout : ConfigLayout
{
    public override PageLayout Build()
    {
        return Page("equipment-recommendation", "装备推荐",
            Paragraph("比较已装备和可使用的装备并推荐升级。以下是推荐界面打开时使用的默认设置。"),
            Section("默认值",
                Setting<EquipmentSuggestModeSetting>("推荐依据"),
                Setting<EquipmentSuggestViewModeSetting>("布局"))
        );
    }
}
