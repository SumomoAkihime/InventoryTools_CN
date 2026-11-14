using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Logic.Settings.Abstract.Generic;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Settings;

public class AcquisitionTrackerLoginDelaySetting : GenericIntegerSetting
{
    public AcquisitionTrackerLoginDelaySetting(ILogger<AcquisitionTrackerLoginDelaySetting> logger, ImGuiService imGuiService) : base("AcquisitionTrackerLoginDelay", "登录延迟", "获取追踪器会在登录时初次扫描角色背包。游戏会连续发送多次库存更新，扫描器需等待后才完成。若登录时制作清单物品随机被标记为完成，可增加此延迟。", 5, "1.12.0.8", logger, imGuiService)
    {
    }
}