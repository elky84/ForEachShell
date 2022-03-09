[![Website](https://img.shields.io/website-up-down-green-red/http/shields.io.svg?label=elky-essay)](https://elky84.github.io)
![Made with](https://img.shields.io/badge/made%20with-.NET6-blue.svg)

[![Publish Nuget Package](https://github.com/elky84/ForEachShell/actions/workflows/publish_nuget.yml/badge.svg)](https://github.com/elky84/ForEachShell/actions/workflows/publish_nuget.yml)
[![Publish Nuget Github Package](https://github.com/elky84/ForEachShell/actions/workflows/publish_github.yml/badge.svg)](https://github.com/elky84/ForEachShell/actions/workflows/publish_github.yml)
ForEachShell
![GitHub forks](https://img.shields.io/github/forks/elky84/.svg?style=social&label=Fork)
![GitHub stars](https://img.shields.io/github/stars/elky84/ForEachShell.svg?style=social&label=Stars)
![GitHub watchers](https://img.shields.io/github/watchers/elky84/ForEachShell.svg?style=social&label=Watch)
![GitHub followers](https://img.shields.io/github/followers/elky84.svg?style=social&label=Follow)

![GitHub](https://img.shields.io/github/license/mashape/apistatus.svg)
![GitHub repo size in bytes](https://img.shields.io/github/repo-size/elky84/ForEachShell.svg)
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/elky84/ForEachShell.svg)

# ForEachShell

Extend CLI execute utility.

[Github](http://github.com/elky84/ForEachShell)

## install cli global tool

require dotnet 6 (LTS) or later (<https://dotnet.microsoft.com/en-us/download>)

`dotnet tool install -g ForEachShell`

### must use input directory & output directory option.
`ForEachShell -i {input directory} -o {output directory}`

## all options
- <https://github.com/elky84/ForEachShell/blob/main/Options.cs>

## shell execute example
--input {base directory} --command h2m --argument "\-f index.html > index.md"

* Strings containing spaces must be enclosed in double quotation (") marks.
* If a - (hyphen) is required, it must be preceded by a \ (slash).

## version history

### v1.0.1

Supports OS other than Windows.