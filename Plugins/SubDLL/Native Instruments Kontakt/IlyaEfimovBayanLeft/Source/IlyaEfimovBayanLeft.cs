using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{

public class IlyaEfimovBayanLeft
{

public static void AutoAttack()
{
MouseClick("Left", Coords.X+45, Coords.Y+190, 1, 0, 0, 10);
Thread.Sleep(100);
if (ImgSearchArea("BayanCheckBox", Coords.X+45, Coords.Y+190, Coords.X+100, Coords.Y+230, 0)[0] == 1)
{
Speak("AutoAttack checked");
VUIObjectSwitcher(false, "false", 1, 1);
}
else
{
Speak("AutoAttack not checked");
VUIObjectSwitcher(false, "true", 1, 1);
}
}

public static void AttackTime()
{
Slider("Attack Time", 45, 230, "H", 0.86, 1.4);
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
if (ImgSearchArea("BayanCheckBox", Coords.X+280, Coords.Y+190, Coords.X+350, Coords.Y+230, 0)[0] == 1)
{
Speak("Reverb checked");
VUIObjectSwitcher(false, "true", 6, 6);
}
else
{
Speak("Reverb not checked");
VUIObjectSwitcher(false, "false", 6, 6);
}
}

public static void ReverbLevel()
{
Slider("ReverbLevel", 280, 230, "H", 0.86, 1.4);
}

public static void Sustain()
{
MouseClick("Left", Coords.X+550, Coords.Y+190, 1, 0, 0, 10);
Speak("Sustain on");
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
MouseClick("Left", Coords.X+550, Coords.Y+250, 1, 0, 0, 10);
Speak("Detache on");
}

public static void IlyaEfimovBayanLeftLoader()
{
if (ImgSearchArea("BayanCheckBox", Coords.X+45, Coords.Y+190, Coords.X+100, Coords.Y+230, 0)[0] == 1)
{
VUIObjectSwitcher(false, "false", 1, 1);
}
else
{
VUIObjectSwitcher(false, "true", 1, 1);
}
if (ImgSearchArea("BayanCheckBox", Coords.X+280, Coords.Y+190, Coords.X+350, Coords.Y+230, 0)[0] == 1)
{
VUIObjectSwitcher(false, "true", 6, 6);
}
else
{
VUIObjectSwitcher(false, "false", 6, 6);
}
}

public static void Back()
{
SubPluginUnLoad();
Kontakt.GoToLibList();
}

}
}