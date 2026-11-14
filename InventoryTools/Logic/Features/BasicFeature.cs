using System.Collections.Generic;
using InventoryTools.Logic.Settings;
using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Ui.Config;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Logic.Features;

public class BasicFeature : Feature
{
    public BasicFeature(IEnumerable<ISetting> settings) : base(settings)
    {
    }

    public override PageLayout Build()
    {
        return Page("feature/basic", "基础",
            Paragraph("这些设置应用于整个插件，之后可在设置窗口修改。"),
            Setting<AutoSaveSetting>("自动保存库存"),
            Setting<HistoryEnabledSetting>("启用物品历史追踪"),
            Setting<AddTitleMenuButtonSetting>("在游戏标题菜单添加按钮")
        );
    }
}