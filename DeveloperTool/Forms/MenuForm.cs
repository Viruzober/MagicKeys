using System;
using System.Drawing;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class DevMenu : Form
{

public NotifyIcon Ni;
public System.ComponentModel.IContainer components;
public ContextMenuStrip MainMenu = new ContextMenuStrip();
public ToolStripMenuItem ExitMenuItem = new ToolStripMenuItem("Exit");

        public DevMenu()
{
this.components = new System.ComponentModel.Container();
this.Ni = new System.Windows.Forms.NotifyIcon(this.components);
ExitMenuItem.Click += Exit;
MainMenu.Items.AddRange(new[] {ExitMenuItem});
Ni.ContextMenuStrip = MainMenu;
Ni.Icon = Icon.ExtractAssociatedIcon(Assembly.GetEntryAssembly().Location);
Ni.Text = T._("Developer tool");
Ni.Visible = true;
}

}
}