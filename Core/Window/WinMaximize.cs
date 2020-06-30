using System;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void WinMaximize(string HWNDTitle, string HWNDClass)
{
IntPtr Handle = WinExistsHandle(HWNDTitle, HWNDClass);
MoveWindow(Handle, 0, 0, Width, Height, true);
}

}
}