using System.Drawing;
using System;
using System.Windows.Forms;
using System.Linq;
using static MKLib;
using System.IO;

namespace DeveloperTool
{
public partial class VUFManagerForm : Form
{

public ComboBox VUF = new ComboBox() {Dock = DockStyle.Fill};
public Button AddVUF = new Button() {Text = T._("Add")};
public Button DeleteVUF = new Button() {Text = T._("Delete")};
public Button RenameVUF = new Button() {Text = T._("Rename")};
public ComboBox FunctionsList = new ComboBox() {Dock = DockStyle.Fill};
public Button AddFunction = new Button() {Text = T._("Add")};
public Button EditFunction = new Button() {Text = T._("Edit")};
public Button DeleteFunction = new Button() {Text = T._("Delete")};
public Button RenameFunction = new Button() {Text = T._("Rename")};
public Button ButtonClose = new Button() {Text = T._("Close")};

public VUFManagerForm()
{
this.StartPosition = FormStartPosition.CenterScreen;
this.Text = T._("VUF manager");
this.MinimizeBox = false;
this.MaximizeBox = false;
this.TopMost = true;
this.AcceptButton = ButtonClose;
this.CancelButton = ButtonClose;
TableLayoutPanel Table = new TableLayoutPanel();
Table.ColumnCount = 2;
Table.Location = new Point (10, 10);
Table.Size = new Size(450, 400);
Table.Controls.Add(new Label() {Text = T._("VUF:")});
VUF.DropDownStyle = ComboBoxStyle.DropDownList;
VUF.SelectedIndexChanged += ChangeSelectVUF;
Table.Controls.Add(VUF);
TableLayoutPanel VUFButtonTable = new TableLayoutPanel();
VUFButtonTable.Dock = DockStyle.Fill;
VUFButtonTable.ColumnCount = 4;
AddVUF.Click += Add_VUF;
VUFButtonTable.Controls.Add(AddVUF);
DeleteVUF.Click += Delete_VUF;
VUFButtonTable.Controls.Add(DeleteVUF);
RenameVUF.Click += Rename_VUF;
VUFButtonTable.Controls.Add(RenameVUF);
Table.Controls.Add(VUFButtonTable, 2, 2);

Table.Controls.Add(new Label() {Text = T._("Functions:")});
FunctionsList.DropDownStyle = ComboBoxStyle.DropDownList;
Table.Controls.Add(FunctionsList);
TableLayoutPanel FunctionsButtonTable = new TableLayoutPanel();
FunctionsButtonTable.Dock = DockStyle.Fill;
FunctionsButtonTable.ColumnCount = 4;
AddFunction.Click += Add_Function;
FunctionsButtonTable.Controls.Add(AddFunction);
EditFunction.Click += Edit_Function;
FunctionsButtonTable.Controls.Add(EditFunction);
DeleteFunction.Click += Delete_Function;
FunctionsButtonTable.Controls.Add(DeleteFunction);
RenameFunction.Click += Rename_Function;
FunctionsButtonTable.Controls.Add(RenameFunction);
Table.Controls.Add(FunctionsButtonTable, 2, 4);
Table.Controls.Add(ButtonClose, 2, 5);

this.Controls.Add(Table);
this.Size = new Size(Table.Size.Width+50, Table.Size.Height+30);
this.Load += Form_Show;
}

}
}