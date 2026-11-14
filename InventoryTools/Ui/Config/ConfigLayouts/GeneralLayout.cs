using InventoryTools.Logic.Settings;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.ConfigLayouts;

public class GeneralLayout : ConfigLayout
{
    public override PageLayout Build()
    {
        return Page("general", "常规",
            Section("保存",
                Paragraph("Allagan Tools 会保存自己的库存记录，以下设置控制写入磁盘的频率。"),
                Setting<AutoSaveSetting>("自动保存"),
                EnabledBy<AutoSaveSetting>(
                    Setting<AutoSaveTimeSetting>("频率")),
                Setting<PersistDataSetting>()),
            Section("插件联动",
                Paragraph("从其他界面使用 Allagan Tools 的入口。"),
                Setting<AddTitleMenuButtonSetting>("在标题菜单添加按钮"),
                Setting<CompendiumWotsitSetting>("在 Wotsit 中列出图鉴窗口")),
            Section("插件联动",
                Paragraph("从其他界面使用 Allagan Tools 的入口。"),
                Setting<ActiveCraftListSetting>())
        );
    }
}