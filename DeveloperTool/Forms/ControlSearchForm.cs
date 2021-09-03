using System;
using System.Windows.Forms;
using System.Drawing;
using static MKLib;

namespace DeveloperTool
{
public partial class ControlSearchForm : Form
{

public TextBox EnterModuleName = new TextBox() {Dock = DockStyle.Fill};
public ListBox ModulesList = new ListBox() {Dock = DockStyle.Fill};
public Button OK = new Button() {Text = T._("OK"), Size = new Size(80, 40)};
public Button Cancel = new Button() {Text = T._("Cancel"), Size = new Size(80, 40)};

public ControlSearchForm()
{
this.Text = T._("Control search");
this.StartPosition = FormStartPosition.CenterScreen;
this.TopMost = true;
this.MinimizeBox = false;
this.MaximizeBox = false;
this.AcceptButton = OK;
this.CancelButton = Cancel;
ModulesList.Items.AddRange(GetAllModules().ToArray());
TableLayoutPanel Table = new TableLayoutPanel();
Table.ColumnCount = 1;
Table.Location = new Point(10, 10);
Table.Size = new Size(420, 300);
Table.Controls.Add(new Label() {Text = T._("Enter or select module name")});
Table.Controls.Add(EnterModuleName);
Table.Controls.Add(ModulesList);
Table.Controls.Add(OK);
Table.Controls.Add(Cancel);
this.Controls.Add(Table);
this.Size = new Size(Table.Size.Width+50, Table.Size.Height+30);
this.Paint += Form_Show;
ModulesList.SelectedIndexChanged += ModulesList_ChangeSelectItem;
OK.Click += OK_Click;
Cancel.Click += Cancel_Click;
}

}
}