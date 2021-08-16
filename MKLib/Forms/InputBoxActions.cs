using System;
using System.Windows.Forms;

public partial class InputBox : Form
{

public void ButtonOK_Click(object sender, EventArgs e)
{
this.DialogResult = DialogResult.OK;
this.Close();
}

public void ButtonCancel_Click(object sender, EventArgs e)
{
this.DialogResult = DialogResult.Cancel;
this.Close();
}

public void InputBox_Shown(Object sender, EventArgs e)
{
this.Activate();
}

public string GetString()
{
return Value.Value.ToString();
}

}