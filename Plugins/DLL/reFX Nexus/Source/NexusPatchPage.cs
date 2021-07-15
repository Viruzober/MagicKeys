using System;
using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Nexus
{

public static void NexusPatchPage(string To)
{
if (To == "Back")
{
int[] FH = ImgSearchArea("FullHome", P[1]+540, P[2]+50, P[1]+590, P[2]+160, 20);
if (FH[0] == 1)
{
SoundPlay("End", 0);
return;
}
SoundPlay("Scrol", 0);
MouseClick("Left", P[1]+575, P[2]+120, 1, 0, 0, 10);
MenuItemClick("Right", P[1]+450, P[2]+230, "rename");
Thread.Sleep(100);
string Patch = ControlGetText(API.GetWTitle(), API.GetWClass(), "Edit");
KeySend("Keys", "Enter", 50, 50);
MouseClick("Left", P[1]+450, P[2]+230, 2, 0, 0, 10);
Speak(Patch);
}
else if (To == "Next")
{
int[] FH = ImgSearchArea("FullEnd", P[1]+540, P[2]+180, P[1]+590, P[2]+280, 20);
if (FH[0] == 1)
{
SoundPlay("End", 0);
return;
}
SoundPlay("Scrol", 0);
MouseClick("Left", P[1]+575, P[2]+220, 1, 0, 0, 10);
MenuItemClick("Right", P[1]+450, P[2]+105, "rename");
Thread.Sleep(100);
string Patch = ControlGetText(API.GetWTitle(), API.GetWClass(), "Edit");
KeySend("Keys", "Enter", 50, 50);
MouseClick("Left", P[1]+450, P[2]+105, 2, 0, 0, 10);
Speak(Patch);
}
}

}
}