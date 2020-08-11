using System;
using System.Drawing;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class Menu : Form
{

public NotifyIcon Ni;
public System.ComponentModel.IContainer components;
public ContextMenuStrip MainMenu = new ContextMenuStrip();
public ToolStripMenuItem HelpMenuItem = new ToolStripMenuItem("Help");
public ToolStripMenuItem ExitMenuItem = new ToolStripMenuItem("Exit");

        public Menu()
{
this.components = new System.ComponentModel.Container();
this.Ni = new System.Windows.Forms.NotifyIcon(this.components);
HelpMenuItem.Click += Help;
ExitMenuItem.Click += Exit;
Ni.ContextMenuStrip = MainMenu;
Ni.Icon = Icon.ExtractAssociatedIcon(Assembly.GetEntryAssembly().Location);
Ni.Text = "Developer tool for MagicKeys";
Ni.Visible = true;
}

}
}