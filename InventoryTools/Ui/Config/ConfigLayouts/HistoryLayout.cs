using InventoryTools.Logic.Settings;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.ConfigLayouts;

public class HistoryLayout : ConfigLayout
{
    public override PageLayout Build()
    {
        return Page("history", "历史记录",
            Paragraph("记录物品移入、移出及库存间移动的情况，供历史列表查询。"),
            Paragraph("启用此项后，历史类型列表才能工作。"),
            Section("追踪",
                Setting<HistoryEnabledSetting>("追踪库存变化"),
                EnabledBy<HistoryEnabledSetting>(
                    Setting<HistoryTrackEventsSetting>("要记录的事件")))
        );
    }
}
