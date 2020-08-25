using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace DeveloperTool
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

}
}