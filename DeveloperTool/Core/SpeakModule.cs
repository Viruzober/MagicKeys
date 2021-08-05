using System;

namespace MagicKeys
{

public partial class DeveloperTool
{

public static void SpeakModule()
{
int[] MP = MagicKeys.GetMousePosition();
IntPtr HModule = MagicKeys.GetWinPointHandle(MP[0], MP[1]);
string ModuleName = MagicKeys.GetDllName(HModule);
MagicKeys.Speak(ModuleName);
}

}
}