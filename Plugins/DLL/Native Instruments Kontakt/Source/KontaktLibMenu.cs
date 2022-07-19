using System;
using System.Threading;
using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class Kontakt
{

public static void LibMidiChannel()
{
string Input = InputBox("MIDI Channel", "Enter MIDI channel number from 1 to 16.", 1, 16);
if (Input != null)
{
int[] KLMC = ImageSearch("KontaktTopLine");
MouseClick("Left", KLMC[1]+620, KLMC[2]+20, 1, 0, 0, 10);
Thread.Sleep(100);
MouseClick("Left", KLMC[1]+380, KLMC[2]+15, 1, 0, 0, 10);
Thread.Sleep(100);
MouseClick("Left", KLMC[1]+120, KLMC[2]+60, 1, 0, 0, 10);
while (ImageSearch("KontaktMidiChannelMenu")[0] == 0)
{
;
}

int[] NKLMC = ImageSearch("KontaktMidiChannelMenu");
MouseMove(NKLMC[5], NKLMC[6], 0);
while (ImageSearch("KontaktMidiChannelNumber")[0] == 0)
{
;
}

int[] NKLMCN = ImageSearch("KontaktMidiChannelNumber");
MouseMove(NKLMCN[5], NKLMCN[6], 0);
int NumberChannel = Convert.ToInt32(Input);
int X = Convert.ToInt32(NKLMCN[5]);
int Y = Convert.ToInt32(NKLMCN[6]+(17*NumberChannel));
MouseClick("Left", X, Y-10	, 1, 0, 0, 10);
MouseClick("Left", KLMC[1]+620, KLMC[2]+20, 1, 0, 0, 10);
Speak("Done");
}
}

public static void LibAudioChannel()
{
string Input = InputBox("Audio Channel", "Enter audio channel number from 1 to 16.", 1, 16);
if (Input != null)
{
int[] KLAC = ImageSearch("KontaktTopLine");
MouseClick("Left", KLAC[1]+620, KLAC[2]+20, 1, 0, 0, 10);
Thread.Sleep(100);
MouseClick("Left", KLAC[1]+380, KLAC[2]+15, 1, 0, 0, 10);
Thread.Sleep(100);
MouseClick("Left", KLAC[1]+120, KLAC[2]+40, 1, 0, 0, 10);
while (ImageSearch("KontaktAudioChannel")[0] == 0)
{
;
}

int[] NKLAC = ImageSearch("KontaktAudioChannel");
int NumberChannel = Convert.ToInt32(Input);
int X = Convert.ToInt32(NKLAC[5]);
int Y = Convert.ToInt32(NKLAC[2]+(17*NumberChannel));
MouseClick("Left", X, Y, 1, 0, 0, 10);
MouseClick("Left", KLAC[1]+620, KLAC[2]+20, 1, 0, 0, 10);
Speak("Done");
}
else
{
return;
}
}

public static void LibDelete()
{
int[] KLD = ImageSearch("KontaktTopLine");
string Name = ImgToText(200, 30, KLD[1] + 70, KLD[2] + 5, 2);
MouseClick("Left", KLD[1] + 620, KLD[2] + 10, 1, 0, 0, 10);
while(ImageSearch("KontaktTopLine")[0] == 1)
{
;
}

int[] LibLoaded = ImageSearch("KontaktLibLoaded");
if (LibLoaded[0] == 1)
{
BackToOptionMenu();
Speak(Name+" deleted");
return;
}
else
{
LibNormalize();
Speak(Name+" deleted");
return;
}
}

public static void LibSwitchFolder(string To)
{
try
{
int[] KLSF = ImageSearch("KontaktTopLine");
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
Speak("Done");
}

public static void LibSwitchSnapshot(string To)
{
int[] KLSS = ImageSearch("KontaktTopLine");
MouseClick("Left", KLSS[1]+620, KLSS[2]+20, 1, 0, 0, 10);
while (ImageSearch("KontaktLeftLine")[0] == 0)
{
;
}

MouseClick("Left", KLSS[1]+360, KLSS[2]+15, 1, 0, 0, 10);
while (ImageSearch("KontaktLibSnapshot")[0] == 1)
{
;
}

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
}

public static void BlockDelete()
{
return;
}

}
}