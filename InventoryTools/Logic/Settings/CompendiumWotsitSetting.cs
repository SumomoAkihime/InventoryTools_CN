using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Logic.Settings.Abstract.Generic;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Settings;

public class CompendiumWotsitSetting : GenericBooleanSetting
{
    public CompendiumWotsitSetting(ILogger<CompendiumWotsitSetting> logger, ImGuiService imGuiService) : base("CompendiumWotsitSetting", "启用 Wotsit 联动", "是否在 Wotsit 搜索中列出图鉴窗口", true, "14.1.0", logger, imGuiService)
    {
    }
}