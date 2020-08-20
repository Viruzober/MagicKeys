using System;
using System.Threading;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void VUFPasteText(string Param)
{
if (CopyText == string.Empty) return;
string[] FP = Param.Split("|");
MouseClick("Left", P[1]+Convert.ToInt32(FP[0]), P[2]+Convert.ToInt32(FP[1]), 1, 0, 0, 10);
Thread.Sleep(50);
if (FP[2] == "Key")
{
Clipboard.SetText(CopyText);
Keyboard.KeyDown(Keys.Control);
Keyboard.KeyDown(Keys.V);
Keyboard.KeyUp(Keys.V);
Keyboard.KeyUp(Keys.Control);
}
else if (FP[2] == "Message")
{
ControlSetTextPoint(P[1]+Convert.ToInt32(FP[0]), P[2]+Convert.ToInt32(FP[1]), CopyText);
}
else if (FP[2] == "Menu")
{
MenuItemClick("Right", P[1]+Convert.ToInt32(FP[0]), P[2]+Convert.ToInt32(FP[1]), 4);
}
}

}
}