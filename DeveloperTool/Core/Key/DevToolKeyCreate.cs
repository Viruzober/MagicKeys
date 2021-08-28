using System.Windows.Forms;
using System.Collections.Generic;

namespace DeveloperTool
{

public partial class DeveloperTool
{

public static KeyWNDProc DeveloperToolWNDProc = new KeyWNDProc();
public static KeyInfo DevKeyRegInfo = new KeyInfo();
public static List<string> DeveloperToolKeyList = new List<string>();

public static void CreateDevToolKeys()
{
DevKeyRegInfo.WNDProcHandle = DeveloperToolWNDProc.Handle;
DeveloperToolKeyList.AddRange(new string[] {"Left", "Right", "Up", "Down", "Ctrl+Shift+P", "Ctrl+Shift+R", "Ctrl+O",
"Shift+O", "Ctrl+Shift+Z", "M", "C", "-", "=", "Ctrl+S", "Ctrl+I", "Ctrl+Shift+G", "R", "Ctrl+Shift+O", "Ctrl+-", "Ctrl+=", "Ctrl+Alt+A", "W", "Ctrl+W"});
DevKeyRegInfo.KeyList = DeveloperToolKeyList;
}

}
}