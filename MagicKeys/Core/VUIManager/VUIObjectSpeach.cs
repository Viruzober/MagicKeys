using System;
using System.Collections.Generic;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void VUIObjectSpeach()
{
string SpeachObject = API.GetText();
if (SpeachType == true)
{
SpeachObject += " "+API.GetOpjectType();
}
if (API.GetAutoFunc() != null)
{
string AutoFunc;
if (API.GetPClass() == "MagicKeys")
{
List<string> VUFValues = Ini.IniReadValues(API.GetVUIPath()+API.GetVUI()+".vuf", API.GetAutoFunc());
AutoFunc = VUFAutoFunc(VUFValues);
}
else
{
AutoFunc = InvokeFromString(API.GetAutoFunc());
}
SpeachObject += " "+AutoFunc;
}
SpeachObject += " "+API.GetObjectKey();
Speak(SpeachObject);
}

}
}