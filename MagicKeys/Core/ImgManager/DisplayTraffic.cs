using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void DisplayTraffic(int X, int Y, int W, int H, int CXT, int CYT, int CT)
{
Bitmap ToScreen = new Bitmap(W, H);
Graphics ToG = Graphics.FromImage(ToScreen);
int Count = 0;
while(Count < CT)
{
ToG.CopyFromScreen(X, Y, 00, 0, ToScreen.Size);
for(int XTo = 0; XTo < ToScreen.Width; XTo+=CXT)
{
if (WinActive(API.GetWTitle(), API.GetWClass()) == false) return;
for(int YTo = 0; YTo < ToScreen.Height; YTo+=CYT)
{
Color ToColor = ToScreen.GetPixel(XTo, YTo);
Color OneColor = OneScreen.GetPixel(XTo, YTo);
if (OneColor != ToColor)
{
Count+=1;
if(Count == CT)
{
return;
}
}
}
}
}
}

public static void CreateOneBitmap(int X, int Y, int W, int H)
{
OneScreen = new Bitmap(W, H);
Graphics OneG = Graphics.FromImage(OneScreen);
OneG.CopyFromScreen(X, Y, 00, 0, OneScreen.Size);
}

}
}