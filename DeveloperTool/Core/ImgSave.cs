using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace MagicKeys
{
public partial class DeveloperTool
{

public static void ImgSave()
{
KeyUnReg();
OptionKeyUnReg();
int[] MP = MagicKeys.GetMousePosition();
string ITB = MagicKeys.InputTextBox(T._("Image name"), T._("Enter image name."));
if (ITB == "0")
{
KeyReg();
OptionKeyReg();
return;
}
int Width = Convert.ToInt32(MagicKeys.InputBox("Image width", "Enter image width", 1, P[3]-MP[0]));
if (Width == 0)
{
KeyReg();
OptionKeyReg();
return;
}
int Height = Convert.ToInt32(MagicKeys.InputBox("Image height", "Enter image height", 1, P[4]-MP[1]));
if (Height == 0)
{
KeyReg();
OptionKeyReg();
return;
}
Bitmap Screen = new Bitmap(Width, Height);
Graphics g = Graphics.FromImage(Screen);
g.CopyFromScreen(MP[0]-(Width/2), MP[1]-(Height/2), 00, 0, Screen.Size);
Screen.Save(@"DevSave\"+Module+@"\"+ITB+".bmp");
}

}
}