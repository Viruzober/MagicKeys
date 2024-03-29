using System.Threading;
using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class Nexus
{

public static void NexusPatch(string To)
{
if (To == "Back")
{
int[] NXUP = ImageSearchArea("NexusUp", Coords.X+450, Coords.Y+70, Coords.X+480, Coords.Y+150, 40);
if (NXUP[0] == 1)
{
NexusPatchPage("Back");
return;
}
else if (NXUP[0] == 0)
{
int[] NXBP = ImageSearchArea("NexusBP", Coords.X+400, Coords.Y+90, Coords.X+430, Coords.Y+270, 40);
if (NXBP[0] == 1)
{
MouseClick("Right", NXBP[1]+15, NXBP[2]-5, 1, 0, 0, 10);
MenuItemClick("rename");
Thread.Sleep(100);
string Patch = ControlGetText(API.GetWTitle(), API.GetWClass(), "Edit");
KeySend("Keys", "Enter", 50, 50);
MouseClick("Left", NXBP[1]+15, NXBP[2]-5, 2, 0, 0, 10);
Speak(Patch);
}
}
}
else if (To == "Next")
{
int[] NXDW = ImageSearchArea("NexusDown", Coords.X+530, Coords.Y+220, Coords.X+570, Coords.Y+260, 40);
if (NXDW[0] == 1)
{
NexusPatchPage("Next");
return;
}
else if (NXDW[0] == 0)
{
int[] NXBP = ImageSearchArea("NexusBP", Coords.X+400, Coords.Y+90, Coords.X+430, Coords.Y+270, 40);
if (NXBP[0] == 1)
{
int[] NXEND = ImageSearchArea("NexusEnd", NXBP[5], NXBP[6], NXBP[5]+15, NXBP[6]+25, 20);
if (NXEND[0] == 1)
{
SoundPlay("End", false);
}
else if (NXEND[0] == 0)
{
MouseClick("Right", NXBP[1]+15, NXBP[2]+15, 1, 0, 0, 10);
MenuItemClick("rename");
Thread.Sleep(100);
string Patch = ControlGetText(API.GetWTitle(), API.GetWClass(), "Edit");
KeySend("Keys", "Enter", 50, 50);
MouseClick("Left", NXBP[1]+15, NXBP[2]+15, 2, 0, 0, 10);
Speak(Patch);
}
}
}
}
}

}
}