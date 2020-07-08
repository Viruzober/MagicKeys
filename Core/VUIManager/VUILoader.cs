using System;
using System.IO;
using System.Collections.Generic;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void VUILoader(string File)
{
InvokeFromString("KeyUnReg");
SoundPlay("ChangeVUI.ogg", 0);
string VUIFile = @"VUI\"+File;
PluginsList[0]["VUI"] = @File;
PluginsList[0]["PClass"] = GetFullClassName(Ini.IniRead(VUIFile, "Info", "PClass"));
if (Ini.IniRead(VUIFile, "Info", "BClass") == "None")
{
PluginsList[0]["BClass"] = "None";
}
else
{
PluginsList[0]["BClass"] = GetFullClassName(Ini.IniRead(VUIFile, "Info", "BClass"));
}
PluginsList[0]["VUIName"] = Ini.IniRead(VUIFile, "Info", "VUIName");
Count = Ini.IniCountSections(VUIFile)-1;
VUIObjects.Clear();
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
if (Ini.IniKeyExists(VUIFile, I.ToString(), "Ptr") == true)
{
VUIObjects[I].Add("Ptr", Ini.IniRead(VUIFile, I.ToString(), "Ptr"));
}
}
VUIObjectsUpdate(true);
InvokeFromString("KeyReg");
}

}
}