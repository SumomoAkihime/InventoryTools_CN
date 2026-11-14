$ErrorActionPreference = 'Stop'
$repoRoot = (Resolve-Path -LiteralPath (Join-Path $PSScriptRoot '..')).Path
$submoduleRoot = Join-Path $repoRoot 'CriticalCommonLib'
$patchPath = Join-Path $repoRoot 'patches/CriticalCommonLib-CN.patch'

& git -C $submoduleRoot apply --reverse --check $patchPath 2>$null
if ($LASTEXITCODE -eq 0) {
    Write-Host 'CriticalCommonLib 国服补丁已应用。'
    exit 0
}

& git -C $submoduleRoot apply --check $patchPath
if ($LASTEXITCODE -ne 0) {
    throw 'CriticalCommonLib 国服补丁与当前源码不匹配，请检查子模块版本和本地修改。'
}

& git -C $submoduleRoot apply $patchPath
if ($LASTEXITCODE -ne 0) {
    throw '应用 CriticalCommonLib 国服补丁失败。'
}
Write-Host 'CriticalCommonLib 国服补丁已应用。'
