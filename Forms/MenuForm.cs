using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class Menu : Form
{

public NotifyIcon Ni;
public System.ComponentModel.IContainer components;
public ContextMenuStrip MainMenu = new ContextMenuStrip();
public ToolStripMenuItem RegisterMenuItem = new ToolStripMenuItem("Регистрация");
public ToolStripMenuItem SettingsMenuItem = new ToolStripMenuItem("Настройки");
public ToolStripMenuItem HelpMenuItem = new ToolStripMenuItem("Справка");
public ToolStripMenuItem ExitMenuItem = new ToolStripMenuItem("Выход");

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
Ni.Icon = new Icon(@"Images\Icon.ico");
Ni.Text = "MagicKeys включён";
Ni.Visible = true;
}

}
}