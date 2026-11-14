using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using AllaganLib.GameSheets.Caches;
using AllaganLib.GameSheets.ItemSources;
using AllaganLib.GameSheets.Sheets;
using CriticalCommonLib.Models;
using Dalamud.Interface.Textures;
using Dalamud.Plugin;
using Dalamud.Plugin.Services;
using Dalamud.Bindings.ImGui;

namespace InventoryTools.Logic.ItemRenderers;

public abstract class ItemFieldOpCofferSourceRenderer<T> : ItemInfoRenderer<T> where T : ItemFieldOpCofferSource
{
    private readonly ItemInfoType _itemInfoType;

    public ItemFieldOpCofferSourceRenderer(ItemSheet itemSheet, MapSheet mapSheet, ITextureProvider textureProvider, IDalamudPluginInterface pluginInterface, ItemInfoType itemInfoType) : base(textureProvider, pluginInterface, itemSheet, mapSheet)
    {
        _itemInfoType = itemInfoType;
    }

    public override RendererType RendererType => RendererType.Source;
    public override ItemInfoType Type => _itemInfoType;
    public override bool ShouldGroup => true;
    public override Action<ItemSource> DrawTooltip => source =>
    {
        var asSource = AsSource(source);
        ImGui.Text("掉落自 " + asSource.CofferType + " coffer");
        if (asSource.Min != null && asSource.Max != null)
        {
            ImGui.SameLine();
            if (asSource.Min == asSource.Max)
            {
                ImGui.Text("（掉落 1）");
            }
            else
            {
                ImGui.Text("（掉落 " + asSource.Min.Value + " - " + asSource.Max.Value + ")");
            }
        }

        if (asSource.Probability != null)
        {
            ImGui.SameLine();
            ImGui.TextUnformatted($"{asSource.Probability.Value}%");
        }
    };

    public override Func<ItemSource, int> GetIcon => _ => Icons.GoldChest2;

    public override Func<ItemSource, string> GetName => _ => "";

    public override Func<ItemSource, string> GetDescription => source =>
    {
        var asSource = AsSource(source);
        return asSource.CofferType + " coffer";
    };
}

public class ItemPagosTreasureSourceRenderer : ItemFieldOpCofferSourceRenderer<ItemPagosTreasureCofferSource>
{
    public override IReadOnlyList<ItemInfoRenderCategory>? Categories { get; } =
        [ItemInfoRenderCategory.FieldOperation, ItemInfoRenderCategory.Pagos];

    public ItemPagosTreasureSourceRenderer(ItemSheet itemSheet, MapSheet mapSheet, ITextureProvider textureProvider, IDalamudPluginInterface pluginInterface) : base(itemSheet, mapSheet, textureProvider, pluginInterface, ItemInfoType.PagosTreasure)
    {
    }

    public override string SingularName => "优雷卡恒冰之地（宝箱）";
    public override string HelpText => "物品是否掉落自优雷卡恒冰之地宝箱";
}

public class ItemPyrosTreasureSourceRenderer : ItemFieldOpCofferSourceRenderer<ItemPyrosTreasureCofferSource>
{
    public override IReadOnlyList<ItemInfoRenderCategory>? Categories { get; } =
        [ItemInfoRenderCategory.FieldOperation, ItemInfoRenderCategory.Pyros];

    public ItemPyrosTreasureSourceRenderer(ItemSheet itemSheet, MapSheet mapSheet, ITextureProvider textureProvider, IDalamudPluginInterface pluginInterface) : base(itemSheet, mapSheet, textureProvider, pluginInterface, ItemInfoType.PyrosTreasure)
    {
    }

    public override string SingularName => "优雷卡涌火之地（宝箱）";
    public override string HelpText => "物品是否掉落自优雷卡涌火之地宝箱";
}

public class ItemHydatosTreasureSourceRenderer : ItemFieldOpCofferSourceRenderer<ItemHydatosTreasureCofferSource>
{
    public override IReadOnlyList<ItemInfoRenderCategory>? Categories { get; } =
        [ItemInfoRenderCategory.FieldOperation, ItemInfoRenderCategory.Hydatos];

    public ItemHydatosTreasureSourceRenderer(ItemSheet itemSheet, MapSheet mapSheet, ITextureProvider textureProvider, IDalamudPluginInterface pluginInterface) : base(itemSheet, mapSheet, textureProvider, pluginInterface, ItemInfoType.HydatosTreasure)
    {
    }

    public override string SingularName => "优雷卡丰水之地（宝箱）";
    public override string HelpText => "物品是否掉落自优雷卡丰水之地宝箱";
}

public class ItemOccultTreasureSourceRenderer : ItemFieldOpCofferSourceRenderer<ItemOccultTreasureCofferSource>
{
    public override IReadOnlyList<ItemInfoRenderCategory>? Categories { get; } =
        [ItemInfoRenderCategory.FieldOperation, ItemInfoRenderCategory.OccultCrescent];

    public ItemOccultTreasureSourceRenderer(ItemSheet itemSheet, MapSheet mapSheet, ITextureProvider textureProvider, IDalamudPluginInterface pluginInterface) : base(itemSheet, mapSheet, textureProvider, pluginInterface, ItemInfoType.OccultTreasure)
    {
    }

    public override string SingularName => "Occult Crescent－南角（宝箱）";
    public override string HelpText => "物品是否掉落自 Occult Crescent 南角的宝箱";
}

public class ItemOccultPotSourceRenderer : ItemFieldOpCofferSourceRenderer<ItemOccultPotSource>
{
    public override IReadOnlyList<ItemInfoRenderCategory>? Categories { get; } =
        [ItemInfoRenderCategory.FieldOperation, ItemInfoRenderCategory.OccultCrescent];

    public ItemOccultPotSourceRenderer(ItemSheet itemSheet, MapSheet mapSheet, ITextureProvider textureProvider, IDalamudPluginInterface pluginInterface) : base(itemSheet, mapSheet, textureProvider, pluginInterface, ItemInfoType.OccultPot)
    {
    }

    public override string SingularName => "Occult Crescent－南角（陶罐）";
    public override string HelpText => "物品是否掉落自 Occult Crescent 南角的陶罐";
}

public class ItemOccultGoldenCofferSourceRenderer : ItemFieldOpCofferSourceRenderer<ItemOccultGoldenCofferSource>
{
    public override IReadOnlyList<ItemInfoRenderCategory>? Categories { get; } =
        [ItemInfoRenderCategory.FieldOperation, ItemInfoRenderCategory.OccultCrescent];

    public ItemOccultGoldenCofferSourceRenderer(ItemSheet itemSheet, MapSheet mapSheet, ITextureProvider textureProvider, IDalamudPluginInterface pluginInterface) : base(itemSheet, mapSheet, textureProvider, pluginInterface, ItemInfoType.OccultGoldenCoffer)
    {
    }

    public override string SingularName => "Occult Crescent－南角（黄金宝箱）";
    public override string HelpText => "物品是否掉落自 Occult Crescent 南角的黄金宝箱";
}

public class ItemOccultNorthHornTreasureSourceRenderer : ItemFieldOpCofferSourceRenderer<ItemOccultNorthHornTreasureCofferSource>
{
    public override IReadOnlyList<ItemInfoRenderCategory>? Categories { get; } =
        [ItemInfoRenderCategory.FieldOperation, ItemInfoRenderCategory.OccultCrescent];

    public ItemOccultNorthHornTreasureSourceRenderer(ItemSheet itemSheet, MapSheet mapSheet, ITextureProvider textureProvider, IDalamudPluginInterface pluginInterface) : base(itemSheet, mapSheet, textureProvider, pluginInterface, ItemInfoType.OccultNorthHornTreasure)
    {
    }

    public override string SingularName => "Occult Crescent－北角（宝箱）";
    public override string HelpText => "物品是否掉落自 Occult Crescent 北角的宝箱";
}

public class ItemOccultNorthHornPotSourceRenderer : ItemFieldOpCofferSourceRenderer<ItemOccultNorthHornPotSource>
{
    public override IReadOnlyList<ItemInfoRenderCategory>? Categories { get; } =
        [ItemInfoRenderCategory.FieldOperation, ItemInfoRenderCategory.OccultCrescent];

    public ItemOccultNorthHornPotSourceRenderer(ItemSheet itemSheet, MapSheet mapSheet, ITextureProvider textureProvider, IDalamudPluginInterface pluginInterface) : base(itemSheet, mapSheet, textureProvider, pluginInterface, ItemInfoType.OccultNorthHornPot)
    {
    }

    public override string SingularName => "Occult Crescent－北角（陶罐）";
    public override string HelpText => "物品是否掉落自 Occult Crescent 北角的陶罐";
}

public class ItemOccultNorthHornGoldenCofferSourceRenderer : ItemFieldOpCofferSourceRenderer<ItemOccultNorthHornGoldenCofferSource>
{
    public override IReadOnlyList<ItemInfoRenderCategory>? Categories { get; } =
        [ItemInfoRenderCategory.FieldOperation, ItemInfoRenderCategory.OccultCrescent];

    public ItemOccultNorthHornGoldenCofferSourceRenderer(ItemSheet itemSheet, MapSheet mapSheet, ITextureProvider textureProvider, IDalamudPluginInterface pluginInterface) : base(itemSheet, mapSheet, textureProvider, pluginInterface, ItemInfoType.OccultNorthHornGoldenCoffer)
    {
    }

    public override string SingularName => "Occult Crescent－北角（黄金宝箱）";
    public override string HelpText => "物品是否掉落自 Occult Crescent 北角的黄金宝箱";
}