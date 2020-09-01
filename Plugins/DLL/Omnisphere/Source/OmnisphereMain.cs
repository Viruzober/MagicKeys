using System;
using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Omnisphere
{

public static void MainTab()
{
MouseClick("Left", P[1]+545, P[2]+210, 1, 0, 0, 10);
VUILoader("OmnisphereMain");
}

public static void MainVoiceMenu()
{
MouseClick("Left", P[1]+335, P[2]+270, 1, 0, 0, 10);
}

public static void MainOctaveMenu()
{
MouseClick("Left", P[1]+410, P[2]+270, 1, 0, 0, 10);
}

public static void MainScaleMenu()
{
MouseClick("Left", P[1]+370, P[2]+325, 1, 0, 0, 10);
}

public static void MainClockSpeedMenu()
{
MouseClick("Left", P[1]+370, P[2]+375, 1, 0, 0, 10);
}

public static void MainSignalPathMenu()
{
MouseClick("Left", P[1]+370, P[2]+430, 1, 0, 0, 10);
}

public static void MainLutchButton()
{
MouseClick("Left", P[1]+345, P[2]+480, 1, 0, 0, 10);
Thread.Sleep(100);
Speak(CheckStateImg("Lutch", P[1]+325, P[2]+460, P[1]+365, P[2]+500));
}

}
}