﻿using System.Threading;
using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class RevealSoundSpire
{

public string BP = "Bank";
public static void Library()
{
VUILoader("Library");
}

public void GoToMain()
{
MouseClick("Left", Coords.X+325, Coords.Y+20, 1, 0, 0, 10);
VUILoader("Spire");
}

public void ChangeBank(string Key)
{
int[] BImg = ImageSearchArea("Banks", Coords.X+50, Coords.Y+50, Coords.X+250, Coords.Y+500, 20);
if (BImg[0] == 0)
{
MouseClick("Left", Coords.X+210, Coords.Y+85, 2, 0, 10, 10);
}
else
{
if (BP == "Preset")
{
MouseClick("Left", BImg[1], BImg[2], 2, 0, 10, 10);
BP = "Bank";
}
}
KeySend("Keys", Key, 100, 100);
BImg = ImageSearchArea("Banks", Coords.X+50, Coords.Y+50, Coords.X+250, Coords.Y+500, 0);
Speak(ImgToText(150, 20, BImg[1], BImg[2], 4));
}

public void ChangePreset(string Key)
{
int[] PImg = ImageSearchArea("Presets", Coords.X+340, Coords.Y+50, Coords.X+1000, Coords.Y+500, 20);
if (PImg[0] == 0)
{
MouseClick("Left", Coords.X+420, Coords.Y+80, 1, 0, 10, 10);
Thread.Sleep(100);
if (ImageSearchArea("Presets", Coords.X+340, Coords.Y+50, Coords.X+1000, Coords.Y+500, 0)[0] == 0)
{
int[] BImg = ImageSearchArea("Banks", Coords.X+50, Coords.Y+50, Coords.X+250, Coords.Y+500, 0);
MouseClick("Left", BImg[1], BImg[2], 2, 0, 10, 10);
Speak("Bank not selected");
return;
}
}
else
{
if (BP == "Bank")
{
MouseClick("Left", PImg[1], PImg[2], 1, 0, 10, 10);
BP = "Preset";
}
}
KeySend("Keys", Key, 100, 100);
PImg = ImageSearchArea("Presets", Coords.X+340, Coords.Y+50, Coords.X+1000, Coords.Y+500, 0);
Speak(ImgToText(150, 20, PImg[1], PImg[2], 4));
}

public void SelectBank()
{
int[] BImg = ImageSearchArea("Banks", Coords.X+50, Coords.Y+50, Coords.X+250, Coords.Y+500, 0);
MouseClick("Left", BImg[5], BImg[6], 1, 0, 10, 10);
Speak(ImgToText(150, 20, BImg[1], BImg[2], 2)+" selected");
}

public void Rescan()
{
MouseClick("Left", Coords.X+355, Coords.Y+510, 1, 0, 0, 10);
}

public void SpeakPreset(string To)
{
if (ImageSearch("Lib", true)[0] == 1)
{
Speak("Please open library and select bank");
return;
}
if (To == "Previous")
{
MouseClick("Left", Coords.X+295, Coords.Y+25, 1, 0, 0, 10);
}
else
{
MouseClick("Left", Coords.X+330, Coords.Y+25, 1, 0, 0, 10);
}
Speak(ImgToText(150, 20, Coords.X+130, Coords.Y+15, 3));
}

public void Options()
{
MouseClick("Left", Coords.X+380, Coords.Y+25, 1, 0, 0, 10);
}

}
}