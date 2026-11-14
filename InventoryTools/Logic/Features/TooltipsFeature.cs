using System.Collections.Generic;
using InventoryTools.Logic.Settings;
using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Ui.Config;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Logic.Features;

public class TooltipsFeature : Feature
{
    public TooltipsFeature(IEnumerable<ISetting> settings) : base(settings)
    {
    }

    public override PageLayout Build()
    {
        return Page("feature/tooltips", "物品提示",
            Paragraph("Allagan Tools 可在游戏物品提示中添加额外信息。"),
            Setting<TooltipDisplayAmountOwnedSetting>("物品的持有位置"),
            Setting<TooltipDisplayRetrieveAmountSetting>("当前制作清单仍需的数量"),
            Setting<TooltipMinimumMarketPriceSetting>("市场价格"),
            Setting<TooltipDisplayUnlockSetting>("是否已习得／解锁此物品"),
            Setting<TooltipSourceInformationEnabledSetting>("物品来源"),
            Setting<TooltipUseInformationEnabledSetting>("物品用途"),
            Setting<TooltipDisplayIngredientPatchSetting>("材料加入的版本"),
            Setting<TooltipDisplayCofferLootSetting>("宝箱可能包含的物品"),
            Setting<TooltipDisplayCuratedListsSetting>("物品是否位于任一精选列表中"),
            Setting<TooltipDisplayGlamourReadySetSetting>("此物品是否能补齐一套投影"),
            Paragraph("各信息行的更多选项位于设置窗口的“物品提示”中，包括颜色、搜索位置和显示模式。")
        );
    }
}
