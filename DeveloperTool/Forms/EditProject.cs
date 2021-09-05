using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace DeveloperTool
{
public partial class EditProjectForm : Form
{

public TextBox ProjectName = new TextBox() {Dock = DockStyle.Fill};
public TextBox Author = new TextBox() {Dock = DockStyle.Fill};
public TextBox Email = new TextBox() {Dock = DockStyle.Fill};
public TextBox PointName = new TextBox() {Dock = DockStyle.Fill};
public TextBox VUI = new TextBox() {Dock = DockStyle.Fill};
public TextBox Module = new TextBox() {Dock = DockStyle.Fill};
public Button Save = new Button() {Text = T._("Save"), Size = new Size(80, 40)};
public Button Cancel = new Button() {Text = T._("Cancel"), Size = new Size(80, 40)};

public EditProjectForm()
{
this.Text = T._("EditProject");
this.StartPosition = FormStartPosition.CenterScreen;
this.MinimizeBox = false;
this.MaximizeBox = false;
this.AcceptButton = Save;
this.CancelButton = Cancel;
TableLayoutPanel Table = new TableLayoutPanel();
Table.ColumnCount = 2;
Table.Location = new Point(10, 10);
Table.Size = new Size(420, 350);
Table.Controls.Add(new Label() {Text = "Name:"});
Table.Controls.Add(ProjectName);
Table.Controls.Add(new Label() {Text = "Author:"});
Table.Controls.Add(Author);
Table.Controls.Add(new Label() {Text = "E-Mail:"});
Table.Controls.Add(Email);
Table.Controls.Add(new Label() {Text = "Main entry point:"});
Table.Controls.Add(PointName);
Table.Controls.Add(new Label() {Text = "Start VUI name:"});
Table.Controls.Add(VUI);
Table.Controls.Add(new Label() {Text = "Module name:"});
Table.Controls.Add(Module);
Table.Controls.Add(Save, 2, 7);
Table.Controls.Add(Cancel, 2, 8);
this.Size = new Size(Table.Size.Width+50, Table.Size.Height+30);
this.Controls.Add(Table);
this.Load += Form_Show;
Save.Click += Click_Save;
Cancel.Click += Click_Cancel;
}

}
}