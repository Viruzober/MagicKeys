using System;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Nexus
{

public static void AmpModifierOnOff()
{
MouseClick("Left", P[1]+685, P[2]+80, 1, 0, 0, 10);
CheckBox(P[1]+685, P[2]+60, "#3AA1FF", "Amp modifier");
}

public static void AmpModifierPan()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("Pan", "Введите значение для Pan от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+745, P[2]+70, P[1]+745, Height-10, 0, 10);
int V = P[2] + 70 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+745, P[2]+70, P[1]+745, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

public static void AmpModifierSpread()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("Spread", "Введите значение для Spread от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+745, P[2]+130, P[1]+745, Height-10, 0, 10);
int V = P[2] + 130 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+745, P[2]+130, P[1]+745, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

public static void AmpModifierSpike()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("Spike", "Введите значение для Spike от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+685, P[2]+130, P[1]+685, Height-10, 0, 10);
int V = P[2] + 130 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+685, P[2]+130, P[1]+685, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

public static void AmpModifierDec()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("Dec", "Введите значение для Dec от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+745, P[2]+205, P[1]+745, Height-10, 0, 10);
int V = P[2] + 205 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+745, P[2]+205, P[1]+745, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

public static void AmpModifierAfk()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("Afk", "Введите значение для Afk от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+685, P[2]+205, P[1]+685, Height-10, 0, 10);
int V = P[2] + 205 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+685, P[2]+205, P[1]+685, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

public static void AmpModifierRel()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("Rel", "Введите значение для Rel от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+745, P[2]+265, P[1]+745, Height-10, 0, 10);
int V = P[2] + 265 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+745, P[2]+265, P[1]+745, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

public static void AmpModifierSus()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("Sus", "Введите значение для Sus от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+685, P[2]+265, P[1]+685, Height-10, 0, 10);
int V = P[2] + 265 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+685, P[2]+265, P[1]+685, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

}
}