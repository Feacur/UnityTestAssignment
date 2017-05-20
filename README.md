# Summary
Test assignment on Unity, UI and programming stuff

Reference: WoT hangar scene

Up to the point it has been like 20 hours of pure busy time. Not bad, I believe. Besides this project turned out to be extremely instrumental for my current job. Really, you need sometimes sit back, put down your busy work for a while and do some R&D.

# How to work with this stuff
### Be sure you've built asset bundles before play mode
* See "Assets/Plugins/Custom/Editor/AssetBundlesBuilder.cs"
* See "Assets/Plugins/Custom/Editor/ProjectBuilder.cs"

### Build project using these custom scripts
### Probably you want to build asset bundles if you've updated Unity version
### Your changes won't automatically get into asset bundles in editor

# Current state
* Plugins: Rider, VSCode, YamlDotNet, also custom utilities
* Assets: Hangar UI, Hangar, tanks, prefabs, yaml configs
* Asset bundles: non-automatic, build required before play mode
* Build scripts: for asset bundles and for the project
* Data IO: load by url, load from asset bundles, persistent data
* One level deep nested prefabs emulation using scene files and actual prefabs
* Initial API commentaries

# To do
* Ability to purchase tanks
* Save user changes
* Sketch better tanks
* Sketch hangar scene
* Script fly around camera
* Loader splash screen to hide async loading from user
* Rective UI changes, probably?
