using System.Threading;
using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class RevealSoundSpire
{

public static void LibraryLoader()
{
if (ImgSearch("Lib", true)[0] == 0)
{
MouseClick("Left", Coords.X+210, Coords.Y+20, 1, 0, 0, 10);
}
else
{
MouseClick("Left", Coords.X+325, Coords.Y+20, 1, 0, 0, 10);
}
Thread.Sleep(300);
int[] Error = ImgSearchArea("SpireError", Coords.X, Coords.Y, Coords.X+Coords.W, Coords.Y+Coords.H, 0);
if (Error[0] == 1)
{
Speak("Spire error. Press Enter to rescan library from spire");
VUILoader("Error");
return;
}
MouseClick("Left", Coords.X+200, Coords.Y+85, 1, 0, 0, 10);
}

}
}