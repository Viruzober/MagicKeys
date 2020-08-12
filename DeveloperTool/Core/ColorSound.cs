using System;
using System.Drawing;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class DeveloperTool
{

public static void ColorSound()
{
if (ColorMod == 0) return;
int[] MP = MagicKeys.GetMousePosition();
Bitmap Screen = new Bitmap(1, 1);
Graphics g = Graphics.FromImage(Screen);
g.CopyFromScreen(MP[0], MP[1], 00, 0, Screen.Size);
Color GetColor =  Screen.GetPixel(0, 0);
int Color = GetColor.A+GetColor.R+GetColor.G+GetColor.B;
SoundBeep(Color);
}

}
}