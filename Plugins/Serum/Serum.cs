using System;
using System.Windows.Forms;
using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Serum
{

public static void PresetsMenu()
{
WindowMover(-P[1]+30, 0, true);
MouseClick("Left", P[1]+665, P[2]+15, 1, 0, 0, 10);
WindowMover(DP[1], DP[2], false);
}

public static void PreviousPreset()
{
WindowMover(-P[1]+30, 0, true);
MouseClick("Left", P[1]+685, P[2]+15, 1, 0, 0, 10);
WindowMover(DP[1], DP[2], false);
}

public static void NextPreset()
{
WindowMover(-P[1]+30, 0, true);
MouseClick("Left", P[1]+705, P[2]+15, 1, 0, 0, 10);
WindowMover(DP[1], DP[2], false);
}

public static void Menu()
{
WindowMover(-P[1]+30, 0, true);
MouseClick("Left", P[1]+765, P[2]+15, 1, 0, 0, 10);
WindowMover(DP[1], DP[2], false);
}

public static void SavePresetAs()
{
WindowMover(-P[1]+30, 0, true);
MouseClick("Left", P[1]+440, P[2]+15, 1, 0, 0, 10);
WindowMover(DP[1], DP[2], false);
}

public static void Normalize()
{
MouseClick("Left", P[1]+20, P[2]+20, 1, 0, 0, 10);
Thread.Sleep(50);
IntPtr HWND = WinExistsHandle("", "#32768");
IntPtr HMenu = SendMessage(HWND, 0x01E1, 0, IntPtr.Zero);
int[] MRect = GetMIRect(HWND, HMenu, 3);
MouseClick("Left", MRect[0]+15, MRect[1]+15, 1, 0, 0, 10);
Speak("Перезагрузите плагин");
}

public static void Register()
{
MouseClick("Left", P[1]+345, P[2]+45, 1, 0, 0, 10);
MouseClick("Right", P[1]+345, P[2]+45, 1, 0, 0, 10);
Thread.Sleep(50);
IntPtr HWND = WinExistsHandle("", "#32768");
IntPtr HMenu = SendMessage(HWND, 0x01E1, 0, IntPtr.Zero);
int[] MRect = GetMIRect(HWND, HMenu, 4);
MouseClick("Left", MRect[0]+15, MRect[1]+15, 1, 0, 0, 10);
Thread.Sleep(50);
MouseClick("Left", P[1]+705, P[2]+325, 2, 0, 0, 10);
Speak("Перезагрузите плагин");
}

}
}