using System;

namespace MagicKeys
{
public partial class DeveloperTool
{

public static void ControlSearch()
{
KeyUnReg();
 Module = MagicKeys.InputTextBox("Enter sub string for calling module", "ControlSearch");
P = GetPluginCoord();
if (P[0] == 1)
{
MagicKeys.Speak("Module founded");
MagicKeys.MouseMove(P[1], P[2], 0);
KeyReg();
MagicKeys.SoundPlay("WindowOpened", 0);
ModuleFound();
}
else
{
MagicKeys.Speak("Not found");
}
}

}
}