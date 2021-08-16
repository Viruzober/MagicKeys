using System;
using System.Runtime.InteropServices;

public static partial class MKLib
{
const uint CF_UNICODETEXT = 13;
public static string GetText()
{
if (!IsClipboardFormatAvailable(CF_UNICODETEXT))
{
return null;
}
if (!OpenClipboard(IntPtr.Zero))
{
return null;
}
string data = null;
var hGlobal = GetClipboardData(CF_UNICODETEXT);
if (hGlobal != IntPtr.Zero)
{
var lpwcstr = GlobalLock(hGlobal);
if (lpwcstr != IntPtr.Zero)
{
data = Marshal.PtrToStringUni(lpwcstr);
GlobalUnlock(lpwcstr);
}
}
CloseClipboard();
return data;
}

}