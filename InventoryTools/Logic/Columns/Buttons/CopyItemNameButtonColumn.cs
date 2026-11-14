using System.Collections.Generic;
using DalaMock.Host.Mediator;
using Dalamud.Bindings.ImGui;
using InventoryTools.Logic.Columns.Abstract;
using InventoryTools.Services;

namespace InventoryTools.Logic.Columns.Buttons;

public class CopyItemNameButtonColumn(IClipboardService clipboardService) : ButtonColumn
{
    public override string Name { get; set; } = "复制物品名称按钮";
    [Newtonsoft.Json.JsonIgnore]
    public override string ExportName => "Copy Item Name Button";
    public override float Width { get; set; } = 80;
    public override string HelpText { get; set; } = "复制物品名称到剪贴板。";

    public override List<MessageBase>? Draw(FilterConfiguration configuration, ColumnConfiguration columnConfiguration, SearchResult searchResult,
        int rowIndex, int columnIndex)
    {
        ImGui.TableNextColumn();
        if (ImGui.TableGetColumnFlags().HasFlag(ImGuiTableColumnFlags.IsEnabled))
        {
            if (ImGui.Button("复制名称##" + rowIndex + "_" + columnIndex))
            {
                clipboardService.CopyToClipboard(searchResult.Item.NameString);
            }
        }

        return null;
    }
}