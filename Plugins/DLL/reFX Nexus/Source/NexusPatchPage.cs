using System.Threading;
using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class Nexus
{

public static void NexusPatchPage(string To)
{
if (To == "Back")
{
int[] FH = ImgSearchArea("FullHome", Coords.X+540, Coords.Y+50, Coords.X+590, Coords.Y+160, 20);
if (FH[0] == 1)
{
SoundPlay("End", false);
return;
}
SoundPlay("Scrol", false);
MouseClick("Left", Coords.X+575, Coords.Y+120, 1, 0, 0, 10);
MouseClick("Right", Coords.X+450, Coords.Y+230, 1, 0, 0, 10);
MenuItemClick("rename");
Thread.Sleep(100);
string Patch = ControlGetText(API.GetWTitle(), API.GetWClass(), "Edit");
KeySend("Keys", "Enter", 50, 50);
MouseClick("Left", Coords.X+450, Coords.Y+230, 2, 0, 0, 10);
Speak(Patch);
}
else if (To == "Next")
{
int[] FH = ImgSearchArea("FullEnd", Coords.X+540, Coords.Y+180, Coords.X+590, Coords.Y+280, 20);
if (FH[0] == 1)
{
SoundPlay("End", false);
return;
}
SoundPlay("Scrol", false);
MouseClick("Left", Coords.X+575, Coords.Y+220, 1, 0, 0, 10);
MouseClick("Right", Coords.X+450, Coords.Y+105, 1, 0, 0, 10);
MenuItemClick("rename");
Thread.Sleep(100);
string Patch = ControlGetText(API.GetWTitle(), API.GetWClass(), "Edit");
KeySend("Keys", "Enter", 50, 50);
MouseClick("Left", Coords.X+450, Coords.Y+105, 2, 0, 0, 10);
Speak(Patch);
}
}

}
}