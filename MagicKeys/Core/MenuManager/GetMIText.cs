using System;

namespace MagicKeys
{
public partial class MagicKeys
{

public static string GetMIText(int ID)
{
IntPtr HWND = WinExistsHandle("", "#32768");
IntPtr HMenu = SendMessage(HWND, 0x01E1, 0, IntPtr.Zero);
GetMenuString(HMenu, (uint)ID, Text, nChars, (uint)0x00000400L);
return Text.ToString();
}

}
}