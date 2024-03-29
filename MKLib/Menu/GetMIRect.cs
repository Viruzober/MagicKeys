using System;

public  static  partial class MKLib
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
if (HMenu != IntPtr.Zero)
{
IntPtr MIHandle = SendMessage(HMenu, 0x01E1, IdItem, IntPtr.Zero);
MenuRect MR;
GetMenuItemRect(HMenu, MIHandle, (uint)IdItem, out MR);
int[] Rect = new int[4] {MR.Left, MR.Top, MR.Right, MR.Bottom};
return Rect;
}
return new int[4] {0, 0, 0, 0};
}

}