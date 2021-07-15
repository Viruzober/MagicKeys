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
string VUIFile = VUIPathDetect(File);
CurrentPlugin["VUI"] = File;
CurrentPlugin["PClass"] = Ini.IniRead(VUIFile, "Info", "PClass");
CurrentPlugin["BClass"] = Ini.IniRead(VUIFile, "Info", "BClass");
CurrentPlugin["PluginName"] = Ini.IniRead(VUIFile, "Info", "PluginName");
CurrentPlugin["Loader"] = Ini.IniRead(VUIFile, "Info", "Loader");
Count = Ini.IniCountSections(VUIFile)-1;
if (Ini.IniSectionExists(VUIFile, "Keys") == true)
{
Count = Ini.IniCountSections(VUIFile)-2;
}
VUIObjects.Clear();
if (Ini.IniSectionExists(VUIFile, "1") == true)
{
for (int I = 1; I <= Count; I++)
{
VUIObjects.Add(I, new Dictionary<string, string>());
VUIObjects[I].Add("Active", "true");
VUIObjects[I].Add("Text", Ini.IniRead(VUIFile, I.ToString(), "Text"));
VUIObjects[I].Add("ObjectType", Ini.IniRead(VUIFile, I.ToString(), "ObjectType"));
VUIObjects[I].Add("Help", Ini.IniRead(VUIFile, I.ToString(), "Help"));
if (Ini.IniKeyExists(VUIFile, I.ToString(), "AutoFunc") == true)
{
VUIObjects[I].Add("AutoFunc", Ini.IniRead(VUIFile, I.ToString(), "AutoFunc"));
}
VUIObjects[I].Add("Func", Ini.IniRead(VUIFile, I.ToString(), "Func"));
if (Ini.IniKeyExists(VUIFile, I.ToString(), "Param") == true)
{
VUIObjects[I].Add("Param", Ini.IniRead(VUIFile, I.ToString(), "Param"));
}
if (Ini.IniKeyExists(VUIFile, I.ToString(), "Key") == true)
{
VUIObjects[I].Add("Key", Ini.IniRead(VUIFile, I.ToString(), "Key"));
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