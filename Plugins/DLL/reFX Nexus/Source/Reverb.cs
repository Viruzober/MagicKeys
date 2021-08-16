using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class Nexus
{

public static void ReverbOnOff()
{
MouseClick("Left", Coords.X+480, Coords.Y+365, 1, 0, 0, 10);
CheckBox(Coords.X+480, Coords.Y+345, "#3AA1FF", "Reverb");
}

public static void ReverbType()
{
MouseClick("Left", Coords.X+500, Coords.Y+365, 1, 0, 0, 10);
if (PixelSearch(Coords.X+520, Coords.Y+345, "#3AA1FF") == true)
{
Speak("Room");
}

if (PixelSearch(Coords.X+520, Coords.Y+360, "#3AA1FF") == true)
{
Speak("Hall");
}

if (PixelSearch(Coords.X+520, Coords.Y+375, "#3AA1FF") == true)
{
Speak("Arena");
}
}

public static void ReverbMix()
{
Slider("Mix", 595, 355, "V", 1.38, 1.6);
}

public static void ReverbMod()
{
Slider("Mod", 655, 355, "V", 1.38, 1.6);
}

public static void ReverbDec()
{
Slider("Dec", 540, 415, "V", 1.38, 1.6);
}

public static void ReverbPreDelay()
{
Slider("PreDelay", 480, 415, "V", 1.38, 1.6);
}

public static void ReverbLoCut()
{
Slider("LoCut", 595, 415, "V", 1.38, 1.6);
}

public static void ReverbHiCut()
{
Slider("HiCut", 655, 415, "V", 1.38, 1.6);
}

}
}