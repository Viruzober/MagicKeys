using System;
using System.Runtime.InteropServices;

namespace MagicKeys
{
public static class VirtualScreenExtender
{
const double MaxMouseEventCoords = 65535.0;
private static readonly double PositionToMouseEventX;
private static readonly double MouseEventToPositionX;
private static readonly double PositionToMouseEventY;
private static readonly double MouseEventToPositionY;

private enum SystemMetric
{
SM_CXSCREEN = 0,
SM_CYSCREEN = 1
}
 
[DllImport("gdi32.dll")]
private static extern int GetDeviceCaps(IntPtr hdc, int nIndex);
 
[DllImport("user32.dll")]
private static extern IntPtr GetDC(IntPtr hWnd);
 
[DllImport("user32.dll")]
private static extern int GetSystemMetrics(SystemMetric smIndex);
 
private const int LOGPIXELSX = 88;
private const int LOGPIXELSY = 90;
  
public static Tuple<int,int> MousePosition(int mouseEventCoordsX, int mouseEventCoordsY)
{
if (mouseEventCoordsX < 0 || mouseEventCoordsX > MaxMouseEventCoords)
throw new ArgumentOutOfRangeException("mouseEventCoordsX");
if (mouseEventCoordsY < 0 || mouseEventCoordsY > MaxMouseEventCoords)
throw new ArgumentOutOfRangeException("mouseEventCoordsY");
return new Tuple<int, int>((int)(mouseEventCoordsX * MouseEventToPositionX), (int)(mouseEventCoordsY * MouseEventToPositionY)); 
}
 
public static Tuple<int,int> MouseEventCoords(int mousePositionX, int mousePositionY)
{
//if (mousePositionX < 0 || mousePositionX > Width)
//throw new ArgumentOutOfRangeException("mousePositionX");
//if (mousePositionY < 0 || mousePositionY > Height)
//throw new ArgumentOutOfRangeException("mousePositionY");
return new Tuple<int, int>((int)(mousePositionX * PositionToMouseEventX), (int)(mousePositionY * PositionToMouseEventY));
}
 
static VirtualScreenExtender()
{
IntPtr hdc = GetDC(IntPtr.Zero);
DpiX = GetDeviceCaps(hdc, LOGPIXELSX);
DpiY = GetDeviceCaps(hdc, LOGPIXELSY);
Width = GetSystemMetrics(SystemMetric.SM_CXSCREEN);
Height = GetSystemMetrics(SystemMetric.SM_CYSCREEN);
PositionToMouseEventX = MaxMouseEventCoords/Width;
PositionToMouseEventY = MaxMouseEventCoords / Height;
MouseEventToPositionX = 1/PositionToMouseEventX;
MouseEventToPositionY = 1 / PositionToMouseEventY;
}
 
public static int DpiX { get; private set; }
public static int DpiY { get; private set; }
public static int Width { get; private set; }
public static int Height { get; private set; }
 
}
}