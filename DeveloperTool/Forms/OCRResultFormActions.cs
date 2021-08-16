using System;
using System.Windows.Forms;

namespace MagicKeys
{

public partial class OCRResultForm : Form
{

public void OCRResultForm_Shown(object sender, EventArgs e)
{
this.Activate();
}

public void Exit_Form(Object Sender, EventArgs e)
{
this.Close();
}

public void Form_KeyDown(Object Sender, KeyEventArgs e)
{
if(e.KeyCode == Keys.Escape)
{
this.DialogResult = DialogResult.Cancel;
this.Close();
}
else if (e.KeyCode == Keys.Enter)
{
this.Close();
this.DialogResult = DialogResult.OK;
}
}

}
}