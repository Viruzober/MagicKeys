using System.Windows.Forms;
using System.Collections.Generic;
using static MKLib;
namespace DeveloperTool
{

public partial class DeveloperTool
{

public static KeyWNDProc DeveloperToolWNDProc = new KeyWNDProc();
public static KeyInfo DevKeyRegInfo = new KeyInfo();

public static void CreateDevToolKeys()
{
DevKeyRegInfo = new KeyInfo();
DevKeyRegInfo.WNDProcHandle = DeveloperToolWNDProc.Handle;
DevKeyRegInfo.KeyList.AddRange(new string[] {"Left", "Right", "Up", "Down", "Ctrl+S", "Ctrl+R", "Ctrl+O",
"Shift+O", "Ctrl+Z", "M", "C", "-", "=", "Ctrl+Shift+I", "Ctrl+G", "R", "Ctrl+Shift+O", "Ctrl+-", "Ctrl+=", "Ctrl+A", "W", "Ctrl+W",
"Ctrl+K", "Ctrl+Shift+N", "Ctrl+D", "Ctrl+Shift+E", "Ctrl+Shift+P", "Ctrl+F"});
}

public static void LockDevKeys()
{
if (LockKeys == false)
{
Speak("Keys is disabled");
LockKeys = true;
CreateDevToolKeys();
SetKeyRegContext(DevKeyRegInfo);
DisableKey("Ctrl+K");
KeyUnReg();
return;
}
else if (LockKeys == true)
{
Speak("Keys is enabled");
LockKeys = false;
CreateDevToolKeys();
SetKeyRegContext(DevKeyRegInfo);
KeyReg();
return;
}
}

}
}