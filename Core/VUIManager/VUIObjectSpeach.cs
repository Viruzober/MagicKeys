using System;

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
string AutoFunc = InvokeFromString(API.GetAutoFunc());
SpeachObject += " "+AutoFunc;
}
Speak(SpeachObject);
}

}
}