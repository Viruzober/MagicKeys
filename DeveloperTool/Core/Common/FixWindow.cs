﻿using System;
using System.Windows.Forms;
using static MKLib;
namespace DeveloperTool
{
public partial class DeveloperTool
{

public static void FixWindow()
{
if (Coords.X < 0 || Coords.Y < 0 || Coords.W > GetDisplayResolution().Width || Coords.H > GetDisplayResolution().Height)
{
DialogResult result = MessageBox.Show(T._("This window apears to be out ov screen. Do you want to move it to the visible aria?"), T._("Attention"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
if (result == DialogResult.OK)
{
SetWindowPos(GetForegroundWindow(), 0, 50, 50, 0, 0, MKC.SWP_NOSIZE|MKC.SWP_NOACTIVATE|MKC.SWP_NOZORDER);
}
}
}

}
}