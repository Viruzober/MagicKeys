using System;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void  VUIObjectHelp()
{
string Help = Ini.IniReadStr(IniFile, ActiveObjects[Section].ToString(), "Help");
Speak(Help);
}

}
}