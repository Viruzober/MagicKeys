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
if (API.GetFunc("AutoFunc") != null)
{
string AutoFunc;
if (API.GetActiveClass() == "lua")
{
AutoFunc = LUAInvoke(API.GetFunc("AutoFunc"), API.GetParam("AutoFunc"));
}
else if (API.GetActiveClass() == "MagicKeys")
{
List<string> Funcs = Ini.IniReadKeys(API.GetCurrentScript(), API.GetFunc("AutoFunc"));
List<string> Params = Ini.IniReadValues(API.GetCurrentScript(), API.GetParam("AutoFunc"));
AutoFunc = VUFInvoke(Funcs, Params, AudoFunc:true);
}
else
{
AutoFunc = InvokeFromString(API.GetFunc("AutoFunc"), API.GetParam("AutoFunc"));
}
SpeakObject += " "+AutoFunc;
}
Speak(SpeakObject);
if (API.FuncIsBackground("AutoFunc") == true)
{
var BFObj = new BackgroundFuncObject(API.GetFunc("AutoFunc"), API.GetParam("AutoFunc"), API.GetNameCurrentObject(), true);
BackgroundInvoke(BFObj);
}
}

}
}