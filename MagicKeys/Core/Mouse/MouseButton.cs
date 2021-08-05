using System.Runtime.InteropServices;

namespace MagicKeys
{
public partial class MagicKeys
{
public static void MouseButton(string Button, string Event)
{
if (Event == "Down")
{
INPUT mouseDownInput = new INPUT();
mouseDownInput.type = InputType.Mouse;
if (Button == "Left")
{
mouseDownInput.U.mi.dwFlags = MouseEventFlags.MOUSEEVENTF_LEFTDOWN;
}
else if (Button == "Right")
{
mouseDownInput.U.mi.dwFlags = MouseEventFlags.MOUSEEVENTF_RIGHTDOWN;
}
SendInput(1, ref mouseDownInput, Marshal.SizeOf(new INPUT()));
}
else
{
INPUT mouseUpInput = new INPUT();
mouseUpInput.type = InputType.Mouse;
if (Button == "Left")
{
mouseUpInput.U.mi.dwFlags = MouseEventFlags.MOUSEEVENTF_LEFTUP;
}
else if (Button == "Right")
{
mouseUpInput.U.mi.dwFlags = MouseEventFlags.MOUSEEVENTF_RIGHTUP;
}
SendInput(1, ref mouseUpInput, Marshal.SizeOf(new INPUT()));
}
}

}
}