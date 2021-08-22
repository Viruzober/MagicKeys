using System.Threading;
using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class RevealSoundSpire
{

public static void SpireLoader()
{
Thread.Sleep(300);
int[] Error = ImgSearchArea("SpireError", Coords.X, Coords.Y, Coords.X+Coords.W, Coords.Y+Coords.H, 0);
if (Error[0] == 1)
{
Speak("Spire error. Press Enter to rescan library from spire");
VUILoader("Error");
}
}

public static void FixError()
{
if (ImgSearchArea("SpireError", Coords.X, Coords.Y, Coords.X+Coords.W, Coords.Y+Coords.H, 0)[0] == 1)
{
MouseClick("Left", Coords.X+510, Coords.Y+340, 1, 0, 0, 10);
Thread.Sleep(100);
}
if (ImgSearchArea("Lib", Coords.X, Coords.Y, Coords.X+Coords.W, Coords.Y+Coords.H, 0)[0] == 1)
{
MouseClick("Left", Coords.X+325, Coords.Y+20, 1, 0, 0, 10);
Thread.Sleep(100);
}
if (ImgSearchArea("SpireError", Coords.X, Coords.Y, Coords.X+Coords.W, Coords.Y+Coords.H, 0)[0] == 1)
{
MouseClick("Left", Coords.X+510, Coords.Y+340, 1, 0, 0, 10);
Thread.Sleep(100);
}
MouseClick("Left", Coords.X+355, Coords.Y+510, 1, 0, 0, 10);
while(ImgSearchArea("Rescaning", Coords.X, Coords.Y, Coords.X+Coords.W, Coords.Y+Coords.H, 0)[0] == 0)
{
if(WinActive(API.GetWTitle(), API.GetWClass()) == false) return;
}
while(ImgSearchArea("Rescaning", Coords.X, Coords.Y, Coords.X+Coords.W, Coords.Y+Coords.H, 0)[0] == 1)
{
Speak("Rescaning");
Thread.Sleep(1000);
if(WinActive(API.GetWTitle(), API.GetWClass()) == false) return;
}
MouseClick("Left", Coords.X+325, Coords.Y+20, 1, 0, 0, 10);
VUILoader("Spire");
}

}
}