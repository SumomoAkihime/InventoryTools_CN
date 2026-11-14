InventoryTools 国服适配记录
更新日期 2026-11-14

适用源码
主仓库基线 ad1ff01（15.1.1）
CriticalCommonLib 基线 420f6880b16497a6d6356f6dbeda963364e4d5ef
OtterGui 基线 79771ee5f3d463f02c63bebbedaa0aff49e59718
现有 Dalamud SDK 15、.NET 10 及原有包依赖继续使用。

本轮修改
插件显示名称 Allagan Tools、内部名称和程序集 InventoryTools 保持原值。
中文化设置、窗口、图鉴、筛选器、物品提示、向导、命令帮助及相关调试界面。
物品、NPC、地图等游戏名称继续由现有游戏数据读取流程提供。
部分缺少国服译名证据的专名保留原文，阶段标签增加中文说明。
保留配置键、枚举存储值、IPC 名称、游戏 Addon 名称和缓存格式。
默认 CSV/JSON 导出列名保留英文原值，Teamcraft 文本头保留原值。
图鉴命令同时接受中文显示名称、原英文单复数名称和稳定 Key。
窗口标题通过 ### 保留原始 ImGui 标识，用户自定义名称继续按原配置使用。
本机存在国服开发库时默认使用 XIVLauncherCN/addon/Hooks/dev。
显式设置的 DALAMUD_HOME 优先生效。

国服库存扫描修复
仅替换 InventoryScanner._containerInfoNetworkHook 上方的特征码。
保留 DetourName、UseFlags、委托、回调、网络解码和已加载库存门控。
国服候选的重复调用片段为 48 8B D7 8B CE。

本轮只读定位证据
游戏版本 2026.10.06.0000.0000。
游戏程序 SHA256 958B78E278AD896493C484EB313FF605AB41EDEFEF74F92B0EE078E69B281BF9。
原特征码匹配 0 次，国服候选匹配 1 次。
匹配 RVA 0x018D8C48，E8 调用目标 RVA 0x00B4A390。
目标入口使用 ECX 序列参数和 RDX 原数据包指针，处理逻辑从数据包 +0x10 读取有效载荷。
现有解码器依次读取四个 UInt32，源码修改保留此流程。

资料包既有证据
InventoryTools-CN-适配资料-20261114 记录了 2026.11.03.0000.0000 的唯一匹配和函数语义核对。
该记录属于此前的参考 DLL 验证，本轮未对该版本游戏文件重新定位。
本轮核对资料包内 16 个文件的长度和 SHA256，均与清单一致。

子模块补丁
CriticalCommonLib-CN.patch 包含库存扫描修复及该子模块中的显示文字中文化。
本工作树已应用这些修改，补丁用于在指定基线重新拉取后恢复。
在主仓库根目录，可先初始化指定版本子模块，再检查和应用补丁。

  git submodule update --init --recursive
  git -C CriticalCommonLib apply --check ../patches/CriticalCommonLib-CN.patch
  git -C CriticalCommonLib apply ../patches/CriticalCommonLib-CN.patch

升级基线时逐项核对补丁与当次游戏文件。
子模块内的修改与主仓库分别保存；本轮保留本地修改及补丁文件。

验证边界
本轮执行编码、换行、C# 语法、稳定字段、导出列名及补丁重放等静态检查。
651 个源码文件通过 UTF-8、BOM 与换行检查，C# 语法错误为 0。
383 个配置 Key、GenericKey、版本及相关稳定属性与基线一致。
子模块补丁在基线副本中通过正向检查、重放内容比较和反向检查。
源码修改阶段仅执行静态检查。后续发布阶段已还原既有依赖并通过 Release 构建。
发布版本为 1.15.1.101，作者署名为 Critical_Impact&Sumomo。
首次构建发现 CraftSettingsColumn 的导出兼容属性误用 override，已修正并重新构建通过。
已核对包内清单、程序集身份与库存钩子属性；游戏内加载及分页取放验收仍待执行。

待执行的验收
1. 使用对应国服 Dalamud API 15 开发库完成构建，核对主插件与依赖程序集身份。
2. 加载后检查当前加载周期内的扫描钩子告警与异常。
3. 分别打开雇员背包和部队仓库各页，核对首次采集。
4. 分别取放物品，核对数量实时更新、关闭重开及重新登录后的表现。
5. 检查中文字体、截断、窗口布局、搜索、筛选、物品提示和向导。
6. 核对已有配置、旧英文图鉴命令参数、CSV/JSON 和 Teamcraft 导入导出。

