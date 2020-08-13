using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace MagicKeys
{
public partial class MagicKeys
{

[DllImport("user32.dll")]
static extern IntPtr GetDC(IntPtr hWnd);
[DllImport("gdi32.dll")]
static extern int GetDeviceCaps(IntPtr hdc, int nIndex);
[DllImport("user32.dll")]
static extern bool ReleaseDC(IntPtr hWnd, IntPtr hDC);

public static string GetDPI()
{
IntPtr DC = GetDC(IntPtr.Zero);
int LSHeight = GetDeviceCaps(DC, 10);
int PSHeight = GetDeviceCaps(DC, 117);
ReleaseDC(IntPtr.Zero, DC);
float DPI = (float)PSHeight / (float)LSHeight;
return DPI.ToString();
}

}
}