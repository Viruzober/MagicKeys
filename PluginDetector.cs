using System;
using System.Windows.Forms;
using System.Threading;

namespace MagicKeys
{
    public partial class MagicKeys
{

public delegate int[] GetP();
public static GetP Mes;

public static void PluginDetector()
{
while(true)
{
Thread.Sleep(TimeOut);
Application.DoEvents();
if (KeySwitch == 0)
{
if (WinActive(HWNDFXTrack[0], HWNDFXTrack[1]) == true)
{
if (Kontakt.GetPos()[0] == 1)
{
Mes = Kontakt.GetPos;
PluginClass = typeof(Kontakt).FullName;
VUILoader("VUI.Kontakt.Kontakt.vui");
Kontakt.KontaktNormalize();
Kontakt.LibLoaded();
Kontakt.KeyReg();
SoundPlay("WindowOpened.ogg", 0);
WinClose(HWNDFXTrack[0], HWNDFXTrack[1]);
Kontakt.KeyUnReg();
Kontakt.KeyGoToLibListUnReg();
SoundPlay("WindowClose.ogg", 0);
}
}
else if (WinActive(HWNDKontaktB[0], HWNDKontaktB[1]) == true)
{
if (Kontakt.GetPos()[0] == 1)
{
Mes = Kontakt.GetPos;
PluginClass = typeof(Kontakt).FullName;
VUILoader("VUI.Kontakt.Kontakt.vui");
Kontakt.KontaktNormalize();
Kontakt.LibLoaded();
Kontakt.KeyReg();
SoundPlay("WindowOpened.ogg", 0);
WinClose(HWNDKontaktB[0], HWNDKontaktB[1]);
Kontakt.KeyUnReg();
Kontakt.KeyGoToLibListUnReg();
SoundPlay("WindowClose.ogg", 0);
}
}
else if (WinActive(HWNDKontaktP[0], HWNDKontaktP[1]) == true | WinSearch(HWNDKontaktP[0], HWNDKontaktP[1]) == true)
{
Mes = GetPos;
PluginClass = typeof(Kontakt).FullName;
VUILoader("VUI.Kontakt.Progress.vui");
Kontakt.KeyReg();
SoundPlay("WindowOpened.ogg", 0);
WinClose(HWNDKontaktP[0], HWNDKontaktP[1]);
Kontakt.KeyUnReg();
SoundPlay("WindowClose.ogg", 0);
}
else if (WinActive(HWNDKontaktCM[0], HWNDKontaktCM[1]) == true | WinSearch(HWNDKontaktCM[0], HWNDKontaktCM[1]) == true)
{
Mes = GetPos;
PluginClass = typeof(Kontakt).FullName;
VUILoader("VUI.Kontakt.ConntentMissing.vui");
Kontakt.KeyReg();
SoundPlay("WindowOpened.ogg", 0);
WinClose(HWNDKontaktCM[0], HWNDKontaktCM[1]);
Kontakt.KeyUnReg();
SoundPlay("WindowClose.ogg", 0);
}
else if (WinActive(HWNDPlugSound[0], HWNDPlugSound[1]) == true & WinSearch(HWNDPlugSound[0], HWNDPlugSound[1]) == true)
{
Mes = GetPos;
PluginClass = typeof(PlugSound).FullName;
VUILoader("VUI.PlugSound.PlugSound.vui");
PlugSound.KeyReg();
SoundPlay("WindowOpened.ogg", 0);
WinClose(HWNDPlugSound[0], HWNDPlugSound[1]);
PlugSound.KeyUnReg();
SoundPlay("WindowClose.ogg", 0);
}
else if (WinActive(HWNDPlugSoundFree[0], HWNDPlugSoundFree[1]) == true | WinSearch(HWNDPlugSoundFree[0], HWNDPlugSoundFree[1]) == true)
{
Mes = GetPos;
PluginClass = typeof(PlugSound).FullName;
VUILoader("VUI.PlugSound.PlugSoundFree.vui");
PlugSound.KeyReg();
SoundPlay("WindowOpened.ogg", 0);
WinClose(HWNDPlugSoundFree[0], HWNDPlugSoundFree[1]);
PlugSound.KeyUnReg();
SoundPlay("WindowClose.ogg", 0);
}
else if (WinActive(HWNDNexus[0], HWNDNexus[1]) == true | WinSearch(HWNDNexus[0], HWNDNexus[1]) == true)
{
Mes = GetPos;
PluginClass = typeof(Nexus).FullName;
VUILoader("VUI.Nexus.Nexus.vui");
Nexus.KeyReg();
SoundPlay("WindowOpened.ogg", 0);
WinClose(HWNDNexus[0], HWNDNexus[1]);
Nexus.KeyUnReg();
SoundPlay("WindowClose.ogg", 0);
}
}
}
}

}
}