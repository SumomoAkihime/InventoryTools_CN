using InventoryTools.Logic.Settings;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.ConfigLayouts;

public class WindowsAndListsLayout : ConfigLayout
{
    public override PageLayout Build()
    {
        return Page("windows-lists", "窗口与列表",
            Section("布局",
                Paragraph("设置各窗口的布局。"),
                Setting<CraftWindowLayoutSetting>("制作窗口"),
                Setting<FiltersWindowLayoutSetting>("Items window"),
                Setting<ShowFiltersTabSetting>(),
                Setting<CompendiumRowHeightSetting>("图鉴行高")),
            Section("自动切换",
                Paragraph("界面切换列表时，若已开启高亮，是否自动高亮新列表"),
                Setting<SwitchFiltersAutomaticallySetting>(),
                Setting<SwitchCraftListsAutomaticallySetting>()),
            Section("忽略 Esc",
                Paragraph("按 Esc 后仍保持打开的窗口。"),
                Setting<CraftWindowIgnoreEscapeSetting>("制作窗口"),
                Setting<FiltersWindowIgnoreEscapeSetting>("Items window"),
                Setting<ItemWindowIgnoreEscapeSetting>("物品窗口"),
                Setting<FilterWindowIgnoreEscapeSetting>("List window"))
        );
    }
}