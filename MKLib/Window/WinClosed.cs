using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

public static partial class MKLib
{

public static bool WinClosed(string HWNDTitle, string HWNDClass)
{
int nChars = 256;
StringBuilder Title = new StringBuilder(nChars);
StringBuilder Class = new StringBuilder(nChars);
IntPtr Handle = GetForegroundWindow();
GetWindowText(Handle, Title, nChars);
GetClassName(Handle, Class, nChars);
if (Title.ToString().Contains(HWNDTitle) == true && Class.ToString().Contains(HWNDClass) == true)
{
return false;
}
return true;
}

}