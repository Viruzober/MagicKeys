using System;
using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;
namespace MagicKeys
{
public partial class Nexus
{
public static void NexusBankPage(string To)
{
if (To == "Back")
{
int[] FH = ImgSearchArea("FullHome", P[1]+350, P[2]+50, P[1]+460, P[2]+160, 20);
if (FH[0] == 1)
{
SoundPlay("End", 0);
return;
}
SoundPlay("Scrol", 0);
MouseClick("Left", P[1]+400, P[2]+105, 1, 0, 0, 10);
MenuItemClick("Right", P[1]+330, P[2]+230, "rename");
}
else if (To == "Next")
{
int[] FH = ImgSearchArea("FullEnd", P[1]+350, P[2]+200, P[1]+460, P[2]+260, 20);
if (FH[0] == 1)
{
SoundPlay("End", 0);
return;
}
SoundPlay("Scrol", 0);
MouseClick("Left", P[1]+400, P[2]+220, 1, 0, 0, 10);
MenuItemClick("Right", P[1]+330, P[2]+105, "rename");
}
Thread.Sleep(100);
string Bank = ControlGetText(API.GetWTitle(), API.GetWClass(), "Edit");
KeySend("Keys", "Enter", 50, 50);
MouseClick("Left", P[1]+450, P[2]+105, 2, 0, 0, 10);
Speak(Bank);
}
}
}