using System;
using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public class RevealSoundSpire
{
public static string BP = "Bank";
public static void Library()
{
if (ImgSearch("Lib", true)[0] == 0)
{
MouseClick("Left", P[1]+210, P[2]+20, 1, 0, 0, 10);
}
else
{
MouseClick("Left", P[1]+325, P[2]+20, 1, 0, 0, 10);
}
Thread.Sleep(200);
MouseClick("Left", P[1]+200, P[2]+85, 1, 0, 0, 10);
VUILoader("Library");
}

public static void GoToMain()
{
MouseClick("Left", P[1]+325, P[2]+20, 1, 0, 0, 10);
VUILoader("Spire");
}

public static void ChangeBank(string Key)
{
int[] BImg = ImgSearchArea("Banks", P[1]+50, P[2]+50, P[1]+250, P[2]+500, 20);
if (BImg[0] == 0)
{
MouseClick("Left", P[1]+210, P[2]+85, 2, 0, 0, 10);
}
else
{
if (BP == "Preset")
{
MouseClick("Left", BImg[1], BImg[2], 2, 0, 0, 10);
BP = "Bank";
}
}
KeySend("Keys", Key, 50, 50);
BImg = ImgSearchArea("Banks", P[1]+50, P[2]+50, P[1]+250, P[2]+500, 20);
Speak(ImgToText(150, 20, BImg[1], BImg[2], 4));
}

public static void ChangePreset(string Key)
{
int[] PImg = ImgSearchArea("Presets", P[1]+340, P[2]+50, P[1]+1000, P[2]+500, 20);
if (PImg[0] == 0)
{
MouseClick("Left", P[1]+420, P[2]+80, 1, 0, 0, 10);
Thread.Sleep(50);
if (ImgSearchArea("Presets", P[1]+340, P[2]+50, P[1]+1000, P[2]+500, 20)[0] == 0)
{
int[] BImg = ImgSearchArea("Banks", P[1]+50, P[2]+50, P[1]+250, P[2]+500, 20);
MouseClick("Left", BImg[1], BImg[2], 2, 0, 0, 10);
Speak("Bank not selected");
return;
}
}
else
{
if (BP == "Bank")
{
MouseClick("Left", PImg[1], PImg[2], 1, 0, 0, 10);
BP = "Preset";
}
}
KeySend("Keys", Key, 50, 100);
PImg = ImgSearchArea("Presets", P[1]+340, P[2]+50, P[1]+1000, P[2]+500, 20);
Speak(ImgToText(150, 20, PImg[1], PImg[2], 4));
}

public static void SelectBank()
{
int[] BImg = ImgSearchArea("Banks", P[1]+50, P[2]+50, P[1]+250, P[2]+500, 20);
MouseClick("Left", BImg[5], BImg[6], 1, 0, 0, 10);
Speak(ImgToText(150, 20, BImg[1], BImg[2], 2)+" selected");
}

public static void Rescan()
{
MouseClick("Left", P[1]+355, P[2]+510, 1, 0, 0, 10);
}

public static void SpeakPreset(string To)
{
if (ImgSearch("Lib", true)[0] == 1)
{
Speak("Please open library and select bank");
return;
}
if (To == "Previews")
{
MouseClick("Left", P[1]+295, P[2]+25, 1, 0, 0, 10);
}
else
{
MouseClick("Left", P[1]+330, P[2]+25, 1, 0, 0, 10);
}
Speak(ImgToText(150, 20, P[1]+130, P[2]+15, 3));
}

public static void Options()
{
MouseClick("Left", P[1]+380, P[2]+25, 1, 0, 0, 10);
}

}
}