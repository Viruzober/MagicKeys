using System.Collections.Generic;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void VUIObjectSpeak()
{
string SpeakObject = API.GetText();
if (Settings.SpeakType == true)
{
SpeakObject += " "+API.GetObjectType();
}
if (API.GetFunc("AutoFunc") != null)
{
SpeakObject += " "+Invoker(API.GetFunc("AutoFunc"), API.GetParam("AutoFunc"));;
}
MKLib.Speak(SpeakObject);
if (API.FuncIsBackground("AutoFunc") == true)
{
var BFObj = new BackgroundFuncObject(API.GetFunc("AutoFunc"), API.GetParam("AutoFunc"), API.GetNameCurrentObject(), true);
BackgroundInvoke(BFObj);
}
}

}
}