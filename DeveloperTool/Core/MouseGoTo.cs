using System;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class DeveloperTool
{

public static void MouseGoTo()
{
KeyUnReg();
OptionKeyUnReg();
int[] MP = MagicKeys.GetMousePosition();
InputBox X = new InputBox();
X.Text = "Mouse X";
X.InputBoxLabel.Text = "Enter new mouse position X";
X.Value.Minimum = 0;
X.Value.Maximum = P[3]-P[1];
X.ShowDialog();
int NewX;
if (X.DialogResult == DialogResult.OK)
{
NewX = Convert.ToInt32(X.GetString());
}
else
{
KeyReg();
OptionKeyReg();
return;
}
InputBox Y = new InputBox();
Y.Text = "Mouse Y";
Y.InputBoxLabel.Text = "Enter new mouse position Y";
Y.Value.Minimum = 0;
Y.Value.Maximum = P[4]-P[2];
Y.ShowDialog();
int NewY;
if (Y.DialogResult == DialogResult.OK)
{
NewY = Convert.ToInt32(Y.GetString());
}
else
{
KeyReg();
OptionKeyReg();
return;
}
MagicKeys.MouseMove(P[1]+NewX, P[2]+NewY, 0);
KeyReg();
OptionKeyReg();
}

}
}