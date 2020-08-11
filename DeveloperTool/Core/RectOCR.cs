using System;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class DeveloperTool
{

public static void RectOCR()
{
KeyUnReg();
int[] MP = MagicKeys.GetMousePosition();
InputBox W = new InputBox();
W.Text = "OCR Width";
W.InputBoxLabel.Text = "Enter OCR width";
W.Value.Minimum = 30;
W.Value.Maximum = P[3]-MP[0];
W.ShowDialog();
if (W.DialogResult == DialogResult.OK)
{
DP[0] = Convert.ToInt32(W.GetString());
}
else
{
return;
}
InputBox H = new InputBox();
H.Text = "OCR Height";
H.InputBoxLabel.Text = "Enter OCR height";
H.Value.Minimum = 30;
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
return;
}
KeyReg();
}

}
}