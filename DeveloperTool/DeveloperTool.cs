using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using static MKLib;

namespace DeveloperTool
{

public partial class DeveloperTool
{

public static DevMenu HM;
public static KeyInfo OptionKeyRegInfo = new KeyInfo();
public static List<string> OptionKeyList = new List<string>();

[STAThread]
static void Main()
{
Ini.IniWrite("Curac.ini", "Curac", "Key", "Value");
Ini.IniWrite("Curac.ini", "Curac", "Key2", "Value");
Ini.IniWrite("Curac.ini", "Curac", "Key3", "Value");
Ini.IniWrite("Curac.ini", "Curac", "Key4", "Value");
Ini.IniDeleteKey("Curac.ini", "Curac", "Key");
Directory.SetCurrentDirectory(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName));
var RunProc = from proc in Process.GetProcesses(".") orderby proc.Id select proc;
if (RunProc.Count(p => p.ProcessName.Contains("MagicKeys")) > 0)
{
MessageBox.Show("You must close MagicKeys to run DeveloperTool.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
return;
}
HM = new DevMenu();
MKLib.Speak("DeveloperTool is ready");
OptionKeyRegInfo.WNDProcHandle = HM.Handle;
OptionKeyList.AddRange(new string[] {"Ctrl+Shift+F1", "Ctrl+Shift+F2", "Ctrl+Shift+F3", "Ctrl+Shift+F4"});
OptionKeyRegInfo.KeyList = OptionKeyList;
SetKeyRegContext(OptionKeyRegInfo);
KeyReg();
Thread ModuleDetectorThread = new Thread(ModuleDetector);
ModuleDetectorThread.IsBackground = true;
ModuleDetectorThread.Start();
Application.Run();
}

}
}