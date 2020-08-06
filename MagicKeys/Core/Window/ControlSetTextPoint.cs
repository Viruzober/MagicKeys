using System;
using System.Text;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void ControlSetTextPoint(int X, int Y, string SetText)
{
IntPtr CHandle = GetWinPointHandle(X, Y);
SendMessage(CHandle, 0x000C, 0, SetText);
}

}
}