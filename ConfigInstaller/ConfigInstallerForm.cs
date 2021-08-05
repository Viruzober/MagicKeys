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
InitTextBox();
InitButton();
InitForm();
}

public void InitForm()
{
this.StartPosition = FormStartPosition.CenterScreen;
this.TopMost = true;
this.Size = new Size(800, 450);
this.Text = "ConfigInstaller";
this.MinimizeBox = false;
this.MaximizeBox = false;
this.Name = "ConfigInstaller";
this.Load += FormLoad;
}

public void InitLabel()
{
Label List = new Label();
List.Size = new Size(190, 20);
List.Location = new Point(20, 10);
List.Text = T._("Плагины");
List.TabIndex = 1;
this.Controls.Add(List);
Label Log = new Label();
Log.Size = new Size(190, 20);
Log.Location = new Point(220, 10);
Log.Text = T._("Результат");
Log.TabIndex = 3;
this.Controls.Add(Log);
}
CheckedListBox LB = new CheckedListBox();
public void InitListBox()
{
LB.Location = new Point(10, 40);
LB.Size = new Size(200, 300);
LB.TabIndex = 2;
this.Controls.Add(LB);
}
TextBox TB = new TextBox();
public void InitTextBox()
{
TB.ReadOnly = true;
TB.Multiline = true;
TB.Location = new Point(230, 40);
TB.Size = new Size(545, 300);
TB.TabIndex = 4;
this.Controls.Add(TB);
}
Button Ins = new Button();
public void InitButton()
{
Ins.Size = new Size(200, 40);
Ins.Location = new Point(575, 350);
Ins.Text = T._("Установить");
Ins.Click += Ins_Click;
this.Controls.Add(Ins);
}

}
}