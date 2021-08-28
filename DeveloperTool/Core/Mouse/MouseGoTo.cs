using System;
using System.Windows.Forms;
using static MKLib;

namespace DeveloperTool
{

public partial class DeveloperTool
{

public static void MouseGoTo()
{
KeyUnReg();
int[] MP = MKLib.GetMousePosition();
InputBox X = new InputBox();
X.Text = T._("Mouse X");
X.InputBoxLabel.Text = T._("Enter new mouse position X");
X.Value.Minimum = 0;
X.Value.Maximum = Coords.W-Coords.X;
X.ShowDialog();
int NewX;
if (X.DialogResult == DialogResult.OK)
{
NewX = Convert.ToInt32(X.GetString());
}
else
{
KeyReg();
return;
}
InputBox Y = new InputBox();
Y.Text = T._("Mouse Y");
Y.InputBoxLabel.Text = T._("Enter new mouse position Y");
Y.Value.Minimum = 0;
Y.Value.Maximum = Coords.H-Coords.Y;
Y.ShowDialog();
int NewY;
if (Y.DialogResult == DialogResult.OK)
{
NewY = Convert.ToInt32(Y.GetString());
}
else
{
KeyReg();
return;
}
MKLib.MouseMove(Coords.X+NewX, Coords.Y+NewY, 0);
KeyReg();
}

}
}