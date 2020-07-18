using System;
using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Omnisphere
{

public static void Search()
{
MouseClick("Left", P[1]+35, P[2]+85, 1, 0, 0, 10);
}

public static void Category()
{
MouseClick("Left", P[1]+40, P[2]+150, 1, 0, 0, 10);
Thread.Sleep(100);
MouseClick("Left", P[1]+220, P[2]+170, 1, 0, 0, 10);
Thread.Sleep(100);
MouseClick("Left", P[1]+220, P[2]+400, 1, 0, 0, 10);
Speak("OK");
}

public static void Type()
{
MouseClick("Left", P[1]+100, P[2]+150, 1, 0, 0, 10);
Thread.Sleep(100);
MouseClick("Left", P[1]+220, P[2]+170, 1, 0, 0, 10);
Thread.Sleep(100);
MouseClick("Left", P[1]+220, P[2]+400, 1, 0, 0, 10);
Speak("OK");
}

public static void Genre()
{
MouseClick("Left", P[1]+160, P[2]+150, 1, 0, 0, 10);
Thread.Sleep(100);
MouseClick("Left", P[1]+220, P[2]+170, 1, 0, 0, 10);
Thread.Sleep(100);
MouseClick("Left", P[1]+220, P[2]+400, 1, 0, 0, 10);
Speak("OK");
}

public static void SelectChennel()
{
int Input = Convert.ToInt32(InputBox("Select chennel", "Enter chennel number.", 1, 8));
int CH = Input*35;
MouseClick("Left", P[1]+485+CH, P[2]+55, 1, 0, 0, 10);
}

}
}