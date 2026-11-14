# Allagan Tools

用于《最终幻想 XIV》的 Dalamud 插件，提供库存追踪、物品搜索、制作规划与物品资料查询。本仓库维护国服适配和中文界面，插件名称为 Allagan Tools，内部名称为 InventoryTools。

[![原项目下载次数](https://img.shields.io/endpoint?url=https://qzysathwfhebdai6xgauhz4q7m0mzmrf.lambda-url.us-east-1.on.aws/InventoryTools)](https://github.com/Critical-Impact/InventoryTools)

## 主要功能

- 搜索角色、雇员、部队、住宅、陆行鸟鞍囊和投影台等已记录库存。
- 使用筛选器查找物品、规划整理位置，并在游戏内高亮相关物品。
- 创建制作清单，逐级拆解材料，核对已有库存及需要获取的数量。
- 查询商人、来源、用途、副本、怪物以及飞空艇和潜水艇资料。
- 显示 Universalis 市场价格及游戏内物品提示增强信息。

## 安装

在 Dalamud 的自定义插件仓库中添加下列地址，再搜索 Allagan Tools。

```text
https://raw.githubusercontent.com/SumomoAkihime/dalamud-plugin-repo/master/plugin-repo/repo.json
```

库存需要先在游戏中打开后才能被记录。雇员和部队仓库应分别打开需要记录的各页。

## 国服适配

本分支修复 CriticalCommonLib 的国服库存扫描特征码，并中文化插件界面、设置和说明。配置键、IPC 名称及既有导出字段保持兼容。

国服补丁与验证范围记录在 [适配说明](patches/README.txt) 中。部分缺少国服译名依据的专名保留原文。

## 构建

使用 .NET 10 和对应的 Dalamud API 15 开发库。初始化仓库指定的子模块并应用国服补丁后进行构建。

```powershell
git submodule update --init --recursive
./tools/Apply-CNPatches.ps1
dotnet build ./InventoryTools/InventoryTools.csproj -c Release
```

本机存在国服开发库时默认读取 `XIVLauncherCN/addon/Hooks/dev`，可通过 `DALAMUD_HOME` 指定其他开发库目录。

## 支持与贡献

国服适配相关问题请在本仓库反馈，并附插件版本、游戏版本和复现步骤。原项目也提供 Issue 和 goatplace Discord 支持。

欢迎贡献。提交代码前请先通过 Issue 讨论，确认实现范围和方式。

## 作者与许可

原作者为 Critical_Impact，国服适配与中文界面由 Sumomo 维护。许可证见 [LICENSE](LICENSE)。
