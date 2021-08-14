using System;
using System.Text;

namespace MagicKeys
{

public partial class MagicKeys
{

public static string GetMIText(int ID)
{
int nChars = 256;
StringBuilder Text = new StringBuilder(nChars);
IntPtr HMenu = WinExistsHandle("", "#32768");
IntPtr MIHandle = SendMessage(HMenu, 0x01E1, 0, IntPtr.Zero);
GetMenuString(MIHandle, (uint)ID, Text, nChars, (uint)0x00000400L);
return Text.ToString();
}

}
}