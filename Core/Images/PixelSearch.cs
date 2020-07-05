using System;
using System.Drawing;
using System.Threading;
namespace MagicKeys
{
public partial class MagicKeys
{

public static bool PixelSearch(int X, int Y, string Color)
{
Bitmap Screen = new Bitmap(1, 1);
Graphics g = Graphics.FromImage(Screen);
g.CopyFromScreen(X, Y, 00, 0, Screen.Size);
Color GetColor =  Screen.GetPixel(0, 0);
string StrColor = String.Format("#{0:X6}", GetColor.ToArgb() & 0x00FFFFFF);
if (StrColor == Color)
{
return true;
}
return false;
}

}
}