using System;
using System.Reflection;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static MagicKeys MKOC = new MagicKeys();
public static Type PClass = null;
public static Type BClass = null;

public static void GetPluginType()
{
string ModulePath = string.Empty;
            try
            {
if (API.GetBClass() != "None")
{
ModulePath = @"Plugins\"+API.GetBClass()+@"\"+API.GetBClass()+".dll";
Assembly MKB = Assembly.LoadFrom(ModulePath);
BClass = MKB.GetType("MagicKeys."+API.GetBClass(), true, true);
}
if (API.GetPClass() == "MagicKeys")
{
PClass = MKOC.GetType();
return;
}
ModulePath = API.GetModulePath();
Assembly PC = Assembly.LoadFrom(ModulePath);
PClass = PC.GetType("MagicKeys."+API.GetPClass(), true, true);
}
catch(Exception)
{
MKDebugForm("FileNotFound|"+ModulePath);
return;
}
}

}
}