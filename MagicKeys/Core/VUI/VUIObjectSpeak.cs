using System;
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
if (API.GetPluginClass() == "MagicKeys" | API.GetSubClass() == "MagicKeys")
{
List<string> Funcs = Ini.IniReadKeys(API.GetCurrentVUF(), API.GetAutoFunc());
List<string> Params = Ini.IniReadValues(API.GetCurrentVUF(), API.GetAutoFunc());
AutoFunc = VUFInvoke(Funcs, Params, AudoFunc:true);
}
else
{
AutoFunc = InvokeFromString(API.GetAutoFunc());
}
SpeakObject += " "+AutoFunc;
}
Speak(SpeakObject);
}
}
}