using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static int[] ImgSearch(string imgPath, bool Window)
{
IntPtr result;
if (Window == true)
{
int[] RC = GetWinRect(GetForegroundWindow());
result = ImageSearch(RC[0], RC[1], RC[0]+RC[2], RC[1]+RC[3], "*20 "+Path.Combine(API.GetImgPath(), imgPath+".bmp"));
}
else
{
result = ImageSearch(0, 0, Width, Height, "*20 "+Path.Combine(API.GetImgPath(), imgPath+".bmp"));
}
String res = Marshal.PtrToStringAnsi(result);
if (res == "0")
{
int[] Ar = new int[1] {Convert.ToInt32(res)};
return Ar;
}
String[] data = res.Split('|');
int r; int x; int y; int w; int h;
int.TryParse(data[0], out r);
int.TryParse(data[1], out x);
int.TryParse(data[2], out y);
int.TryParse(data[3], out w);
int.TryParse(data[4], out h);
int cx = (w/2)+x;
int cy = (h/2)+y;
int[] pos = new int[7] {r, x, y, w, h, cx, cy};
result = IntPtr.Zero;
return pos;
}

public static int[] ImgSearch(string imgPath)
{
IntPtr result = ImageSearch(0, 0, Width, Height, "*20 "+Path.Combine(API.GetImgPath(), imgPath+".bmp"));
String res = Marshal.PtrToStringAnsi(result);
if (res == "0")
{
int[] Ar = new int[1] {Convert.ToInt32(res)};
return Ar;
}
String[] data = res.Split('|');
int r; int x; int y; int w; int h;
int.TryParse(data[0], out r);
int.TryParse(data[1], out x);
int.TryParse(data[2], out y);
int.TryParse(data[3], out w);
int.TryParse(data[4], out h);
int cx = (w/2)+x;
int cy = (h/2)+y;
int[] pos = new int[7] {r, x, y, w, h, cx, cy};
result = IntPtr.Zero;
return pos;
}

}
}