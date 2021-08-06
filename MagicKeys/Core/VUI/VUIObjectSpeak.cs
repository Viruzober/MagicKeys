using System.Collections.Generic;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void VUIObjectSpeak()
{
string SpeakObject = API.GetText();
if (SpeakType == true)
{
SpeakObject += " "+API.GetObjectType();
}
if (API.GetAutoFunc() != null)
{
string AutoFunc;
if (API.GetActiveClass() == "lua")
{
AutoFunc = LUAInvoke(API.GetAutoFunc(), API.GetAutoFuncParam(), AutoFunc:true);
}
else if (API.GetActiveClass() == "MagicKeys")
{
List<string> Funcs = Ini.IniReadKeys(API.GetCurrentScript(), API.GetAutoFunc());
List<string> Params = Ini.IniReadValues(API.GetCurrentScript(), API.GetAutoFunc());
AutoFunc = VUFInvoke(Funcs, Params, AudoFunc:true);
}
else
{
AutoFunc = InvokeFromString(API.GetAutoFunc(), API.GetAutoFuncParam());
}
SpeakObject += " "+AutoFunc;
}
Speak(SpeakObject);
}

}
}