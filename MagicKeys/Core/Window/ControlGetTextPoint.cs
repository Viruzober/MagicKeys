using System;
using System.Text;

namespace MagicKeys
{

public partial class MagicKeys
{

public static string ControlGetTextPoint(int X, int Y)
{
StringBuilder B = new StringBuilder(256);
IntPtr Handle = GetWinPointHandle(X, Y);
SendMessage(Handle, WM.WM_GETTEXT, 256, B);
return B.ToString();
}

}
}