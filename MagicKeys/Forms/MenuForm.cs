using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace MagicKeys
{

public partial class Menu : Form
{

public NotifyIcon Ni;
public System.ComponentModel.IContainer components;
public ContextMenuStrip MainMenu = new ContextMenuStrip();
public ToolStripMenuItem SettingsMenuItem = new ToolStripMenuItem(T._("Settings"));
public ToolStripMenuItem CheckUpdatesMenuItem = new ToolStripMenuItem(T._("Check for updates"));
public ToolStripMenuItem HelpMenuItem = new ToolStripMenuItem(T._("Help"));
public ToolStripMenuItem ExitMenuItem = new ToolStripMenuItem(T._("Exit"));
public Menu()
{
this.components = new System.ComponentModel.Container();
this.Ni = new System.Windows.Forms.NotifyIcon(this.components);
SettingsMenuItem.Click += SettingsShow;
CheckUpdatesMenuItem.Click += CheckUpdates;
HelpMenuItem.Click += Help;
ExitMenuItem.Click += Exit;
MainMenu.Items.AddRange(new[] {SettingsMenuItem, CheckUpdatesMenuItem, HelpMenuItem, ExitMenuItem});
Ni.ContextMenuStrip = MainMenu;
Ni.Icon = Icon.ExtractAssociatedIcon(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
Ni.Text = T._("MagicKeys {0} is enabled", MagicKeys.GetVersion());
Ni.Visible = true;
}

}
}