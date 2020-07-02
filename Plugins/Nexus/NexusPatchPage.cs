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
int[] FH = ImgSearchArea(@"Images\Nexus\FullHome.bmp", P[1]+540, P[2]+50, P[1]+590, P[2]+160, 20);
if (FH[0] == 1)
{
SoundPlay("End.ogg", 0);
return;
}
SoundPlay("Scrol.ogg", 0);
MouseClick("Left", P[1]+575, P[2]+120, 1, 0, 0, 10);
MouseClick("Right", P[1]+450, P[2]+230, 1, 0, 0, 10);
Thread.Sleep(100);
IntPtr HWND = WinExistsHandle("", "#32768");
IntPtr HMenu = SendMessage(HWND, 0x01E1, 0, IntPtr.Zero);
int[] MRect = GetMIRect(HWND, HMenu, 1);
MouseClick("Left", MRect[0]+15,MRect[1]+15, 1, 0, 0, 10);
Thread.Sleep(100);
string Patch = ControlGetText(PluginsList[0]["WTitle"], PluginsList[0]["WClass"], "Edit");
Keyboard.KeyDown(Keys.Enter);
Keyboard.KeyUp(Keys.Enter);
MouseClick("Left", P[1]+450, P[2]+230, 2, 0, 0, 10);
Speak(Patch);
}
else if (To == "Next")
{
int[] FH = ImgSearchArea(@"Images\Nexus\FullEnd.bmp", P[1]+540, P[2]+180, P[1]+590, P[2]+280, 20);
if (FH[0] == 1)
{
SoundPlay("End.ogg", 0);
return;
}
SoundPlay("Scrol.ogg", 0);
MouseClick("Left", P[1]+575, P[2]+220, 1, 0, 0, 10);
MouseClick("Right", P[1]+450, P[2]+105, 1, 0, 0, 10);
Thread.Sleep(100);
IntPtr HWND = WinExistsHandle("", "#32768");
IntPtr HMenu = SendMessage(HWND, 0x01E1, 0, IntPtr.Zero);
int[] MRect = GetMIRect(HWND, HMenu, 1);
MouseClick("Left", MRect[0]+15,MRect[1]+15, 1, 0, 0, 10);
Thread.Sleep(100);
string Patch = ControlGetText(PluginsList[0]["WTitle"], PluginsList[0]["WClass"], "Edit");
Keyboard.KeyDown(Keys.Enter);
Keyboard.KeyUp(Keys.Enter);
MouseClick("Left", P[1]+450, P[2]+105, 2, 0, 0, 10);
Speak(Patch);
}
}

}
}