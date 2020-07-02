using System;
using System.Drawing;
using System.Threading;
namespace MagicKeys
{
public partial class MagicKeys
{
public static bool CheckBox(int X, int Y, string Color, string Text)
{
MouseMove(X+15, Y+15, 0);
Thread.Sleep(100);
Bitmap Screen = new Bitmap(8, 8);
Graphics g = Graphics.FromImage(Screen);
g.CopyFromScreen(X-4, Y-4, 00, 0, Screen.Size);
for (int GetX = 0; GetX <= 7; GetX++)
{
for (int GetY = 0; GetY <= 7; GetY++)
{
Color GetColor =  Screen.GetPixel(GetX, GetY);
string StrColor = String.Format("#{0:X6}", GetColor.ToArgb() & 0x00FFFFFF);
if (StrColor == Color)
{
Speak(Text+" отмечено");
return true;
}
}
}
Speak(Text+" Не отмечено");
return false;
}

}
}