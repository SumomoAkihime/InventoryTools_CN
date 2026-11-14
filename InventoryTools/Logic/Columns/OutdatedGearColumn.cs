using System.Collections.Generic;
using System.Linq;
using InventoryTools.Logic.Columns.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Columns;

public class OutdatedGearColumn : CheckboxColumn
{
    private readonly IGameInteropService _gameInteropService;
    private Dictionary<uint, short>? _jobClassLevels = null;

    public OutdatedGearColumn(ILogger<OutdatedGearColumn> logger, ImGuiService imGuiService, IGameInteropService gameInteropService) : base(logger, imGuiService)
    {
        _gameInteropService = gameInteropService;
    }

    public override string Name { get; set; } = "是否为过时装备";
    [Newtonsoft.Json.JsonIgnore]
    public override string ExportName => "Outdated Gear?";
    public override float Width { get; set; } = 50;
    public override string HelpText { get; set; } = "显示被视为过时的装备。将物品品级与可使用该装备的已解锁职业中的最低等级比较，判断是否过时。";
    public override ColumnCategory ColumnCategory { get; } = ColumnCategory.Tools;
    public override bool HasFilter { get; set; } = true;
    public override ColumnFilterType FilterType { get; set; } = ColumnFilterType.Boolean;

    private Dictionary<uint, short> GetClassJobLevels()
    {
        if (_jobClassLevels == null)
        {
            _jobClassLevels = _gameInteropService.GetClassJobLevels()?.ToDictionary(c => c.Key.RowId, c=> c.Value) ?? new();
        }

        return _jobClassLevels;
    }


    public override bool? CurrentValue(ColumnConfiguration columnConfiguration, SearchResult searchResult)
    {
        var item = searchResult.Item;
        var isOutdated = false;
        var jobClassLevels = GetClassJobLevels();

        if (item.ClassJobCategory != null)
        {
            int? lowestJobLevel = null;

            foreach (var job in item.ClassJobCategory.ClassJobIds)
            {
                if (jobClassLevels.TryGetValue(job, out var jobLevel))
                {
                    if (lowestJobLevel == null || lowestJobLevel > jobLevel)
                    {
                        lowestJobLevel = jobLevel;
                    }
                }
            }

            if (lowestJobLevel != null && lowestJobLevel > item.Base.LevelEquip)
            {
                isOutdated = true;
            }
        }
        else
        {
            return false;
        }

        return isOutdated;
    }

    public override void InvalidateSearchCache()
    {
        this._jobClassLevels = null;
    }
}