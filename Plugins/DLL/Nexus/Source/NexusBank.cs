using System;
using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Nexus
{

public static void NexusBank(string To)
{
if (To == "Back")
{
int[] NXUP = ImgSearchArea("NexusUp", P[1]+330, P[2]+70, P[1]+350, P[2]+130, 40);
if (NXUP[0] == 1)
{
NexusBankPage("Back");
return;
}
else if (NXUP[0] == 0)
{
int[] NXBP = ImgSearchArea("NexusBP", P[1]+260, P[2]+90, P[1]+280, P[2]+270, 20);
if (NXBP[0] == 1)
{
MouseClick("Left", NXBP[1]+15, NXBP[2]-5, 1, 0, 0, 10);
MouseClick("Right", NXBP[1]+15, NXBP[2]-5, 1, 0, 0, 10);
Thread.Sleep(200);
IntPtr HWND = WinExistsHandle("", "#32768");
IntPtr HMenu = SendMessage(HWND, 0x01E1, 0, IntPtr.Zero);
int[] MRect = GetMIRect(HWND, HMenu, 1);
MouseClick("Left", MRect[0]+15,MRect[1]+15, 1, 0, 0, 50);
Thread.Sleep(100);
string Bank = ControlGetText(API.GetWTitle(), API.GetWClass(), "Edit");
Keyboard.KeyDown(Keys.Enter);
Keyboard.KeyUp(Keys.Enter);
MouseClick("Left", P[1]+450, P[2]+105, 2, 0, 0, 50);
Speak(Bank);
}
}
}
else if (To == "Next")
{
int[] NXDW = ImgSearchArea("NexusDown", P[1]+300, P[2]+220, P[1]+330, P[2]+250, 40);
if (NXDW[0] == 1)
{
NexusBankPage("Next");
return;
}
else if (NXDW[0] == 0)
{
int[] NXBP = ImgSearchArea("NexusBP", P[1]+260, P[2]+90, P[1]+280, P[2]+270, 20);
if (NXBP[0] == 1)
{
int[] NXEND = ImgSearchArea("NexusEnd", NXBP[5], NXBP[6], NXBP[5]+15, NXBP[6]+20, 20);
if (NXEND[0] == 1)
{
SoundPlay("End", 0);
}
else if (NXEND[0] == 0)
{
MouseClick("Left", NXBP[1]+15, NXBP[2]+15, 1, 0, 0, 50);
MouseClick("Right", NXBP[1]+15, NXBP[2]+15, 1, 0, 0, 50);
Thread.Sleep(200);
IntPtr HWND = WinExistsHandle("", "#32768");
IntPtr HMenu = SendMessage(HWND, 0x01E1, 0, IntPtr.Zero);
int[] MRect = GetMIRect(HWND, HMenu, 1);
MouseClick("Left", MRect[0]+15, MRect[1]+15, 1, 0, 0, 50);
Thread.Sleep(100);
string Bank = ControlGetText(API.GetWTitle(), API.GetWClass(), "Edit");
Keyboard.KeyDown(Keys.Enter);
Keyboard.KeyUp(Keys.Enter);
MouseClick("Left", P[1]+450, P[2]+105, 2, 0, 0, 50);
Speak(Bank);
}
}
}
}
}

public static void NexusSearch()
{
using NexusSearchForm F = new NexusSearchForm();
F.ShowDialog();
if (F.DialogResult == DialogResult.OK)
{
MouseClick("Right", P[1]+330, P[2]+230, 1, 0, 0, 10);
Thread.Sleep(200);
IntPtr HWND = WinExistsHandle("", "#32768");
IntPtr HMenu = SendMessage(HWND, 0x01E1, 0, IntPtr.Zero);
int[] MRect = GetMIRect(HWND, HMenu, 7);
MouseClick("Left", MRect[0]+15,MRect[1]+15, 1, 0, 0, 50);
Thread.Sleep(100);
ControlSetText(API.GetWTitle(), API.GetWClass(), "Edit", F.GetString());
Keyboard.KeyDown(Keys.Enter);
Keyboard.KeyUp(Keys.Enter);
MouseClick("Left", P[1]+450, P[2]+105, 2, 0, 0, 10);
}
}

}
}