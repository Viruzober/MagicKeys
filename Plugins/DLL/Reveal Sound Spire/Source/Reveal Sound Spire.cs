using System;
using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public class RevealSoundSpire
{

public static void PresetsManager()
{
MouseClick("Left", P[1]+325, P[2]+20, 1, 0, 0, 10);
Thread.Sleep(500);
MouseClick("Left", P[1]+195, P[2]+85, 1, 0, 0, 10);
VUILoader("PresetsManager");
}

public static void PreviewsBank()
{
int[] BImg = ImgSearchArea("Banks", P[1]+50, P[2]+50, P[1]+250, P[2]+500, 20);
if (BImg[0] == 1)
{
MouseClick("Left", BImg[1], BImg[2], 1, 0, 0, 10);
}
KeySend("Keys", "Up", 50, 50);
BImg = ImgSearchArea("Banks", P[1]+50, P[2]+50, P[1]+250, P[2]+500, 20);
MouseClick("Left", BImg[1], BImg[2], 2, 0, 0, 10);
MouseClick("Left", P[1]+420, P[2]+80, 1, 0, 0, 10);
Speak(ImgToText(150, 20, BImg[1], BImg[2], 2));
}

public static void NextBank()
{
int[] BImg = ImgSearchArea("Banks", P[1]+50, P[2]+50, P[1]+250, P[2]+500, 20);
if (BImg[0] == 1)
{
MouseClick("Left", BImg[1], BImg[2], 1, 0, 0, 10);
}
KeySend("Keys", "Down", 50, 50);
BImg = ImgSearchArea("Banks", P[1]+50, P[2]+50, P[1]+250, P[2]+500, 20);
MouseClick("Left", BImg[1], BImg[2], 2, 0, 0, 10);
MouseClick("Left", P[1]+420, P[2]+80, 1, 0, 0, 10);
Speak(ImgToText(150, 20, BImg[1], BImg[2], 2));
}

public static void SpeakPreset(string Key)
{
if (ImgSearchArea("Presets", P[1]+340, P[2]+50, P[1]+1000, P[2]+500, 20)[0] == 0)
{
Speak("Not opened bank");
return;
}
KeySend("Keys", Key, 50, 50);
int[] BImg = ImgSearchArea("Presets", P[1]+340, P[2]+50, P[1]+1000, P[2]+500, 20);
Speak(ImgToText(150, 20, BImg[1], BImg[2], 2));
}

public static void Rescan()
{
MouseClick("Left", P[1]+355, P[2]+510, 1, 0, 0, 10);
}

public static void Options()
{
MouseClick("Left", P[1]+380, P[2]+25, 1, 0, 0, 10);
}

}
}