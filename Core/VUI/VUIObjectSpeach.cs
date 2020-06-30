using System;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void VUIObjectSpeach()
{
string SpeachObject = Ini.IniReadStr(IniFile, ActiveObjects[Section].ToString(), "Text");
if (SpeachType == true)
{
if (Ini.IniKeyExists(IniFile, ActiveObjects[Section].ToString(), "ObjectType"))
{
string Type = Ini.IniReadStr(IniFile, ActiveObjects[Section].ToString(), "ObjectType");
SpeachObject += " "+Type;
}
}
if (Ini.IniKeyExists(IniFile, ActiveObjects[Section].ToString(), "AutoFunc"))
{
string AutoFunc = InvokeFromString(Ini.IniReadStr(IniFile, ActiveObjects[Section].ToString(), "AutoFunc"));
SpeachObject += " "+AutoFunc;
}
Speak(SpeachObject);
}

}
}