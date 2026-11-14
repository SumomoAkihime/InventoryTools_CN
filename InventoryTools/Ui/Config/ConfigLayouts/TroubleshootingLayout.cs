using InventoryTools.Logic.Settings;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.ConfigLayouts;

public class TroubleshootingLayout : ConfigLayout
{
    public override PageLayout Build()
    {
        return Page("troubleshooting", "故障排查",
            Paragraph("出现特定异常时再调整这些时间参数，默认值适合大多数情况。"),
            Section("获取追踪器",
                Paragraph("获取追踪器记录制作、采集和拾取行为，自动更新制作清单。两个时间参数均以秒为单位，较大的值可提升慢速网络或繁忙电脑上的可靠性。"),
                Setting<AcquisitionTrackerLoginDelaySetting>("登录后等待此时长再扫描"),
                Setting<AcquisitionTrackerPersistStateSetting>("停止后继续追踪的时长"))
        );
    }
}
