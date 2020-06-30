using System.Runtime.InteropServices;
using System.Threading;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void MouseButton(string Button, string Event)
{
if (Event == "Down")
{
INPUT mouseDownInput = new INPUT();
mouseDownInput.type = SendInputEventType.InputMouse;
if (Button == "Left")
{
	mouseDownInput.m.mi.dwFlags = MouseEventFlags.MOUSEEVENTF_LEFTDOWN;
}
else if (Button == "Right")
{
mouseDownInput.m.mi.dwFlags = MouseEventFlags.MOUSEEVENTF_RIGHTDOWN;
}
SendInput(1, ref mouseDownInput, Marshal.SizeOf(new INPUT()));
}
else
{
INPUT mouseUpInput = new INPUT();
mouseUpInput.type = SendInputEventType.InputMouse;
if (Button == "Left")
{
mouseUpInput.m.mi.dwFlags = MouseEventFlags.MOUSEEVENTF_LEFTUP;
}
else if (Button == "Right")
{
mouseUpInput.m.mi.dwFlags = MouseEventFlags.MOUSEEVENTF_RIGHTUP;
}
SendInput(1, ref mouseUpInput, Marshal.SizeOf(new INPUT()));
}
}

}
}