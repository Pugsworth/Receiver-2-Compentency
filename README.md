# About
This mod does one thing, it removes the accidental firearm discharge chance when holstering and unholstering the weapon.  
While the mechanic is authentic to firearm handling, I find it boring as a game mechanic.
There's no skill involved.  
It's just a reminder that you didn't hold <Tab> long enough...

As a side effect to how I disabled this, it also stops all accidental discharges.  

This could be fixed, but I don't care for the mechanic all together.  


# Building
You are required to copy the `Wolfire.Receiver2.dll` file from the game into the root directory to be able to build this.  
After that has been placed, you can issue a `dotnet restore`, followed by a `dotnet build`.  
When the build completes, you will have a `IKnowHowToHolsterAGun.dll` in the `bin/<Debug|Release>/<TFM>/` directory.  
Place this into the `bepinex/plugins/` directory and you're good to go!  


# Dependencies
- `Wolfire.Receiver2.dll` from the game
- BepInEx
- .Net >= 4.6 (If you can play the game, this should already work)
