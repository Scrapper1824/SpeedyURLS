# SpeedyURLs for Resonite Mod Loader

SpeedyURLs removes the five-second cooldown from Resonite URL consent popups. This is a port for **Resonite Mod Loader (RML)** and does not target BepisLoader/BepInEx.

## What it does

The plugin patches `UIExtensions.EnableTimeout` and sets its timeout argument to zero. This removes the delay before you can respond to a URL consent popup; it does not bypass the consent popup itself.

## Requirements

- Resonite
- Resonite Mod Loader installed and enabled
- .NET 10 SDK to build from source
- The Resonite game files available at the default Steam path, or a custom path supplied as shown below

## Build

From this folder, run:

```powershell
dotnet build -c Release
```

By default, the project looks for Resonite at:

```text
C:\Program Files (x86)\Steam\steamapps\common\Resonite
```

For a different install location, pass `GameDir`:

```powershell
dotnet build -c Release -p:GameDir="D:\Games\Resonite"
```

The compiled plugin is created at `bin/Release/net10.0/SpeedyURLs.dll`.

## Install

Copy `SpeedyURLs.dll` into Resonite's `rml_mods` folder, then start Resonite with RML enabled. The mod depends on RML and the Resonite assemblies provided by the game; do not copy those dependencies next to the plugin.

## Put this folder on GitHub with GitHub Desktop

1. Open GitHub Desktop and choose **File → Add Local Repository**.
2. Select this project folder: `C:\Users\jacob\Downloads\Projects\SpeedyURLS`.
3. If GitHub Desktop says the folder is not a Git repository, choose its option to create a repository in this folder.
4. Review the files in the Changes tab, enter a summary such as `Prepare SpeedyURLs RML port`, and commit to the local `main` branch.
5. Choose **Publish repository** to create the GitHub repository. Select public or private as you prefer.

The `.gitignore` excludes build output and common IDE files, so `bin` and `obj` will not be committed.

## Attribution

This project ports the SpeedyURLs behavior by [LeCloutPanda](https://github.com/LeCloutPanda/SpeedyURLs) and [dfgHiatus](https://github.com/LeCloutPanda/SpeedyURLs). The original mod description is “Remove the 5-second cool-down on url consent popups.” This RML port was reconstructed from the published v2.1.0 decompiled source because the upstream source checkout was unavailable in this workspace.

## AI assistance disclaimer

This RML port and this README were prepared with assistance from OpenAI Codex. The code was compiled successfully, but it has not been runtime-tested in Resonite. AI assistance does not imply endorsement by the original authors, Resonite, or the Resonite Mod Loader maintainers. Please review the changes before publishing or distributing them.

## License

This project is licensed under the MIT License. See [LICENSE](LICENSE). The upstream copyright notice is retained; this RML port was prepared with AI assistance.
