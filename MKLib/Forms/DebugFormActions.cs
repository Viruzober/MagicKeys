using System;
using System.Windows.Forms;

public partial class DebugForm : Form
{

public void DebugForm_Shown(object sender, EventArgs e)
{
this.Activate();
}

public void Exit_Click(Object Sender, EventArgs e)
{
Environment.Exit(1);
}

}