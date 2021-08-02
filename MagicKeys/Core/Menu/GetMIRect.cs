using System;
namespace MagicKeys
{
public partial class MagicKeys
{
public static int[] GetMIRect(IntPtr HWND, IntPtr HMenu, int IdItem)
{
MenuRect MR;
GetMenuItemRect(HWND, HMenu, (uint)IdItem, out MR);
int[] Rect = new int[4] {MR.Left, MR.Top, MR.Right, MR.Bottom};
return Rect;
}
public static int[] GetMIRect(int IdItem)
{
IntPtr HMenu = WinExistsHandle("", "#32768");
IntPtr MIHandle = SendMessage(HMenu, 0x01E1, IdItem, IntPtr.Zero);
MenuRect MR;
GetMenuItemRect(HMenu, MIHandle, (uint)IdItem, out MR);
int[] Rect = new int[4] {MR.Left, MR.Top, MR.Right, MR.Bottom};
return Rect;
}
}
}