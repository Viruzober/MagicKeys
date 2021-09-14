using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Threading.Channels;
using System.IO;

namespace DeveloperTool
{
public partial class ObjectEditorForm : Form
{
public string VUIName;
public string ObjectName;
public TextBox ObjectText = new TextBox() {Dock = DockStyle.Fill};
public TextBox ObjectHelp= new TextBox() {Dock = DockStyle.Fill};
public ComboBox ObjectFuncs = new ComboBox() {Dock = DockStyle.Fill};
public Button Save = new Button() {Text = T._("Save")};
public Button Cancel = new Button() {Text = T._("Cancel")};

public ObjectEditorForm(string VUI, string EditingObject)
{
VUIName = VUI;
ObjectName = EditingObject;
this.Text = T._("Edit Object");
this.StartPosition = FormStartPosition.CenterScreen;
this.MinimizeBox = false;
this.MaximizeBox = false;
this.AcceptButton = Save;
this.CancelButton = Cancel;
TableLayoutPanel Table = new TableLayoutPanel();
Table.ColumnCount = 2;
Table.Location = new Point(10, 10);
Table.Size = new Size(420, 350);
Table.Controls.Add(new Label() {Text = T._("Text:")});
Table.Controls.Add(ObjectText);
Table.Controls.Add(new Label() {Text = T._("Help:")});
Table.Controls.Add(ObjectHelp);
Table.Controls.Add(new Label() {Text = T._("Function:")});
ObjectFuncs.DropDownStyle = ComboBoxStyle.DropDownList;
Table.Controls.Add(ObjectFuncs);
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