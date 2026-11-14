using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Logic.Settings.Abstract.Generic;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Settings;

public class AcquisitionTrackerPersistStateSetting : GenericIntegerSetting
{
    public AcquisitionTrackerPersistStateSetting(ILogger<AcquisitionTrackerPersistStateSetting> logger, ImGuiService imGuiService) : base("AcquisitionTrackerPersistState", "状态保留时间（秒）", "获取追踪器会记录制作、采集等状态，默认在返回空闲后保留 2 秒以处理延迟。若有漏记，可增加保留时长。", 2, "1.12.0.8", logger, imGuiService)
    {
    }
}