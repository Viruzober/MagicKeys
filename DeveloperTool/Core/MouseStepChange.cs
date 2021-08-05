using System;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class DeveloperTool
{
public static void MouseStepChange()
{
KeyUnReg();
OptionKeyUnReg();
InputBox IB = new InputBox();
IB.Text = T._("Mouse step");
IB.InputBoxLabel.Text = T._("Enter mouse step:");
IB.Value.Minimum = 1;
IB.Value.Maximum = 100;
IB.ShowDialog();
if (IB.DialogResult == DialogResult.OK)
{
MouseStep = Convert.ToInt32(IB.GetString());
}
KeyReg();
OptionKeyReg();
MagicKeys.Speak(MouseStep.ToString());
}

}
}