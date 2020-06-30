using System;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void VUIObjectEnter()
{
string Func = Ini.IniReadStr(IniFile, ActiveObjects[Section].ToString(), "Func");
InvokeFromString(Func);
}

}
}