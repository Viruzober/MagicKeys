using System.Windows.Forms;
using System.Collections.Generic;
using static MKLib;
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
DeveloperToolKeyList.Clear();
DeveloperToolKeyList.AddRange(new string[] {"Left", "Right", "Up", "Down", "Ctrl+S", "Ctrl+R", "Ctrl+O",
"Shift+O", "Ctrl+Z", "M", "C", "-", "=", "Ctrl+Shift+I", "Ctrl+G", "R", "Ctrl+Shift+O", "Ctrl+-", "Ctrl+=", "Ctrl+A", "W", "Ctrl+W",
"Ctrl+K"});
DevKeyRegInfo.KeyList = DeveloperToolKeyList;
}

public static void LockDevKeys()
{
if (LockKeys == false)
{
Speak("Keys is disabled");
LockKeys = true;
CreateDevToolKeys();
DevKeyRegInfo.KeyList.RemoveAt(DeveloperToolKeyList.IndexOf("Ctrl+K"));
SetKeyRegContext(DevKeyRegInfo);
KeyUnReg();
return;
}
else if (LockKeys == true)
{
Speak("Keys is enabled");
LockKeys = false;
CreateDevToolKeys();
KeyReg();
return;
}
}

}
}