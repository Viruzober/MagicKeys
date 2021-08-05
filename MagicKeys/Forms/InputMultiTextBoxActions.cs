using System;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class InputMultiTextBox : Form
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

public void InputMultiTextBox_Shown(Object sender, EventArgs e)
{
this.Activate();
}

public string GetString()
{
return Value.Text;
}

}
}