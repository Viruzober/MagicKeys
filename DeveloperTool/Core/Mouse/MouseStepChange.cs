using System;
using System.Windows.Forms;
using static MKLib;

namespace DeveloperTool
{

public partial class DeveloperTool
{

public static void MouseStepChange()
{
KeyUnReg();
InputBox IB = new InputBox();
IB.Text = T._("Mouse step");
IB.InputBoxLabel.Text = T._("Enter mouse step:");
IB.Value.Minimum = 1;
IB.Value.Maximum = 100;
IB.Value.Value = MouseStep;
IB.ShowDialog();
if (IB.DialogResult == DialogResult.OK)
{
MouseStep = Convert.ToInt32(IB.GetString());
}
KeyReg();
}

}
}