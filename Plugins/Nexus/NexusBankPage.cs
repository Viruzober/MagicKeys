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
int[] FH = ImgSearchArea(@"Images\Nexus\FullHome.bmp", P[1]+350, P[2]+50, P[1]+460, P[2]+160, 20);
if (FH[0] == 1)
{
SoundPlay("End.ogg", 0);
return;
}
SoundPlay("Scrol.ogg", 0);
MouseClick("Left", P[1]+400, P[2]+105, 1, 0, 0, 10);
MouseClick("Right", P[1]+330, P[2]+230, 1, 0, 0, 10);
}
else if (To == "Next")
{
int[] FH = ImgSearchArea(@"Images\Nexus\FullEnd.bmp", P[1]+350, P[2]+200, P[1]+460, P[2]+260, 20);
if (FH[0] == 1)
{
SoundPlay("End.ogg", 0);
return;
}
SoundPlay("Scrol.ogg", 0);
MouseClick("Left", P[1]+400, P[2]+220, 1, 0, 0, 10);
MouseClick("Right", P[1]+330, P[2]+105, 1, 0, 0, 10);
}
Thread.Sleep(200);
IntPtr HWND = WinExistsHandle("", "#32768");
IntPtr HMenu = SendMessage(HWND, 0x01E1, 0, IntPtr.Zero);
int[] MRect = GetMIRect(HWND, HMenu, 1);
MouseClick("Left", MRect[0]+15,MRect[1]+15, 1, 0, 0, 10);
Thread.Sleep(100);
string Bank = ControlGetText(PluginsList[0]["WTitle"], PluginsList[0]["WClass"], "Edit");
Keyboard.KeyDown(Keys.Enter);
Keyboard.KeyUp(Keys.Enter);
MouseClick("Left", P[1]+450, P[2]+105, 2, 0, 0, 10);
Speak(Bank);
}

}
}