using System;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void VUIObjectSpeach()
{
string SpeachObject = VUIObjects[ActiveObjects[Section]]["Text"];
if (SpeachType == true)
{
if (VUIObjects[ActiveObjects[Section]].ContainsKey("ObjectType") == true)
{
SpeachObject += " "+VUIObjects[ActiveObjects[Section]]["ObjectType"];
}
}
if (VUIObjects[ActiveObjects[Section]].ContainsKey("AutoFunc") == true)
{
string AutoFunc = InvokeFromString(VUIObjects[ActiveObjects[Section]]["AutoFunc"]);
SpeachObject += " "+AutoFunc;
}
Speak(SpeachObject);
}

}
}