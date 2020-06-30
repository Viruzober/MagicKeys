using System;
using System.Threading;
using static MagicKeys.MagicKeys;

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
VUIObjectSwitcher(false, false, 2, 2);
}
else
{
Speak("AutoAttack не отмечено");
VUIObjectSwitcher(false, true, 2, 2);
}
}

public static void AttackTime()
{
Kontakt.KeyUnReg();
int Input = Convert.ToInt32(InputBox("Attack Time", "Введите значение для Attack Time от 1 до 100", 1, 100));
MouseClickDrag("Left", P[1]+45, P[2]+230, 0, P[2]+230, 1, 10);
int V = Convert.ToInt32(P[1]+45+((Input*0.86)*1.4));
MouseClickDrag("Left", P[1]+45, P[2]+230, V, P[2]+230, 1, 10);
Kontakt.KeyReg();
Speak("OK");
}

public static void KeyNoise()
{
Kontakt.KeyUnReg();
int Input = Convert.ToInt32(InputBox("Key Noise", "Введите значение для Key Noise от 1 до 100", 1, 100));
MouseClickDrag("Left", P[1]+170, P[2]+190, 0, P[2]+190, 1, 10);
int V = Convert.ToInt32(P[1]+170+((Input*0.86)*1.4));
MouseClickDrag("Left", P[1]+170, P[2]+190, V, P[2]+190, 1, 10);
Kontakt.KeyReg();
Speak("OK");
}

public static void Bellow()
{
Kontakt.KeyUnReg();
int Input = Convert.ToInt32(InputBox("Bellow", "Введите значение для Bellow от 1 до 100", 1, 100));
MouseClickDrag("Left", P[1]+170, P[2]+230, 0, P[2]+230, 1, 10);
int V = Convert.ToInt32(P[1]+170+((Input*0.86)*1.4));
MouseClickDrag("Left", P[1]+170, P[2]+230, V, P[2]+230, 1, 10);
Kontakt.KeyReg();
Speak("OK");
}

public static void Release()
{
Kontakt.KeyUnReg();
int Input = Convert.ToInt32(InputBox("Release", "Введите значение для Release от 1 до 100", 1, 100));
MouseClickDrag("Left", P[1]+170, P[2]+270, P[1], P[2]+270, 1, 10);
int V = Convert.ToInt32(P[1]+170+((Input*0.86)*1.4));
MouseClickDrag("Left", P[1]+170, P[2]+270, V, P[2]+270, 1, 10);
Kontakt.KeyReg();
Speak("OK");
}

public static void Reverb()
{
MouseClick("Left", P[1]+280, P[2]+190, 1, 0, 0, 10);
Thread.Sleep(100);
if (ImgSearchArea(@"Images\KontaktIlyaEfimov\BayanCheckBox.bmp", P[1]+280, P[2]+190, P[1]+350, P[2]+230, 0)[0] == 1)
{
Speak("Reverb отмечено");
VUIObjectSwitcher(false, true, 7, 7);
}
else
{
Speak("Reverb не отмечено");
VUIObjectSwitcher(false, false, 7, 7);
}
}

public static void ReverbLevel()
{
Kontakt.KeyUnReg();
int Input = Convert.ToInt32(InputBox("Reverb Level", "Введите значение для Reverb Level от 1 до 100", 1, 100));
MouseClickDrag("Left", P[1]+280, P[2]+230, 0, P[2]+230, 1, 10);
int V = Convert.ToInt32(P[1]+280+((Input*0.86)*1.4));
MouseClickDrag("Left", P[1]+280, P[2]+230, V, P[2]+230, 1, 10);
Kontakt.KeyReg();
Speak("OK");
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
VUIObjectSwitcher(false, false, 2, 2);
}
else
{
VUIObjectSwitcher(false, true, 2, 2);
}
if (ImgSearchArea(@"Images\KontaktIlyaEfimov\BayanCheckBox.bmp", P[1]+280, P[2]+190, P[1]+350, P[2]+230, 0)[0] == 1)
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
Kontakt.GoToLibList();
}

}
}