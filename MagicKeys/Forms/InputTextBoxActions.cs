using System.Drawing;
using System;
using System.Windows.Forms;

namespace MagicKeys
{

public partial class InputTextBox : Form
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

public void InputTextBox_Shown(Object sender, EventArgs e)
{
this.Activate();
if (Value.Multiline == true)
{
Value.Size = new Size(Value.Size.Width+300, Value.Size.Height+250);
this.Size = new Size(this.Size.Width+300, this.Size.Height+250);
ButtonOK.Location = new Point(ButtonOK.Location.X+300, ButtonOK.Location.Y+250);
ButtonCancel.Location = new Point(ButtonCancel.Location.X+300, ButtonCancel.Location.Y+250);
}
}

public string GetString()
{
return Value.Text;
}

}
}