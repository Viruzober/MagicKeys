using System;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Nexus
{

public static void OutputVol()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("Vol", "Введите значение для Vol от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+720, P[2]+415, P[1]+720, Height-10, 0, 10);
int V = P[2] + 415 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+720, P[2]+415, P[1]+720, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

}
}