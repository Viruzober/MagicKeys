using System;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Kontakt
{

public static void Load()
{
MouseClick("Left", P[1]+355, P[2]+17, 1, 0, 0, 10);
MouseClick("Left", P[1]+355, P[2]+87, 1, 0, 0, 10);
}

public static void BatchResave()
{
MouseClick("Left", P[1]+355, P[2]+17, 1, 0, 0, 10);
MouseClick("Left", P[1]+355, P[2]+247, 1, 0, 0, 10);
}

public static void AddLibrary()
{
if (OS() == "64")
{
Process.Start(@"Settings\Kontakt\Add Library Tool x64\Add Library.exe");
}
else
{
Process.Start(@"Settings\Kontakt\Add Library Tool x32\Add Library.exe");
}
}

public static void AllLibDelete()
{
if (ImgSearch(@"Images\Kontakt\KontaktLibLoaded.bmp")[0] == 1)
{
Speak("No loaded libraries");
return;
}
RegisterHotKey(KeyNavigatorHandle.Handle, 21, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F4);
while (ImgSearch(@"Images\Kontakt\KontaktLibLoaded.bmp")[0] == 0)
{
                LoopException();
MouseClick("Left", P[1]+630, P[2]+80, 1, 0, 0, 10);
while(WinActive(API.GetWTitle(), API.GetWClass()) == false);
Thread.Sleep(150);
}
UnregisterHotKey(KontaktKeyHandle.Handle, 21);
LibLoaded();
Speak("OK");
}

public static void GoToLibList()
{
VUILoader(@"Kontakt\LibList.vui");
LibNormalize();
Speak("OK");
}

public static void BackToOptionMenu()
{
VUILoader(@"Kontakt\Kontakt.vui");
LibLoaded();
Speak("OK");
}

}
}