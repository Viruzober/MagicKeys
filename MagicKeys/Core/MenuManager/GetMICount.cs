using System;

namespace MagicKeys
{
public partial class MagicKeys
{

public static int GetMICount()
{
IntPtr HWND = WinExistsHandle("", "#32768");
IntPtr HMenu = SendMessage(HWND, 0x01E1, 0, IntPtr.Zero);
int MICount = GetMenuItemCount(HMenu);
return MICount;
}

}
}