using System;

namespace MagicKeys
{
public partial class DeveloperTool
{

public static void ControlSearch()
{
KeyUnReg();
OptionKeyUnReg();
 string ModuleName = MagicKeys.InputTextBox("Enter sub string for calling module", "ControlSearch");
if (ModuleName == "0")
{
OptionKeyReg();
if (Module != string.Empty)
{
KeyReg();
}
return;
}
Module = ModuleName;
P = GetPluginCoord();
if (P[0] == 1)
{
MagicKeys.Speak("Module founded");
MagicKeys.MouseMove(P[1], P[2], 0);
KeyReg();
OptionKeyReg();
MagicKeys.SoundPlay("WindowOpened", 0);
ModuleFound();
}
else
{
MagicKeys.Speak("Not found");
}
OptionKeyReg();
}

}
}