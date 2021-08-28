using System;
using System.Drawing;

namespace DeveloperTool
{

public partial class DeveloperTool
{

public static void ImgSave()
{
int[] MP = MKLib.GetMousePosition();
string ITB = MKLib.InputTextBox(T._("Image name"), T._("Enter image name."));
if (ITB == null)
{
return;
}
string IBWidth = MKLib.InputBox("Image width", "Enter image width", 1, Coords.W-MP[0]);
if (IBWidth == null)
{
return;
}
string IBHeight = MKLib.InputBox("Image height", "Enter image height", 1, Coords.H-MP[1]);
if (IBHeight == null)
{
return;
}
Bitmap Screen = new Bitmap(Convert.ToInt32(IBWidth), Convert.ToInt32(IBHeight));
Graphics g = Graphics.FromImage(Screen);
g.CopyFromScreen(MP[0], MP[1], 00, 0, Screen.Size);
Screen.Save(@"DevSave\"+ModuleName+@"\"+ITB+".bmp");
}

}
}