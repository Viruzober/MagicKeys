using System.Drawing;
using System;
using System.Windows.Forms;
using System.Linq;
using static MKLib;
using System.IO;

namespace DeveloperTool
{
public partial class VUIManagerForm : Form
{

public ComboBox VUI = new ComboBox() {Dock = DockStyle.Fill};
public Button AddVUI = new Button() {Text = T._("Add")};
public Button DeleteVUI = new Button() {Text = T._("Delete")};
public Button RenameVUI = new Button() {Text = T._("Rename")};
public ComboBox VUIObjects = new ComboBox() {Dock = DockStyle.Fill};
public Button AddObject = new Button() {Text = T._("Add")};
public Button DeleteObject = new Button() {Text = T._("Delete")};
public Button RenameObject = new Button() {Text = T._("Rename")};
public Button ButtonClose = new Button() {Text = T._("Close")};

public VUIManagerForm()
{
this.StartPosition = FormStartPosition.CenterScreen;
this.Text = T._("VUI manager");
this.MinimizeBox = false;
this.MaximizeBox = false;
this.TopMost = true;
this.AcceptButton = ButtonClose;
this.CancelButton = ButtonClose;
TableLayoutPanel Table = new TableLayoutPanel();
Table.ColumnCount = 2;
Table.Location = new Point (10, 10);
Table.Size = new Size(450, 400);
Table.Controls.Add(new Label() {Text = T._("VUI:")});
VUI.DropDownStyle = ComboBoxStyle.DropDownList;
VUI.SelectedIndexChanged += ChangeSelectVUI;
Table.Controls.Add(VUI);
TableLayoutPanel VUIButtonTable = new TableLayoutPanel();
VUIButtonTable.Dock = DockStyle.Fill;
VUIButtonTable.ColumnCount = 4;
AddVUI.Click += Add_VUI;
VUIButtonTable.Controls.Add(AddVUI);
DeleteVUI.Click += Delete_VUI;
VUIButtonTable.Controls.Add(DeleteVUI);
RenameVUI.Click += Rename_VUI;
VUIButtonTable.Controls.Add(RenameVUI);
Table.Controls.Add(VUIButtonTable, 2, 2);

Table.Controls.Add(new Label() {Text = T._("Objects:")});
VUIObjects.DropDownStyle = ComboBoxStyle.DropDownList;
Table.Controls.Add(VUIObjects);
TableLayoutPanel ObjectsButtonTable = new TableLayoutPanel();
ObjectsButtonTable.Dock = DockStyle.Fill;
ObjectsButtonTable.ColumnCount = 4;
AddObject.Click += Add_Object;
ObjectsButtonTable.Controls.Add(AddObject);
DeleteObject.Click += Delete_Object;
ObjectsButtonTable.Controls.Add(DeleteObject);
RenameObject.Click += Rename_Object;
ObjectsButtonTable.Controls.Add(RenameObject);
Table.Controls.Add(ObjectsButtonTable, 2, 4);
Table.Controls.Add(ButtonClose, 2, 5);

this.Controls.Add(Table);
this.Size = new Size(Table.Size.Width+50, Table.Size.Height+30);
this.Load += Form_Show;
}

}
}