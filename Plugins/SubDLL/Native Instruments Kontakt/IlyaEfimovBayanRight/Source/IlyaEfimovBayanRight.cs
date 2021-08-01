using System;
using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public class IlyaEfimovBayanRight
{

public static void RoundRobin()
{
MouseClick("Left", P[1]+45, P[2]+190, 1, 0, 0, 10);
Thread.Sleep(100);
if (ImgSearchArea("BayanCheckBox", P[1]+45, P[2]+190, P[1]+100, P[2]+230, 0)[0] == 1)
{
Speak("RoundRobin checked");
}
else
{
Speak("RoundRobin not checked");
}
}

public static void AutoAttack()
{
MouseClick("Left", P[1]+45, P[2]+230, 1, 0, 0, 10);
Thread.Sleep(100);
if (ImgSearchArea("BayanCheckBox", P[1]+45, P[2]+230, P[1]+100, P[2]+260, 0)[0] == 1)
{
Speak("AutoAttack checked");
VUIObjectSwitcher(false, "false", 2, 2);
}
else
{
Speak("AutoAttack not checked");
VUIObjectSwitcher(false, "true", 2, 2);
}
}

public static void AttackTime()
{
Slider("Attack Time", 45, 270, "H", 0.86, 1.4);
}

public static void KeyNoise()
{
Slider("Key Noise", 170, 190, "H", 0.86, 1.4);
}

public static void Bellow()
{
Slider("Bellow", 170, 230, "H", 0.86, 1.4);
}

public static void Release()
{
Slider("Release", 170, 270, "H", 0.86, 1.4);
}

public static void Reverb()
{
MouseClick("Left", P[1]+280, P[2]+190, 1, 0, 0, 10);
Thread.Sleep(100);
if (ImgSearchArea("BayanCheckBox", P[1]+280, P[2]+190, P[1]+350, P[2]+230, 0)[0] == 1)
{
Speak("Reverb checked");
VUIObjectSwitcher(false, "true", 7, 7);
}
else
{
Speak("Reverb not checked");
VUIObjectSwitcher(false, "false", 7, 7);
}
}

public static void ReverbLevel()
{
Slider("ReverbLevel", 280, 230, "H", 0.86, 1.4);
}

public static void Detune()
{
MouseClick("Left", P[1]+280, P[2]+270, 1, 0, 0, 10);
Thread.Sleep(100);
if (ImgSearchArea("BayanCheckBox", P[1]+280, P[2]+270, P[1]+350, P[2]+320, 0)[0] == 1)
{
Speak("Detune checked");
}
else
{
Speak("Detune not checked");
}
}

public static void Sustain()
{
MouseClick("Left", P[1]+550, P[2]+190, 1, 0, 0, 10);
Speak("Sustain включено");
}

public static void Staccato()
{
MouseClick("Left", P[1]+550, P[2]+210, 1, 0, 0, 10);
Speak("Staccato on");
}

public static void Crescendo()
{
MouseClick("Left", P[1]+550, P[2]+230, 1, 0, 0, 10);
Speak("Crescendo on");
}

public static void Detache()
{
MouseClick("Left", P[1]+590, P[2]+250, 1, 0, 0, 10);
Speak("Detache on");
}

public static void Piccolo()
{
MouseClick("Left", P[1]+75, P[2]+310, 1, 0, 0, 10);
MouseMove(P[1], P[2], 0);
Thread.Sleep(100);
if (ImgSearch("BayanPiccolo")[0] == 1)
{
Speak("Piccolo on");
}
else
{
Speak("Piccolo off");
}
}

public static void Concertina()
{
MouseClick("Left", P[1]+155, P[2]+310, 1, 0, 0, 10);
MouseMove(P[1], P[2], 0);
Thread.Sleep(100);
if (ImgSearch("BayanConcertina")[0] == 1)
{
Speak("Concertina on");
}
else
{
Speak("Concertina off");
}
}

public static void Clarinet()
{
MouseClick("Left", P[1]+235, P[2]+310, 1, 0, 0, 10);
MouseMove(P[1], P[2], 0);
Thread.Sleep(100);
if (ImgSearch("BayanClarinet")[0] == 1)
{
Speak("Clarinet on");
}
else
{
Speak("Clarinet off");
}
}

public static void Bossoon()
{
MouseClick("Left", P[1]+315, P[2]+310, 1, 0, 0, 10);
MouseMove(P[1], P[2], 0);
Thread.Sleep(100);
if (ImgSearch("BayanBassoon")[0] == 1)
{
Speak("Bassoon on");
}
else
{
Speak("Bassoon off");
}
}

public static void IlyaEfimovBayanRightLoader()
{
if (ImgSearchArea("BayanCheckBox", P[1]+45, P[2]+230, P[1]+100, P[2]+260, 0)[0] == 1)
{
VUIObjectSwitcher(false, "false", 2, 2);
}
else
{
VUIObjectSwitcher(false, "true", 2, 2);
}
if (ImgSearchArea("BayanCheckBox", P[1]+280, P[2]+190, P[1]+350, P[2]+230, 0)[0] == 1)
{
VUIObjectSwitcher(false, "true", 7, 7);
}
else
{
VUIObjectSwitcher(false, "false", 7, 7);
}
}

public static void Back()
{
SubPluginUnLoad();
VUILoader("LibList");
}

}
}