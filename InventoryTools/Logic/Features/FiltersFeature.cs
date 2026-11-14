using System.Collections.Generic;
using System.Linq;
using InventoryTools.Logic.Settings;
using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Ui.Config;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Logic.Features;

public class FiltersFeature : Feature
{
    public FiltersFeature(IEnumerable<ISetting> settings) : base(settings)
    {
    }

    public override PageLayout Build()
    {
        return Page("feature/sample-lists", "示例列表",
            Paragraph("这些示例展示插件的功能，选中后将在完成向导时安装。"),
            Setting<SampleFilter100GillOrLess>("Items worth 100 gil or less"),
            Setting<SampleFilterDuplicateItems>("Duplicate items in your inventory"),
            Setting<SampleFilterMaterialCleanup>("Crafting materials to move to storage")
        );
    }

    public override void OnFinish()
    {
        foreach (var setting in RelatedSettings.Select(c => c as ISampleFilter))
        {
            if (setting is { ShouldAdd: true })
            {
                setting.AddFilter();
            }
        }
    }
}