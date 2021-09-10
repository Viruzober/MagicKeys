using System.Drawing;
using System;
using System.Windows.Forms;
using System.Linq;
using static MKLib;
using System.IO;

namespace DeveloperTool
{
public partial class PointManagerForm : Form
{

public string[] AllModules = GetAllModules().ToArray();
public string[] AllVUI = Directory.GetFiles("Projects/"+DeveloperTool.ProjectName+"/VUI/").Where(f => f.Contains(".vui")).Select(t => Path.GetFileNameWithoutExtension(t)).ToArray();

public ComboBox Points = new ComboBox() {Dock = DockStyle.Fill};
public Button Add = new Button() {Text = T._("Add")};
public Button Delete = new Button() {Text = T._("Delete")};
public Button Edit = new Button() {Text = T._("Edit")};
public Button ButtonClose = new Button() {Text = T._("Close")};

public PointManagerForm()
{
this.StartPosition = FormStartPosition.CenterScreen;
this.Text = T._("Point manager");
this.MinimizeBox = false;
this.MaximizeBox = false;
this.TopMost = true;
this.AcceptButton = ButtonClose;
this.CancelButton = ButtonClose;
TableLayoutPanel Table = new TableLayoutPanel();
Table.ColumnCount = 2;
Table.Location = new Point (10, 10);
Table.Size = new Size(450, 100);
Table.Controls.Add(new Label() {Text = T._("Points:")});
Points.DropDownStyle = ComboBoxStyle.DropDownList;
Points.SelectedIndexChanged += ChangeSelectPoint;
Table.Controls.Add(Points);
TableLayoutPanel ButtonTable = new TableLayoutPanel();
ButtonTable.Dock = DockStyle.Fill;
ButtonTable.ColumnCount = 5;
Add.Click += AddPoint;
ButtonTable.Controls.Add(Add);
Delete.Click += DeletePoint;
ButtonTable.Controls.Add(Delete);
Edit.Click += EditPoint;
ButtonTable.Controls.Add(Edit);
ButtonTable.Controls.Add(ButtonClose);
Table.Controls.Add(ButtonTable, 2, 2);
this.Controls.Add(Table);
this.Size = new Size(Table.Size.Width+50, Table.Size.Height+30);
this.Load += Form_Show;
}

}
}