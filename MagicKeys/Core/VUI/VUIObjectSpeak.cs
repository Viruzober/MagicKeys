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
MKLib.Speak(SpeakObject);
if (string.IsNullOrEmpty(API.GetFunc("AutoFunc")) != true)
{
Invoker(API.GetFunc("AutoFunc"), API.GetParam("AutoFunc"));
}
if (API.FuncIsBackground("AutoFunc") == true)
{
var BackgroundFuncSpeak = new BackgroundFuncContainer();
BackgroundFuncSpeak.Func = API.GetFunc("AutoFunc");
BackgroundFuncSpeak.Param = API.GetParam("AutoFunc");
BackgroundFuncSpeak.CallName = API.GetNameCurrentObject();
BackgroundFuncSpeak.CallMethod = BackgroundCallMethod.VUIObject;
BackgroundInvoke(BackgroundFuncSpeak);
}
}

}
}