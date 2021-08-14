using System.Runtime.InteropServices;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void MouseMove (int GetX, int GetY, int TimeMove)
{
int X = GetX, Y = GetY;
if (GetX >= GetDisplayResolution().Width)
{
X = GetDisplayResolution().Width-1;
}

if (GetY >= GetDisplayResolution().Height)
{
Y = GetDisplayResolution().Height-1;
}

if (GetX <= 0)
{
X = 0;
}

if (GetY <= 0)
{
Y = 0;
}

INPUT mouseMoveInput = new INPUT();
int[] MP = GetMousePosition();
for (int MX = MP[0], MY = MP[1]; MX != X || MY != Y; MX = NumberAlign(MX, X), MY = NumberAlign(MY, Y))
{
Sleep(TimeMove);
mouseMoveInput.type = InputType.Mouse;
mouseMoveInput.U.mi.dwFlags = MouseEventFlags.MOUSEEVENTF_MOVE | MouseEventFlags.MOUSEEVENTF_ABSOLUTE;
mouseMoveInput.U.mi.dx = MouseConvertX(MX);
mouseMoveInput.U.mi.dy = MouseConvertY(MY);
SendInput(1, ref mouseMoveInput, Marshal.SizeOf(new INPUT()));
}
while(true)
{
MP = GetMousePosition();
if (MP[0] == X & MP[1] ==Y)
{
return;
}
mouseMoveInput.type = InputType.Mouse;
mouseMoveInput.U.mi.dwFlags = MouseEventFlags.MOUSEEVENTF_MOVE;
if (MP[0] < X)
{
mouseMoveInput.U.mi.dx = 1;
}
else if (MP[0] > X)
{
mouseMoveInput.U.mi.dx = -1;
}
else if (MP[0] == X)
{
mouseMoveInput.U.mi.dx = 0;
}
if (MP[1] < Y)
{
mouseMoveInput.U.mi.dy = 1;
}
else if (MP[1] > Y)
{
mouseMoveInput.U.mi.dy = -1;
}
else if (MP[1] == Y)
{
mouseMoveInput.U.mi.dy = 0;
}
SendInput(1, ref mouseMoveInput, Marshal.SizeOf(new INPUT()));
}
}

}
}