using System.Threading;
using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public class IlyaEfimovBayanRight
{

public static void RoundRobin()
{
MouseClick("Left", Coords.X+45, Coords.Y+190, 1, 0, 0, 10);
Thread.Sleep(100);
if (ImageSearchArea("BayanCheckBox", Coords.X+45, Coords.Y+190, Coords.X+100, Coords.Y+230, 0)[0] == 1)
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
MouseClick("Left", Coords.X+45, Coords.Y+230, 1, 0, 0, 10);
Thread.Sleep(100);
if (ImageSearchArea("BayanCheckBox", Coords.X+45, Coords.Y+230, Coords.X+100, Coords.Y+260, 0)[0] == 1)
{
Speak("AutoAttack checked");
VUIObjectSwitcher(false, false, 2, 2);
}
else
{
Speak("AutoAttack not checked");
VUIObjectSwitcher(false, true, 2, 2);
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
MouseClick("Left", Coords.X+280, Coords.Y+190, 1, 0, 0, 10);
Thread.Sleep(100);
if (ImageSearchArea("BayanCheckBox", Coords.X+280, Coords.Y+190, Coords.X+350, Coords.Y+230, 0)[0] == 1)
{
Speak("Reverb checked");
VUIObjectSwitcher(false, true, 7, 7);
}
else
{
Speak("Reverb not checked");
VUIObjectSwitcher(false, false, 7, 7);
}
}

public static void ReverbLevel()
{
Slider("ReverbLevel", 280, 230, "H", 0.86, 1.4);
}

public static void Detune()
{
MouseClick("Left", Coords.X+280, Coords.Y+270, 1, 0, 0, 10);
Thread.Sleep(100);
if (ImageSearchArea("BayanCheckBox", Coords.X+280, Coords.Y+270, Coords.X+350, Coords.Y+320, 0)[0] == 1)
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
MouseClick("Left", Coords.X+550, Coords.Y+190, 1, 0, 0, 10);
Speak("Sustain включено");
}

public static void Staccato()
{
MouseClick("Left", Coords.X+550, Coords.Y+210, 1, 0, 0, 10);
Speak("Staccato on");
}

public static void Crescendo()
{
MouseClick("Left", Coords.X+550, Coords.Y+230, 1, 0, 0, 10);
Speak("Crescendo on");
}

public static void Detache()
{
MouseClick("Left", Coords.X+590, Coords.Y+250, 1, 0, 0, 10);
Speak("Detache on");
}

public static void Piccolo()
{
MouseClick("Left", Coords.X+75, Coords.Y+310, 1, 0, 0, 10);
MouseMove(Coords.X, Coords.Y, 0);
Thread.Sleep(100);
if (ImageSearch("BayanPiccolo")[0] == 1)
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
MouseClick("Left", Coords.X+155, Coords.Y+310, 1, 0, 0, 10);
MouseMove(Coords.X, Coords.Y, 0);
Thread.Sleep(100);
if (ImageSearch("BayanConcertina")[0] == 1)
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
MouseClick("Left", Coords.X+235, Coords.Y+310, 1, 0, 0, 10);
MouseMove(Coords.X, Coords.Y, 0);
Thread.Sleep(100);
if (ImageSearch("BayanClarinet")[0] == 1)
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
MouseClick("Left", Coords.X+315, Coords.Y+310, 1, 0, 0, 10);
MouseMove(Coords.X, Coords.Y, 0);
Thread.Sleep(100);
if (ImageSearch("BayanBassoon")[0] == 1)
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
if (ImageSearchArea("BayanCheckBox", Coords.X+45, Coords.Y+230, Coords.X+100, Coords.Y+260, 0)[0] == 1)
{
VUIObjectSwitcher(false, false, 2, 2);
}
else
{
VUIObjectSwitcher(false, true, 2, 2);
}
if (ImageSearchArea("BayanCheckBox", Coords.X+280, Coords.Y+190, Coords.X+350, Coords.Y+230, 0)[0] == 1)
{
VUIObjectSwitcher(false, true, 7, 7);
}
else
{
VUIObjectSwitcher(false, false, 7, 7);
}
}

public static void Back()
{
VUILoader("LibList");
}

}
}