using System;
using System.Text;

namespace MagicKeys
{

public partial class MagicKeys
{

public static bool WinActive(string HWNDTitle, string HWNDClass)
{
int nChars = 256;
StringBuilder Title = new StringBuilder(nChars);
StringBuilder Class = new StringBuilder(nChars);
IntPtr Handle = GetForegroundWindow();
GetWindowText(Handle, Title, nChars);
GetClassName(Handle, Class, nChars);
if (Title.ToString().Contains(HWNDTitle) & Class.ToString().Contains(HWNDClass))
{
return true;
}
else
{
return false;
}
}

}
}