using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicKeys
{
public partial class MagicKeys
{

public static VUIObjectContainer VUIObjectParser(string ObjectName)
{
VUIObjectContainer TempVUIObjectContainer = new VUIObjectContainer();
TempVUIObjectContainer.Name = ObjectName;
TempVUIObjectContainer.Text = Ini.IniRead(API.GetCurrentVUI(), ObjectName, "Text");
if (Ini.IniKeyExists(API.GetCurrentVUI(), ObjectName, "ObjectType") == true)
{
TempVUIObjectContainer.Type = Ini.IniRead(API.GetCurrentVUI(), ObjectName, "ObjectType");
}
if (Ini.IniKeyExists(API.GetCurrentVUI(), ObjectName, "Help") == true)
{
TempVUIObjectContainer.Help = Ini.IniRead(API.GetCurrentVUI(), ObjectName, "Help");
}
if (Ini.IniKeyExists(API.GetCurrentVUI(), ObjectName, "AutoFunc") == true)
{
TempVUIObjectContainer.AutoFunction = FunctionParser(Ini.IniRead(API.GetCurrentVUI(), ObjectName, "AutoFunc"));
}
if (Ini.IniKeyExists(API.GetCurrentVUI(), ObjectName, "Func") == true)
{
TempVUIObjectContainer.Function = FunctionParser(Ini.IniRead(API.GetCurrentVUI(), ObjectName, "Func"));
}
return TempVUIObjectContainer;
}

}
}