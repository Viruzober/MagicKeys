using System;
using System.Text;

namespace MagicKeys
{

public partial class MagicKeys
{

public static string ControlGetText(string HWNDTitle, string HWNDClass, string CTRLClass)
{
int nChars = 256;
StringBuilder Text = new StringBuilder(nChars);
IntPtr WHandle = WinExistsHandle(HWNDTitle, HWNDClass);
IntPtr CHandle = ControlExistsHandle(WHandle, "", CTRLClass);
GetWindowText(CHandle, Text, nChars);
return Text.ToString();
}

}
}