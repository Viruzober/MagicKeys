using System;
using System.Drawing;

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
if (ITB == null)
{
KeyReg();
OptionKeyReg();
return;
}
string IBWidth = MagicKeys.InputBox("Image width", "Enter image width", 1, P[3]-MP[0]);
if (IBWidth == null)
{
KeyReg();
OptionKeyReg();
return;
}
string IBHeight = MagicKeys.InputBox("Image height", "Enter image height", 1, P[4]-MP[1]);
if (IBHeight == null)
{
KeyReg();
OptionKeyReg();
return;
}
Bitmap Screen = new Bitmap(Convert.ToInt32(IBWidth), Convert.ToInt32(IBHeight));
Graphics g = Graphics.FromImage(Screen);
g.CopyFromScreen(MP[0], MP[1], 00, 0, Screen.Size);
Screen.Save(@"DevSave\"+Module+@"\"+ITB+".bmp");
KeyReg();
OptionKeyReg();
}

}
}