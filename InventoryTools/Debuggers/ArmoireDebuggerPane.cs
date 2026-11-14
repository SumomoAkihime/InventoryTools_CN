using System;
using AllaganLib.Shared.Interfaces;
using Dalamud.Bindings.ImGui;
using Dalamud.Plugin.Services;
using FFXIVClientStructs.FFXIV.Client.Game.UI;
using FFXIVClientStructs.FFXIV.Client.UI;

namespace InventoryTools.Debuggers;

public class ArmoireDebuggerPane : IDebugPane
{
    private readonly IGameGui _gameGui;

    public ArmoireDebuggerPane(IGameGui gameGui)
    {
        _gameGui = gameGui;
    }

    public string Name => "收藏柜";
    public unsafe void Draw()
    {
        var uiState = UIState.Instance();
        if (uiState == null)
        {
            ImGui.Text("未找到 UIState。");
        }
        else
        {
            ImGui.Text(uiState->Cabinet.IsCabinetLoaded() ? "收藏柜已加载" : "收藏柜未加载");
        }

        var addon = this._gameGui.GetAddonByName("CabinetWithdraw");
        if (addon != IntPtr.Zero)
        {
            var cabinetWithdraw = (AddonCabinetWithdraw*)addon.Address;
            if (cabinetWithdraw != null)
            {
                ImGui.Text($"选中的职业装备：{ (cabinetWithdraw->ArtifactArmorRadioButton->IsChecked ? "yes" : "no") }");
                ImGui.Text($"选中的季节装备 1：{ (cabinetWithdraw->SeasonalGear1RadioButton->IsChecked ? "yes" : "no") }");
                ImGui.Text($"选中的季节装备 2：{ (cabinetWithdraw->SeasonalGear2RadioButton->IsChecked ? "yes" : "no") }");
                ImGui.Text($"选中的季节装备 3：{ (cabinetWithdraw->SeasonalGear3RadioButton->IsChecked ? "yes" : "no") }");
                ImGui.Text($"选中的季节装备 4：{ (cabinetWithdraw->SeasonalGear4RadioButton->IsChecked ? "yes" : "no") }");
                ImGui.Text($"选中的季节装备 5：{ (cabinetWithdraw->SeasonalGear5RadioButton->IsChecked ? "yes" : "no") }");
                ImGui.Text($"选中的成就：{ (cabinetWithdraw->AchievementsRadioButton->IsChecked ? "yes" : "no") }");
                ImGui.Text($"选中的专属附加物品：{ (cabinetWithdraw->ExclusiveExtrasRadioButton->IsChecked ? "yes" : "no") }");
                ImGui.Text($"选中的搜索：{ (cabinetWithdraw->SearchRadioButton->IsChecked ? "yes" : "no") }");
            }
        }
    }
}