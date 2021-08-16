using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class Nexus
{

public static void MasterFilterOnOff()
{
MouseClick("Left", Coords.X+70, Coords.Y+365, 1, 0, 0, 10);
CheckBox(Coords.X+70, Coords.Y+345, "#3AA1FF", "MasterFilter");
}

public static void MasterFilterCutOff()
{
Slider("CutOff", 125, 350, "V", 1.38, 1.6);
}

public static void MasterFilterRes()
{
Slider("Res", 185, 350, "V", 1.38, 1.6);
}

public static void MasterFilterType()
{
MouseClick("Left", Coords.X+70, Coords.Y+420, 1, 0, 0, 10);
if (PixelSearch(Coords.X+90, Coords.Y+400, "#3AA1FF") == true)
{
Speak("Lp");
}

if (PixelSearch(Coords.X+90, Coords.Y+410, "#3AA1FF") == true)
{
Speak("Hp");
}

if (PixelSearch(Coords.X+90, Coords.Y+425, "#3AA1FF") == true)
{
Speak("Bp");
}

if (PixelSearch(Coords.X+90, Coords.Y+440, "#3AA1FF") == true)
{
Speak("Ntch");
}
}

public static void MasterFilterSlope()
{
MouseClick("Left", Coords.X+145, Coords.Y+420, 1, 0, 0, 10);
if (PixelSearch(Coords.X+165, Coords.Y+410, "#3AA1FF") == true)
{
Speak("6");
}

if (PixelSearch(Coords.X+165, Coords.Y+420, "#3AA1FF") == true)
{
Speak("12");
}

if (PixelSearch(Coords.X+165, Coords.Y+430, "#3AA1FF") == true)
{
Speak("24");
}
}

}
}