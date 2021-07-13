using System;
using System.Runtime.InteropServices;

namespace MagicKeys
{
    public partial class MagicKeys
{

[StructLayout(LayoutKind.Sequential)]
public struct WinPoint
{
public int X;
public int Y;
}

[StructLayout(LayoutKind.Sequential)]
public struct WinRect
{
public int Left;
public int Top;
public int Right;
public int Bottom;
}

[StructLayout(LayoutKind.Sequential)]
public struct MenuRect
{
public int Left;
public int Top;
public int Right;
public int Bottom;
}

[StructLayout(LayoutKind.Sequential)]
public struct INPUT
{
public InputType type;
public InputUnion U;
}

[StructLayout(LayoutKind.Explicit)]
public struct InputUnion
{
[FieldOffset(0)]
public MouseInputData mi;
[FieldOffset(0)]
public KeyboardInputData ki;
}

[StructLayout(LayoutKind.Sequential)]
public struct MouseInputData
{
public int dx;
public int dy;
public uint mouseData;
public MouseEventFlags dwFlags;
public int time;
public IntPtr dwExtraInfo;
}

[StructLayout(LayoutKind.Sequential)]
public struct KeyboardInputData
{
public int wVk;
public ushort wScan;
public KeyEventFlags dwFlags;
public int time;
public IntPtr dwExtraInfo;
}

[Flags]
public enum MouseEventFlags : uint
{
MOUSEEVENTF_MOVE = 0x0001,
MOUSEEVENTF_MOVE_NOCOALESCE = 0x2000,
MOUSEEVENTF_LEFTDOWN = 0x0002,
MOUSEEVENTF_LEFTUP = 0x0004,
MOUSEEVENTF_RIGHTDOWN = 0x0008,
MOUSEEVENTF_RIGHTUP = 0x0010,
MOUSEEVENTF_MIDDLEDOWN = 0x0020,
MOUSEEVENTF_MIDDLEUP = 0x0040,
MOUSEEVENTF_XDOWN = 0x0080,
MOUSEEVENTF_XUP = 0x0100,
MOUSEEVENTF_WHEEL = 0x0800,
MOUSEEVENTF_VIRTUALDESK = 0x4000,
MOUSEEVENTF_ABSOLUTE = 0x8000
}

[Flags]
public enum KeyEventFlags : uint
{
KeyDown = 0x0000,
ExtendedKey = 0x0001,
KeyUp = 0x0002,
Unicode = 0x0004,
Scancode = 0x0008
}

public enum InputType
{
Mouse = 0,
Keyboard = 1
}

}
}