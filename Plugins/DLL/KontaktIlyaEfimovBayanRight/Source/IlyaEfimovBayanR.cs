using System;
using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static class IlyaEfimovBayanR
{

public static void RoundRobin()
{
MouseClick("Left", P[1]+45, P[2]+190, 1, 0, 0, 10);
Thread.Sleep(100);
if (ImgSearchArea(@"Images\KontaktIlyaEfimov\BayanCheckBox.bmp", P[1]+45, P[2]+190, P[1]+100, P[2]+230, 0)[0] == 1)
{
Speak("RoundRobin отмечено");
}
else
{
Speak("RoundRobin не отмечено");
}
}

public static void AutoAttack()
{
MouseClick("Left", P[1]+45, P[2]+230, 1, 0, 0, 10);
Thread.Sleep(100);
if (ImgSearchArea(@"Images\KontaktIlyaEfimov\BayanCheckBox.bmp", P[1]+45, P[2]+230, P[1]+100, P[2]+260, 0)[0] == 1)
{
Speak("AutoAttack отмечено");
VUIObjectSwitcher(false, "false", 3, 3);
}
else
{
Speak("AutoAttack не отмечено");
VUIObjectSwitcher(false, "true", 3, 3);
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
if (ImgSearchArea(@"Images\KontaktIlyaEfimov\BayanCheckBox.bmp", P[1]+280, P[2]+190, P[1]+350, P[2]+230, 0)[0] == 1)
{
Speak("Reverb отмечено");
VUIObjectSwitcher(false, "true", 8, 8);
}
else
{
Speak("Reverb не отмечено");
VUIObjectSwitcher(false, "false", 8, 8);
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
if (ImgSearchArea(@"Images\KontaktIlyaEfimov\BayanCheckBox.bmp", P[1]+280, P[2]+270, P[1]+350, P[2]+320, 0)[0] == 1)
{
Speak("Detune отмечено");
}
else
{
Speak("Detune не отмечено");
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
Speak("Staccato включено");
}

public static void Crescendo()
{
MouseClick("Left", P[1]+550, P[2]+230, 1, 0, 0, 10);
Speak("Crescendo включено");
}

public static void Detache()
{
MouseClick("Left", P[1]+590, P[2]+250, 1, 0, 0, 10);
Speak("Detache включено");
}

public static void Piccolo()
{
MouseClick("Left", P[1]+75, P[2]+310, 1, 0, 0, 10);
MouseMove(P[1], P[2], 0);
Thread.Sleep(100);
if (ImgSearch(@"Images\KontaktIlyaEfimov\BayanPiccolo.bmp")[0] == 1)
{
Speak("Piccolo включён");
}
else
{
Speak("Piccolo отключён");
}
}

public static void Concertina()
{
MouseClick("Left", P[1]+155, P[2]+310, 1, 0, 0, 10);
MouseMove(P[1], P[2], 0);
Thread.Sleep(100);
if (ImgSearch(@"Images\KontaktIlyaEfimov\BayanConcertina.bmp")[0] == 1)
{
Speak("Concertina включён");
}
else
{
Speak("Concertina отключён");
}
}

public static void Clarinet()
{
MouseClick("Left", P[1]+235, P[2]+310, 1, 0, 0, 10);
MouseMove(P[1], P[2], 0);
Thread.Sleep(100);
if (ImgSearch(@"Images\KontaktIlyaEfimov\BayanClarinet.bmp")[0] == 1)
{
Speak("Clarinet включён");
}
else
{
Speak("Clarinet отключён");
}
}

public static void Bossoon()
{
MouseClick("Left", P[1]+315, P[2]+310, 1, 0, 0, 10);
MouseMove(P[1], P[2], 0);
Thread.Sleep(100);
if (ImgSearch(@"Images\KontaktIlyaEfimov\BayanBassoon.bmp")[0] == 1)
{
Speak("Bossoon включён");
}
else
{
Speak("Bossoon отключён");
}
}

public static void PluginLoad()
{
if (ImgSearchArea(@"Images\KontaktIlyaEfimov\BayanCheckBox.bmp", P[1]+45, P[2]+230, P[1]+100, P[2]+260, 0)[0] == 1)
{
VUIObjectSwitcher(false, "false", 3, 3);
}
else
{
VUIObjectSwitcher(false, "true", 3, 3);
}
if (ImgSearchArea(@"Images\KontaktIlyaEfimov\BayanCheckBox.bmp", P[1]+280, P[2]+190, P[1]+350, P[2]+230, 0)[0] == 1)
{
VUIObjectSwitcher(false, "true", 8, 8);
}
else
{
VUIObjectSwitcher(false, "false", 8, 8);
}
}

public static void Back()
{
Kontakt.GoToLibList();
}

}
}