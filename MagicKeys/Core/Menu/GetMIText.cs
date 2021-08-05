using System;

namespace MagicKeys
{
public partial class MagicKeys
{
public static string GetMIText(int ID)
{
IntPtr HMenu = WinExistsHandle("", "#32768");
IntPtr MIHandle = SendMessage(HMenu, 0x01E1, 0, IntPtr.Zero);
GetMenuString(MIHandle, (uint)ID, Text, nChars, (uint)0x00000400L);
return Text.ToString();
}

}
}