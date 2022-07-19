using System.Threading;
using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class Nexus
{

public static void NexusBankPage(string To)
{
if (To == "Back")
{
int[] FH = ImageSearchArea("FullHome", Coords.X+350, Coords.Y+50, Coords.X+460, Coords.Y+160, 20);
if (FH[0] == 1)
{
SoundPlay("End", false);
return;
}
SoundPlay("Scrol", false);
MouseClick("Left", Coords.X+400, Coords.Y+105, 1, 0, 0, 10);
MouseClick("Right", Coords.X+330, Coords.Y+230, 1, 0, 0, 10);
MenuItemClick("rename");
}
else if (To == "Next")
{
int[] FH = ImageSearchArea("FullEnd", Coords.X+350, Coords.Y+200, Coords.X+460, Coords.Y+260, 20);
if (FH[0] == 1)
{
SoundPlay("End", false);
return;
}
SoundPlay("Scrol", false);
MouseClick("Left", Coords.X+400, Coords.Y+220, 1, 0, 0, 10);
MouseClick("Right", Coords.X+330, Coords.Y+105, 1, 0, 0, 10);
MenuItemClick("rename");
}
Thread.Sleep(100);
string Bank = ControlGetText(API.GetWTitle(), API.GetWClass(), "Edit");
KeySend("Keys", "Enter", 50, 50);
MouseClick("Left", Coords.X+450, Coords.Y+105, 2, 0, 0, 10);
Speak(Bank);
}

}
}