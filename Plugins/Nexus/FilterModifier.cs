using System;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Nexus
{

public static void FilterModifierOnOff()
{
MouseClick("Left", P[1]+95, P[2]+80, 1, 0, 0, 10);
CheckBox(P[1]+90, P[2]+60, "#3AA1FF", "FilterModifier");
}

public static void FilterModifierEnv()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("Env", "Введите значение для Env от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+150, P[2]+70, P[1]+150, Height-10, 0, 10);
int V = P[2] + 70 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+150, P[2]+70, P[1]+150, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

public static void FilterModifierCutOff()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("CutOff", "Введите значение для CutOff от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+95, P[2]+130, P[1]+95, Height-10, 0, 10);
int V = P[2] + 130 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+95, P[2]+130, P[1]+95, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

public static void FilterModifierRes()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("Res", "Введите значение для Res от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+150, P[2]+130, P[1]+150, Height-10, 0, 10);
int V = P[2] + 130 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+150, P[2]+130, P[1]+150, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

public static void FilterModifierAfk()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("Afk", "Введите значение для Afk от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+95, P[2]+205, P[1]+95, Height-10, 0, 10);
int V = P[2] + 205 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+95, P[2]+205, P[1]+95, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

public static void FilterModifierDec()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("Dec", "Введите значение для Dec от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+150, P[2]+205, P[1]+150, Height-10, 0, 10);
int V = P[2] + 205 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+150, P[2]+205, P[1]+150, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

public static void FilterModifierSus()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("Sus", "Введите значение для Sus от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+95, P[2]+265, P[1]+95, Height-10, 0, 10);
int V = P[2] + 265 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+95, P[2]+265, P[1]+95, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

public static void FilterModifierRel()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("Rel", "Введите значение для Rel от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+150, P[2]+265, P[1]+150, Height-10, 0, 10);
WindowMover(50, Height-10/2, false);
int V = P[2] + 265 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+150, P[2]+265, P[1]+150, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

}
}