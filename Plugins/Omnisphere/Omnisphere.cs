using System;
using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Omnisphere
{

public static void Search()
{
MouseClick("Left", P[1]+30, P[2]+70, 1, 0, 0, 10);
}

public static void Category()
{
MouseClick("Left", P[1]+35, P[2]+125, 1, 0, 0, 10);
Thread.Sleep(100);
MouseClick("Left", P[1]+185, P[2]+140, 2, 0, 0, 10);
Thread.Sleep(100);
MouseClick("Left", P[1]+185, P[2]+325, 2, 0, 0, 10);
Speak("OK");
}

public static void Type()
{
MouseClick("Left", P[1]+85, P[2]+125, 1, 0, 0, 10);
Thread.Sleep(100);
MouseClick("Left", P[1]+185, P[2]+140, 2, 0, 0, 10);
Thread.Sleep(100);
MouseClick("Left", P[1]+185, P[2]+325, 2, 0, 0, 10);
Speak("OK");
}

public static void Genre()
{
MouseClick("Left", P[1]+135, P[2]+125, 1, 0, 0, 10);
Thread.Sleep(100);
MouseClick("Left", P[1]+185, P[2]+140, 2, 0, 0, 10);
Thread.Sleep(100);
MouseClick("Left", P[1]+185, P[2]+325, 2, 0, 0, 10);
Speak("OK");
}

}
}