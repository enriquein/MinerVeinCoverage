# MinerVeinCoverage

Dyson Sphere Program mod that adds the maximum mining speed in the Miner UI. It will add the text "(X / min)"
(where `X` is the maximum extraction rate for this miner) at the end of the "Cover X vein(s)" text.
See screenshots for a much better visual explanation. Since version 1.3 you can choose to display production as "per second".

The value takes into account all of your vein upgrades and also works when the miner is idle or even unpowered.

As of version 1.4, it also includes experimental support for the Advanced Mining Machine.

## Screenshots

Under normal operation (with 5 vein upgrades)

![Normal operation](https://raw.githubusercontent.com/enriquein/MinerVeinCoverage/main/screenshot1.png)

Idle miner because of full belt (with 5 vein upgrades as well)

![Miner idle](https://raw.githubusercontent.com/enriquein/MinerVeinCoverage/main/screenshot2.png)

Displaying production per second

![Per second](https://raw.githubusercontent.com/enriquein/MinerVeinCoverage/main/screenshot3.png)

## Installation

The easiest way to install the mod is to use the `r2modman` mod manager. If you havent installed it yet, you can get it from [here](https://dsp.thunderstore.io/package/ebkr/r2modman/). Then after you create your profile for Dyson Sphere Program, search for MinerVeinCoverage, select it and download it.

If prompted to download with dependencies, select `Yes`.

Remember to launch the game using the "Start modded" option in `r2modman`'s sidebar, otherwise it will not be able to load the mods.

### Manual installation

I have always used `r2modman` to mod games made with Unity, so the following manual instructions are based on what I've seen from other mods, so your mileage may vary. If you are doing manual installs, I assume you know what to do with this. Feel free to drop me a note or send a pull request with a fix to these instructions if I'm wrong.

+ Download the mod's zip file from the [mod's GitHub repo's](https://github.com/enriquein/MinerVeinCoverage) releases tab.
+ Install BepInEx from [here](https://dsp.thunderstore.io/package/xiaoye97/BepInEx/)
+ Install LDBTool from [here](https://dsp.thunderstore.io/package/xiaoye97/LDBTool/)
+ Create folder named `MinerVeinCoverage` in `Dyson Sphere Program/BepInEx/plugins`
+ Copy `MinerVeinCoverage.dll` from the mod's zip file into `Dyson Sphere Program/BepInEx/plugins/MinerVeinCoverage/`.

Hopefully that should work.

## Contact, feedback, comments, suggestions, bug reports

Please open an issue in the [mod's GitHub repository](https://github.com/enriquein/MinerVeinCoverage).

## Changes

### v1.4.3 (4/27/2024)

- Fix an error that was caused by changes in the game's internals.

### v1.4.2 (4/22/2023)

- Make "Cover X veins" text a bit more compact by removing the parenthesis in "vein(s)" (English translation only), and also removing the padding spaces between the amounts per time unit (meaning: show `200/min` instead of `200 / min`). I had originally placed the padding spaces for it to be consistent with other machines that display amount per time unit, but I think that given how the text can overlap the ore icon in the Advanced Mining Machine this is a good compromise.

- Removed the word "Cover" from the Advanced Mining Machine when ore is accumulating. This was done to work around the problem of the "Cover X veins" text overlapping the ore icon when it's being shown. If no ore is being accumulated then the entire text is shown as normal.

### v1.4.1 (4/22/2023)

- Fixed an issue with the Advanced Mining Machine where the amounts would only update when the speed was at 100%, 200%, and 300%.

### v1.4 (4/21/2023)

- Added experimental support for the Advanced Mining Machine. I'm aware that when ore is starting to accumulate in the internal storage
  of the miner, the "Coverage" text can overlap the ore icon. I'm not sure if I have enough Unity knowledge to fix that, sadly.

### v1.3 (11/30/2021)

- Added ability to configure displaying production as "per second". Remember that you need to run the game once after updating the mod
  to create the configuration file. Afterwards, you should be able to edit the configuration through `r2modman` or manually.
- The display value will no longer show insignificant zeroes in decimal places, and may now show up to two decimal places.
- Minor optimizations.

### v1.2 (11/27/2021)

- No functionality changed. Fixed README screenshot links so they could be displayed in the mod store page.

### v1.1 (11/27/2021)

- The mod will no longer try to add the text value to Water Extractors.
- Use the localized strings for the "Cover X vein(s)" text.

### v1.0 (11/25/2021)

- Initial release.