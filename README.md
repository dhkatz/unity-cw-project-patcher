<div align="center">
  <h1>Content Warning Project Patcher</h1>

  <img src="Assets~/header.png"  alt="Content Warning Branding Image" height="150" />

  <p>
    A game wrapper that generates a Unity project from Content Warning's build that can be playable in-editor.
  </p>
</div>

<br />

<!-- Table of Contents -->
# Table of Contents

- [About the Project](#about-the-project)
- [Getting Started](#getting-started)
    * [Prerequisites](#prerequisites)
    * [Installation](#installation)
- [Usage](#usage)
- [FAQ](#faq)

<!-- About the Project -->
## About the Project
This tool is a game wrapper on top of the [Unity Project Patcher](https://github.com/nomnomab/unity-project-patcher).

This takes a build of Content Warning, extracts its assets/scripts/etc, and then generates a project for usage in the Unity editor.

> [!IMPORTANT]  
> This tool does not distribute game files. It simply works off of your copy of the game!
>
> Also, this tool is for **personal** use only. Do not re-distribute game files to others.

<!-- Getting Started -->
## Getting Started

<!-- Prerequisites -->
### Prerequisites

You will have to make sure you have the following before using the tool in any way:

- [Git](https://git-scm.com/download/win)
- [.NET 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
    - To run Asset Ripper
- [Unity Project Patcher](https://github.com/nomnomab/unity-project-patcher)
- [Unity Project Patcher BepInEx](https://github.com/nomnomab/unity-project-patcher-bepinex)
  - [Can be disabled](#disabling-bepinex-usage)

<!-- Installation -->
## Installation

### Unity Project

- Requires [Unity 2022.3.47f1](https://unity.com/releases/editor/whats-new/2022.3.47)
- Unity URP pipeline (Universal 3D)

Create a new Unity project with the above requirements before getting started.

> [!IMPORTANT]  
> These options require [git](https://git-scm.com/download/win) to be installed!

### Installing the Unity Project Patcher core

Install with the package manager:

1. Open the Package Manager from `Window > Package Manager`
2. Click the '+' button in the top-left of the window
3. Click 'Add package from git URL'
4. Provide the URL of the this git repository: `https://github.com/nomnomab/unity-project-patcher.git`
    - If you are using a specific version, you can append it to the end of the git URL, such as `#v1.2.3`
5. Click the 'add' button

Install with the manifest.json:

1. Open the manifest at `[PROJECT_NAME]\Packages\manifest.json`
2. Insert the following as an entry:

```json
"com.nomnom.unity-project-patcher": "https://github.com/nomnomab/unity-project-patcher.git"
```

- If you are using a specific version, you can append it to the end of the git URL, such as `#v1.2.3`

### Installing this Game Wrapper

The same steps as previously, just with `https://github.com/dhkatz/unity-cw-project-patcher.git`

### Installing the BepInEx Wrapper

Open the tool window `Tools > Unity Project Patcher > Open Window` and press the `Install BepInEx` button.

Otherwise, follow the steps at https://github.com/nomnomab/unity-project-patcher-bepinex

#### Disabling BepInEx Usage

If you don't want to use plugins, then follow the steps at https://github.com/nomnomab/unity-project-patcher-bepinex#disabling-this-package

<!-- Usage -->
## Usage

The tool window can be opened via `Tools > Unity Project Patcher > Open Window`

> [!IMPORTANT]  
> This tool mostly supports patching an already patched project, although this can lead to broken assets.
> So make sure you back up your project beforehand.

Estimated patch durations:

- Fresh patch: 5 - 10 minutes
- Already patched: 8 - 15 minutes

These can vary wildly depending on system speed and project size.

> [!IMPORTANT]  
> In the URP wizard it may say that the Quality asset isn't assigned. It is lying, just ignore it.

## FAQ

The core project's FAQ can be found here: https://github.com/nomnomab/unity-project-patcher#faq

#### Q: The patcher keeps crashing due to texture/GPU/driver issues.

Try switching to DX11 with these steps: https://docs.unity3d.com/Manual/UsingDX11GL3Features.html
