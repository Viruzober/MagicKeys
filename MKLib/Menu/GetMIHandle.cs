using System;

public  static  partial class MKLib
{

public static IntPtr GetMIHandle()
{
IntPtr HMenu = WinExistsHandle("", "#32768");
IntPtr MIHandle = SendMessage(HMenu, 0x01E1, 0, IntPtr.Zero);
return MIHandle;
}

}