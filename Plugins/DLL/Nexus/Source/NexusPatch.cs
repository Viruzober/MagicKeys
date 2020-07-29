using System;
using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Nexus
{

public static void NexusPatch(string To)
{
if (To == "Back")
{
int[] NXUP = ImgSearchArea("NexusUp", P[1]+450, P[2]+70, P[1]+480, P[2]+150, 40);
if (NXUP[0] == 1)
{
NexusPatchPage("Back");
return;
}
else if (NXUP[0] == 0)
{
int[] NXBP = ImgSearchArea("NexusBP", P[1]+400, P[2]+90, P[1]+430, P[2]+270, 40);
if (NXBP[0] == 1)
{
MouseClick("Right", NXBP[1]+15, NXBP[2]-5, 1, 0, 0, 10);
Thread.Sleep(100);
IntPtr HWND = WinExistsHandle("", "#32768");
IntPtr HMenu = SendMessage(HWND, 0x01E1, 0, IntPtr.Zero);
int[] MRect = GetMIRect(HWND, HMenu, 1);
MouseClick("Left", MRect[0]+15,MRect[1]+15, 1, 0, 0, 10);
Thread.Sleep(100);
string Patch = ControlGetText(API.GetWTitle(), API.GetWClass(), "Edit");
Keyboard.KeyDown(Keys.Enter);
Keyboard.KeyUp(Keys.Enter);
MouseClick("Left", P[1]+50, P[2]+50, 1, 0, 0, 10);
MouseClick("Left", NXBP[1]+15, NXBP[2]-5, 2, 0, 0, 10);
Speak(Patch);
}
}
}
else if (To == "Next")
{
int[] NXDW = ImgSearchArea("NexusDown", P[1]+530, P[2]+220, P[1]+570, P[2]+260, 40);
if (NXDW[0] == 1)
{
NexusPatchPage("Next");
return;
}
else if (NXDW[0] == 0)
{
int[] NXBP = ImgSearchArea("NexusBP", P[1]+400, P[2]+90, P[1]+430, P[2]+270, 40);
if (NXBP[0] == 1)
{
int[] NXEND = ImgSearchArea("NexusEnd", NXBP[5], NXBP[6], NXBP[5]+15, NXBP[6]+25, 20);
if (NXEND[0] == 1)
{
SoundPlay("End.ogg", 0);
}
else if (NXEND[0] == 0)
{
MouseClick("Right", NXBP[1]+15, NXBP[2]+15, 1, 0, 0, 10);
Thread.Sleep(100);
IntPtr HWND = WinExistsHandle("", "#32768");
IntPtr HMenu = SendMessage(HWND, 0x01E1, 0, IntPtr.Zero);
int[] MRect = GetMIRect(HWND, HMenu, 1);
MouseClick("Left", MRect[0]+15, MRect[1]+15, 1, 0, 0, 10);
Thread.Sleep(100);
string Patch = ControlGetText(API.GetWTitle(), API.GetWClass(), "Edit");
Keyboard.KeyDown(Keys.Enter);
Keyboard.KeyUp(Keys.Enter);
MouseClick("Left", P[1]+50, P[2]+50, 1, 0, 0, 10);
MouseClick("Left", NXBP[1]+15, NXBP[2]+15, 2, 0, 0, 10);
Speak(Patch);
}
}
}
}
}

}
}