using System;

public static partial class MKLib
{

public static void ControlSetText(string HWNDTitle, string HWNDClass, string CTRLClass, string SetText)
{
IntPtr WHandle = WinExistsHandle(HWNDTitle, HWNDClass);
IntPtr CHandle = ControlExistsHandle(WHandle, "", CTRLClass);
SendMessage(CHandle, 0x000C, 0, SetText);
}

}