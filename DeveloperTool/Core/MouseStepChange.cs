using System;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class DeveloperTool
{

public static void MouseStepChange()
{
KeyUnReg();
InputBox IB = new InputBox();
IB.Text = "Mouse step";
IB.InputBoxLabel.Text = "Enter mouse step";
IB.Value.Minimum = 1;
IB.Value.Maximum = 100;
IB.ShowDialog();
if (IB.DialogResult == DialogResult.OK)
{
MouseStep = Convert.ToInt32(IB.GetString());
}
KeyReg();
MagicKeys.Speak(MouseStep.ToString());
}

}
}