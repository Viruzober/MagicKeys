using System;
using System.Threading;
using static MagicKeys.MagicKeys;
using static MagicKeys.Kontakt;

namespace MagicKeys
{
public static class IlyaEfimovBayanL
{

public static void AutoAttack()
{
MouseClick("Left", P[1]+45, P[2]+190, 1, 0, 0, 10);
Thread.Sleep(100);
if (ImgSearchArea(@"Images\KontaktIlyaEfimov\BayanCheckBox.bmp", P[1]+45, P[2]+190, P[1]+100, P[2]+230, 0)[0] == 1)
{
Speak("AutoAttack отмечено");
VUIObjectSwitcher(false, "false", 2, 2);
}
else
{
Speak("AutoAttack не отмечено");
VUIObjectSwitcher(false, "true", 2, 2);
}
}

public static void AttackTime()
{
Kontakt.KeyUnReg();
Slider("Attack Time", 45, 230, "H", 0.86, 1.4);
Kontakt.KeyReg();
}

public static void KeyNoise()
{
Kontakt.KeyUnReg();
Slider("Key Noise", 170, 190, "H", 0.86, 1.4);
Kontakt.KeyReg();
}

public static void Bellow()
{
Kontakt.KeyUnReg();
Slider("Bellow", 170, 230, "H", 0.86, 1.4);
Kontakt.KeyReg();
}

public static void Release()
{
Kontakt.KeyUnReg();
Slider("Release", 170, 270, "H", 0.86, 1.4);
Kontakt.KeyReg();
}

public static void Reverb()
{
MouseClick("Left", P[1]+280, P[2]+190, 1, 0, 0, 10);
Thread.Sleep(100);
if (ImgSearchArea(@"Images\KontaktIlyaEfimov\BayanCheckBox.bmp", P[1]+280, P[2]+190, P[1]+350, P[2]+230, 0)[0] == 1)
{
Speak("Reverb отмечено");
VUIObjectSwitcher(false, "true", 7, 7);
}
else
{
Speak("Reverb не отмечено");
VUIObjectSwitcher(false, "false", 7, 7);
}
}

public static void ReverbLevel()
{
Kontakt.KeyUnReg();
Slider("ReverbLevel", 280, 230, "H", 0.86, 1.4);
Kontakt.KeyReg();
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
MouseClick("Left", P[1]+550, P[2]+250, 1, 0, 0, 10);
Speak("Detache включено");
}

public static void Loader()
{
if (ImgSearchArea(@"Images\KontaktIlyaEfimov\BayanCheckBox.bmp", P[1]+45, P[2]+190, P[1]+100, P[2]+230, 0)[0] == 1)
{
VUIObjectSwitcher(false, "false", 2, 2);
}
else
{
VUIObjectSwitcher(false, "true", 2, 2);
}
if (ImgSearchArea(@"Images\KontaktIlyaEfimov\BayanCheckBox.bmp", P[1]+280, P[2]+190, P[1]+350, P[2]+230, 0)[0] == 1)
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
Kontakt.GoToLibList();
}

}
}