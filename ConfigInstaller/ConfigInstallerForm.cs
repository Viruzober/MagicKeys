using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConfigInstaller
{
public partial class ConfigInstallerForm : Form
{

public ConfigInstallerForm()
{
InitLabel();
InitListBox();
InitForm();
}

public void InitForm()
{
this.StartPosition = FormStartPosition.CenterScreen;
this.Size = new Size(500, 600);
this.Text = "ConfigInstaller";
this.MinimizeBox = false;
this.MaximizeBox = false;
this.Name = "ConfigInstaller";
}

public void InitLabel()
{
Label List = new Label();
List.Size = new Size(100, 20);
List.Location = new Point(10, 10);
List.Text = "Плагины";
this.Controls.Add(List);
}

ListBox LB = new ListBox();
public void InitListBox()
{
LB.Location = new Point(10, 50);
LB.Size = new Size(470, 500);
this.Controls.Add(LB);
}

}
}