using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Threading.Channels;
using System.IO;

namespace DeveloperTool
{
public partial class PointEditorForm : Form
{

public string OldPointName;

public TextBox PointName = new TextBox() {Dock = DockStyle.Fill};
public ComboBox VUI = new ComboBox() {Dock = DockStyle.Fill};
public ComboBox Modules = new ComboBox() {Dock = DockStyle.Fill};
public Button Save = new Button() {Text = T._("Save")};
public Button Cancel = new Button() {Text = T._("Cancel")};

public PointEditorForm(string OldPoint, string[] AllVUI, string[] AllModules)
{
OldPointName = OldPoint;
PointName.Text = OldPointName;
VUI.Items.AddRange(AllVUI);
VUI.SelectedIndex = 0;
Modules.Items.AddRange(AllModules);
if (Ini.IniKeyExists("Projects/"+DeveloperTool.ProjectName+"/Manifest.ini", OldPointName, "Module") == true)
{
Modules.Items.Insert(0, Ini.IniRead("Projects/"+DeveloperTool.ProjectName+"/Manifest.ini", OldPointName, "Module"));
}
Modules.SelectedIndex = 0;
this.Text = T._("Edit point");
this.StartPosition = FormStartPosition.CenterScreen;
this.MinimizeBox = false;
this.MaximizeBox = false;
this.AcceptButton = Save;
this.CancelButton = Cancel;
TableLayoutPanel Table = new TableLayoutPanel();
Table.ColumnCount = 2;
Table.Location = new Point(10, 10);
Table.Size = new Size(420, 350);
Table.Controls.Add(new Label() {Text = T._("Name:")});
Table.Controls.Add(this.PointName);
Table.Controls.Add(new Label() {Text = T._("VUI:")});
VUI.DropDownStyle = ComboBoxStyle.DropDownList;
Table.Controls.Add(VUI);
Table.Controls.Add(new Label() {Text = T._("Module:")});
Table.Controls.Add(Modules);
Table.Controls.Add(Save, 2, 4);
Table.Controls.Add(Cancel, 2, 5);
this.Size = new Size(Table.Size.Width+50, Table.Size.Height+30);
this.Controls.Add(Table);
this.Load += Form_Show;
Save.Click += Save_Click;
Cancel.Click += Cancel_Click;
}

}
}