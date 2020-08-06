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
public ToolStripMenuItem RegisterMenuItem = new ToolStripMenuItem("Register");
public ToolStripMenuItem SettingsMenuItem = new ToolStripMenuItem("Settings");
public ToolStripMenuItem HelpMenuItem = new ToolStripMenuItem("Help");
public ToolStripMenuItem ExitMenuItem = new ToolStripMenuItem("Exit");

        public Menu()
{
this.components = new System.ComponentModel.Container();
this.Ni = new System.Windows.Forms.NotifyIcon(this.components);
RegisterMenuItem.Click += Register;
SettingsMenuItem.Click += Settings;
HelpMenuItem.Click += Help;
ExitMenuItem.Click += Exit;
if (MagicKeys.RegUser == true)
{
MainMenu.Items.AddRange(new[] {SettingsMenuItem, HelpMenuItem, ExitMenuItem});
}
else
{
MainMenu.Items.AddRange(new[] {RegisterMenuItem, SettingsMenuItem, HelpMenuItem, ExitMenuItem});
}
Ni.ContextMenuStrip = MainMenu;
Ni.Icon = Icon.ExtractAssociatedIcon(Assembly.GetEntryAssembly().Location);
Ni.Text = "MagicKeys "+MagicKeys.Version+" is enabled";
Ni.Visible = true;
}

}
}