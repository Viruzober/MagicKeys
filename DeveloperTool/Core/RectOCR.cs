using System;
using System.Windows.Forms;

namespace MagicKeys
{

public partial class DeveloperTool
{

public static void RectOCR()
{
KeyUnReg();
OptionKeyUnReg();
int[] MP = MagicKeys.GetMousePosition();
InputBox W = new InputBox();
W.Text = T._("OCR Width");
W.InputBoxLabel.Text = T._("Enter OCR width:");
W.Value.Minimum = 10;
W.Value.Maximum = P[3]-MP[0];
W.ShowDialog();
if (W.DialogResult == DialogResult.OK)
{
DP[0] = Convert.ToInt32(W.GetString());
}
else
{
KeyReg();
OptionKeyReg();
return;
}
InputBox H = new InputBox();
H.Text = T._("OCR Height");
H.InputBoxLabel.Text = T._("Enter OCR height:");
H.Value.Minimum = 10;
H.Value.Maximum = P[4]-MP[1];
H.ShowDialog();
if (H.DialogResult == DialogResult.OK)
{
DP[1] = Convert.ToInt32(H.GetString());
}
else
{
DP[0] = 0;
DP[1] = 0;
}
KeyReg();
OptionKeyReg();
}

}
}