using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void VUILoader(string File)
{
KeyUnReg();
VUIKeys.Clear();
SoundPlay("ChangeVUI", 0);
CurrentPlugin["VUI"] = File;
CurrentPlugin["PluginClass"] = Ini.IniRead(API.GetCurrentVUI(), "Info", "PluginClass");
CurrentPlugin["Loader"] = Ini.IniRead(API.GetCurrentVUI(), "Info", "Loader");
Count = Ini.IniCountSections(API.GetCurrentVUI())-1;
if (Ini.IniSectionExists(API.GetCurrentVUI(), "Keys") == true)
{
Count = Ini.IniCountSections(API.GetCurrentVUI())-2;
}
VUIObjects.Clear();
if (Ini.IniSectionExists(API.GetCurrentVUI(), "1") == true)
{
for (int I = 1; I <= Count; I++)
{
VUIObjects.Add(I, new Dictionary<string, string>());
VUIObjects[I].Add("Active", "true");
VUIObjects[I].Add("Text", Ini.IniRead(API.GetCurrentVUI(), I.ToString(), "Text"));
VUIObjects[I].Add("ObjectType", Ini.IniRead(API.GetCurrentVUI(), I.ToString(), "ObjectType"));
if (Ini.IniKeyExists(API.GetCurrentVUI(), I.ToString(), "Help") == true)
{
VUIObjects[I].Add("Help", Ini.IniRead(API.GetCurrentVUI(), I.ToString(), "Help"));
}
else
{
VUIObjects[I].Add("Help", "Help not found");
}
if (Ini.IniKeyExists(API.GetCurrentVUI(), I.ToString(), "AutoFunc") == true)
{
VUIObjects[I].Add("AutoFunc", Ini.IniRead(API.GetCurrentVUI(), I.ToString(), "AutoFunc"));
}
VUIObjects[I].Add("Func", Ini.IniRead(API.GetCurrentVUI(), I.ToString(), "Func"));
if (Ini.IniKeyExists(API.GetCurrentVUI(), I.ToString(), "Param") == true)
{
VUIObjects[I].Add("Param", Ini.IniRead(API.GetCurrentVUI(), I.ToString(), "Param"));
}
if (Ini.IniKeyExists(API.GetCurrentVUI(), I.ToString(), "Key") == true)
{
VUIObjects[I].Add("Key", Ini.IniRead(API.GetCurrentVUI(), I.ToString(), "Key"));
}
}
VUIObjectsUpdate(true);
}
GetPluginType();
VUIPluginLoad();
KeyLoader();
KeyReg();
SoundPlay("PluginDetect", 0);
}

}
}