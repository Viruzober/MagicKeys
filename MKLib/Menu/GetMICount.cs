﻿using System;

public  static  partial class MKLib
{

public static int GetMICount()
{
IntPtr HMenu = WinExistsHandle("", "#32768");
IntPtr MIHandle = SendMessage(HMenu, 0x01E1, 0, IntPtr.Zero);
int MICount = GetMenuItemCount(MIHandle);
return MICount;
}

}