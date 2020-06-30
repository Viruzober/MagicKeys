using System;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Kontakt
{

public static void LibMidiChannel()
{
KeyUnReg();
KeyGoToLibListUnReg();
string Input = InputBox("Midi канал", "Введите номер Midi канала от 1 до 16.", 1, 16);
if (Input != "0")
{
KeyReg();
KeyGoToLibListReg();
int[] KLMC = ImgSearch(@"Images\Kontakt\KontaktTopLine.bmp");
MouseClick("Left", KLMC[1]+620, KLMC[2]+20, 1, 0, 0, 10);
Thread.Sleep(100);
MouseClick("Left", KLMC[1]+380, KLMC[2]+15, 1, 0, 0, 10);
Thread.Sleep(100);
MouseClick("Left", KLMC[1]+120, KLMC[2]+60, 1, 0, 0, 10);
while (ImgSearch(@"Images\Kontakt\KontaktMidiChannelMenu.bmp")[0] == 0);
int[] NKLMC = ImgSearch(@"Images\Kontakt\KontaktMidiChannelMenu.bmp");
MouseMove(NKLMC[5], NKLMC[6], 0);
while (ImgSearch(@"Images\Kontakt\KontaktMidiChannelNumber.bmp")[0] == 0);
int[] NKLMCN = ImgSearch(@"Images\Kontakt\KontaktMidiChannelNumber.bmp");
MouseMove(NKLMCN[5], NKLMCN[6], 0);
int NumberChannel = Convert.ToInt32(Input);
int X = Convert.ToInt32(NKLMCN[5]);
int Y = Convert.ToInt32(NKLMCN[2]+(17*NumberChannel));
MouseClick("Left", X, Y, 1, 0, 0, 10);
MouseClick("Left", KLMC[1]+620, KLMC[2]+20, 1, 0, 0, 10);
Speak("OK");
}
else
{
KeyReg();
KeyGoToLibListReg();
return;
}
}

public static void LibAudioChannel()
{
KeyUnReg();
KeyGoToLibListUnReg();
string Input = InputBox("Аудио канал", "Введите номер стерео пары от 1 до 16.", 1, 16);
if (Input != "0")
{
KeyReg();
KeyGoToLibListReg();
int[] KLAC = ImgSearch(@"Images\Kontakt\KontaktTopLine.bmp");
MouseClick("Left", KLAC[1]+620, KLAC[2]+20, 1, 0, 0, 10);
Thread.Sleep(100);
MouseClick("Left", KLAC[1]+380, KLAC[2]+15, 1, 0, 0, 10);
Thread.Sleep(100);
MouseClick("Left", KLAC[1]+120, KLAC[2]+40, 1, 0, 0, 10);
while (ImgSearch(@"Images\Kontakt\KontaktAudioChannel.bmp")[0] == 0);
int[] NKLAC = ImgSearch(@"Images\Kontakt\KontaktAudioChannel.bmp");
int NumberChannel = Convert.ToInt32(Input);
int X = Convert.ToInt32(NKLAC[5]);
int Y = Convert.ToInt32(NKLAC[2]+(17*NumberChannel));
MouseClick("Left", X, Y, 1, 0, 0, 10);
MouseClick("Left", KLAC[1]+620, KLAC[2]+20, 1, 0, 0, 10);
Speak("OK");
}
else
{
KeyReg();
KeyGoToLibListReg();
return;
}
}

public static void LibDelete()
{
KeyUnReg();
KeyGoToLibListUnReg();
int[] KLD = ImgSearch(@"Images\Kontakt\KontaktTopLine.bmp");
string Name = ImgToText(200, 30, KLD[1] + 70, KLD[2] + 5, 2);
MouseClick("Left", KLD[1] + 620, KLD[2] + 10, 1, 0, 0, 10);
while(ImgSearch(@"Images\Kontakt\KontaktTopLine.bmp")[0] == 1);
int[] LibLoaded = ImgSearch(@"Images\Kontakt\KontaktLibLoaded.bmp");
if (LibLoaded[0] == 1)
{
BackToOptionMenu();
Speak(Name+" deleted");
return;
}
else
{
LibNormalize();
KeyReg();
KeyGoToLibListReg();
Speak(Name+" deleted");
return;
}
		}

public static void LibSwitchFolder(string To)
{
try
{
KeyUnReg();
KeyGoToLibListUnReg();
int[] KLSF = ImgSearch(@"Images\Kontakt\KontaktTopLine.bmp");
if (To == "Back")
{
MouseClick("Left", KLSF[1]+365, KLSF[2]+20, 1, 0, 0, 30);
}
else if (To == "Next")
{
MouseClick("Left", KLSF[1]+385, KLSF[2]+20, 1, 0, 0, 30);
}
}
catch(Exception)
{
LibNormalize();
LibSwitchFolder(To);
}
Thread.Sleep(200);
KeyReg();
KeyGoToLibListReg();
Speak("OK");
}

public static void LibSwitchSnapshot(string To)
{
KeyUnReg();
KeyGoToLibListUnReg();
int[] KLSS = ImgSearch(@"Images\Kontakt\KontaktTopLine.bmp");
MouseClick("Left", KLSS[1]+620, KLSS[2]+20, 1, 0, 0, 10);
while (ImgSearch(@"Images\Kontakt\KontaktLeftLine.bmp")[0] == 0);
MouseClick("Left", KLSS[1]+360, KLSS[2]+15, 1, 0, 0, 10);
while (ImgSearch(@"Images\Kontakt\KontaktLibSnapshot.bmp")[0] == 1);
if (To == "Back")
{
MouseClick("Left", KLSS[1]+250, KLSS[2]+45, 1, 0, 0, 10);
}
else if (To == "Next")
{
MouseClick("Left", KLSS[1]+275, KLSS[2]+45, 1, 0, 0, 10);
}
Thread.Sleep(800);
string Snapshot = ImgToText(140, 25, KLSS[1] + 70, KLSS[2] + 35, 2);
MouseClick("Left", KLSS[1]+620, KLSS[2]+20, 1, 0, 0, 10);
Speak(Snapshot);
KeyReg();
KeyGoToLibListReg();
}

}
}