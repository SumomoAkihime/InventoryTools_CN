using System;
using AllaganLib.GameSheets.Caches;
using AllaganLib.GameSheets.ItemSources;
using AllaganLib.GameSheets.Sheets;
using CriticalCommonLib.Models;
using Dalamud.Plugin;
using Dalamud.Plugin.Services;
using Dalamud.Bindings.ImGui;

namespace InventoryTools.Logic.ItemRenderers;

public class ItemArmoireSourceRenderer : ItemInfoRenderer<ItemArmoireSource>
{
    public ItemArmoireSourceRenderer(ItemSheet itemSheet, MapSheet mapSheet, ITextureProvider textureProvider,
        IDalamudPluginInterface dalamudPluginInterface) : base(textureProvider, dalamudPluginInterface, itemSheet, mapSheet)
    {
    }

    public override RendererType RendererType => RendererType.Use;
    public override ItemInfoType Type => ItemInfoType.Armoire;
    public override string SingularName => "存放在收藏柜";
    public override bool ShouldGroup => true;
    public override string HelpText => "物品是否可放入收藏柜";

    public override Action<ItemSource> DrawTooltip => source =>
    {
        var asSource = AsSource(source);
        ImGui.Text("类别： " +
                   (asSource.Cabinet.CabinetCategory?.Base.Category.Value.Text.ExtractText() ?? "未知"));
    };
    public override Func<ItemSource, string> GetName => source =>
    {
        var asSource = AsSource(source);

        return "类别： " + asSource.Cabinet.CabinetCategory?.Base.Category.Value.Text.ExtractText();
    };

    public override Func<ItemSource, int> GetIcon => _ => Icons.ArmoireIcon;

    public override Func<ItemSource, string> GetDescription => source =>
    {
        var asSource = AsSource(source);
        return $"可放入 {asSource.Cabinet.CabinetCategory?.Base.Category.Value.Text}";
    };
}