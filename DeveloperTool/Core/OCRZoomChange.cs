using System;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class DeveloperTool
{

public static void OCRZoomChange()
{
KeyUnReg();
OptionKeyUnReg();
InputBox IB = new InputBox();
IB.Text = "OCR Zoom";
IB.InputBoxLabel.Text = "Enter OCR Zoom";
IB.Value.Minimum = 1;
IB.Value.Maximum = 10;
IB.ShowDialog();
if (IB.DialogResult == DialogResult.OK)
{
OCRZoom = Convert.ToInt32(IB.GetString());
}
KeyReg();
OptionKeyReg();
MagicKeys.Speak(OCRZoom.ToString());
}

}
}