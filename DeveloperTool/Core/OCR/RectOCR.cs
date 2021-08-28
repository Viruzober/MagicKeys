using System;
using System.Windows.Forms;
using static MKLib;

namespace DeveloperTool
{

public partial class DeveloperTool
{

public static void RectOCR()
{
KeyUnReg();
InputBox W = new InputBox();
W.Text = T._("OCR Width");
W.InputBoxLabel.Text = T._("Enter OCR width:");
W.Value.Minimum = 10;
W.Value.Maximum = Coords.W;
W.ShowDialog();
if (W.DialogResult == DialogResult.OK)
{
OCRSize[0] = Convert.ToInt32(W.GetString());
}
else
{
KeyReg();
return;
}
InputBox H = new InputBox();
H.Text = T._("OCR Height");
H.InputBoxLabel.Text = T._("Enter OCR height:");
H.Value.Minimum = 10;
H.Value.Maximum = Coords.H;
H.ShowDialog();
if (H.DialogResult == DialogResult.OK)
{
OCRSize[1] = Convert.ToInt32(H.GetString());
}
else
{
OCRSize[0] = 0;
OCRSize[1] = 0;
}
KeyReg();
}

}
}