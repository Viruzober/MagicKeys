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
List<string> VUFValues = Ini.IniReadValues(API.GetCurrentVUF(), API.GetAutoFunc());
AutoFunc = VUFAutoFunc(VUFValues);
}
else
{
AutoFunc = InvokeFromString(API.GetAutoFunc());
}
SpeakObject += " "+AutoFunc;
}
SpeakObject += " "+API.GetObjectKey();
Speak(SpeakObject);
}

}
}