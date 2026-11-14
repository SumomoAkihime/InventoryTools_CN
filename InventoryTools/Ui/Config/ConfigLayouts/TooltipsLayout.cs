using InventoryTools.Logic.Settings;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.ConfigLayouts;

public class TooltipsLayout : ConfigLayout
{
    public override PageLayout Build()
    {
        return PageGroup("tooltips", "物品提示",
            Page("tooltips/general", "常规",
                Paragraph("Allagan Tools 可向游戏物品提示添加信息。启用物品提示增强后，本节功能才会生效。"),
                Setting<ShowTooltipsSetting>("启用物品提示增强"),
                EnabledBy<ShowTooltipsSetting>(
                    Setting<ImGuiTooltipModeSetting>("在 Allagan Tools 自有窗口中显示"),
                    Setting<TooltipDisplayHeaderSetting>("在附加信息行标注插件名称"),
                    Setting<TooltipCategoryWhitelistSetting>("限定以下物品类别"),
                    Setting<TooltipCategoryBlacklistSetting>("将上方列表用作排除项"))),
            Page("tooltips/appearance", "外观",
                Paragraph("Allagan Tools 附加信息行的默认设置，各功能可单独覆盖颜色。"),
                Setting<TooltipColorSetting>("默认文字颜色"),
                Setting<TooltipHeaderLinesSetting>("上方空行"),
                Setting<TooltipFooterLinesSetting>("下方空行")),
            Page("tooltips/locations", "物品位置",
                Paragraph("已拥有此物品的位置及数量。"),
                Setting<TooltipDisplayAmountOwnedSetting>("显示此物品的持有位置"),
                EnabledBy<TooltipDisplayAmountOwnedSetting>(
                    Setting<TooltipLocationScopeLimitSetting>("搜索以下位置"),
                    Setting<TooltipLocationDisplayModeSetting>("显示模式"),
                    Setting<TooltipAmountOwnedSortSetting>("顺序"),
                    Setting<ToolTipLocationLimitSetting>("最大结果数"),
                    Setting<TooltipCurrentCharacterSetting>("仅当前角色"),
                    Setting<TooltipAddCharacterNameSetting>("附加角色名称"),
                    Setting<TooltipAmountOwnedColorSetting>("文字颜色"))),
            Page("tooltips/retrieve", "取出数量",
                Paragraph("当前整理列表或制作清单仍需取出的此物品数量。"),
                Setting<TooltipDisplayRetrieveAmountSetting>("显示取出数量"),
                EnabledBy<TooltipDisplayRetrieveAmountSetting>(
                    Setting<TooltipAmountToRetrieveColorSetting>("文字颜色"))),
            Page("tooltips/market", "市场价格",
                Paragraph("显示来自 Universalis 的物品价格，两行可分别启用。"),
                Setting<TooltipAverageMarketPriceSetting>("显示 NQ／HQ 平均价格"),
                Setting<TooltipMinimumMarketPriceSetting>("显示 NQ／HQ 最低价格"),
                Setting<TooltipMarketPricingColorSetting>("文字颜色")),
            Page("tooltips/unlock", "物品解锁状态",
                Paragraph("物品是否已习得及习得角色。"),
                Setting<TooltipDisplayUnlockSetting>("显示解锁状态"),
                EnabledBy<TooltipDisplayUnlockSetting>(
                    Setting<TooltipDisplayUnlockCharacterSetting>("要检查的角色"),
                    Setting<TooltipDisplayUnlockDisplayModeSetting>("显示模式"),
                    Setting<TooltipDisplayUnlockHideUnlockedSetting>("隐藏已获得的角色"),
                    Setting<TooltipItemUnlockStatusColorSetting>("文字颜色"))),
            Page("tooltips/coffer", "宝箱内容",
                Paragraph("显示宝箱等容器可能包含的物品。"),
                Setting<TooltipDisplayCofferLootSetting>("显示宝箱内容"),
                EnabledBy<TooltipDisplayCofferLootSetting>(
                    Setting<TooltipCofferLootScopeSetting>("搜索以下位置"),
                    Setting<TooltipCofferLootColorSetting>("文字颜色"))),
            Page("tooltips/curated", "精选列表",
                Paragraph("已包含此物品的精选列表。"),
                Setting<TooltipDisplayCuratedListsSetting>("显示精选列表"),
                EnabledBy<TooltipDisplayCuratedListsSetting>(
                    Setting<TooltipCuratedListsSetting>("限定以下列表"),
                    Setting<TooltipCuratedListsMatchQualitySetting>("匹配物品品质"),
                    Setting<TooltipCuratedListsColorSetting>("文字颜色"))),
            Page("tooltips/glamour", "组合投影",
                Paragraph("此物品是否能补齐正在收集的投影套装。"),
                Setting<TooltipDisplayGlamourReadySetSetting>("显示组合投影信息"),
                EnabledBy<TooltipDisplayGlamourReadySetSetting>(
                    Setting<TooltipGlamourReadySetScopeSetting>("搜索以下位置"),
                    Setting<TooltipGlamourReadySetDisplayModeSetting>("显示模式"),
                    Setting<TooltipGlamourReadySetColorSetting>("文字颜色"),
                    Setting<TooltipGlamourReadySetAcquiredColorSetting>("已获得物品颜色"),
                    Setting<TooltipGlamourReadySetNotAcquiredColorSetting>("未获得物品颜色"))),
            Page("tooltips/patch", "材料加入版本",
                Paragraph("制作材料加入的版本。"),
                Setting<TooltipDisplayIngredientPatchSetting>("显示材料加入版本"),
                EnabledBy<TooltipDisplayIngredientPatchSetting>(
                    Setting<TooltipIngredientPatchTooltipColorSetting>("文字颜色"))),
            Page("tooltips/sources", "来源信息",
                Paragraph("物品的获取方式。"),
                Setting<TooltipSourceInformationEnabledSetting>("显示来源信息"),
                EnabledBy<TooltipSourceInformationEnabledSetting>(
                    Setting<TooltipSourceInformationModifierSetting>("按住此键显示"),
                    Setting<TooltipSourceInformationColorSetting>("文字颜色"),
                    Scrollable("sourceInformation", 260,
                        Setting<TooltipSourceInformationSetting>()))),
            Page("tooltips/uses", "用途信息",
                Paragraph("物品可转换或兑换的内容。"),
                Setting<TooltipUseInformationEnabledSetting>("显示用途信息"),
                EnabledBy<TooltipUseInformationEnabledSetting>(
                    Setting<TooltipUseInformationModifierSetting>("按住此键显示"),
                    Setting<TooltipUseInformationColorSetting>("文字颜色"),
                    Scrollable("useInformation", 260,
                        Setting<TooltipUseInformationSetting>())))
        );
    }
}