using System;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Serum
{

public static void PresetsMenu()
{
MouseClick("Left", P[1]+665, P[2]+15, 1, 0, 0, 10);
}

public static void PreviousPreset()
{
MouseClick("Left", P[1]+685, P[2]+15, 1, 0, 0, 10);
}

public static void NextPreset()
{
MouseClick("Left", P[1]+705, P[2]+15, 1, 0, 0, 10);
}

public static void Menu()
{
MouseClick("Left", P[1]+765, P[2]+15, 1, 0, 0, 10);
}

public static void SavePresetAs()
{
MouseClick("Left", P[1]+440, P[2]+15, 1, 0, 0, 10);
}

}
}