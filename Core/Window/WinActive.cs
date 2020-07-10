using System;
using System.Text;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static bool WinActive(string HWNDTitle, string HWNDClass)
{
IntPtr Handle = GetForegroundWindow();
GetWindowText(Handle, Title, nChars);
GetClassName(Handle, Class, nChars);
if (Title.ToString().Contains(HWNDTitle, StringComparison.OrdinalIgnoreCase) & Class.ToString().Contains(HWNDClass, StringComparison.OrdinalIgnoreCase))
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