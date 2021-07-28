using System;
using System.Reflection;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static MagicKeys MKOC = new MagicKeys();
public static object PClass = null;
public static object BClass = null;

public static void GetPluginType()
{
string ModulePath = string.Empty;
            try
            {
if (API.GetBClass() != "None")
{
ModulePath = @"Plugins\"+API.GetBClass()+@"\"+API.GetBClass()+".dll";
Assembly MKB = Assembly.LoadFrom(ModulePath);
var BTY = MKB.GetType("MagicKeys."+API.GetBClass(), true, true);
BClass = Activator.CreateInstance(BTY);
}
if (API.GetPClass() == "MagicKeys")
{
PClass = MKOC.GetType();
return;
}
ModulePath = API.GetModulePath();
Assembly PC = Assembly.LoadFrom(ModulePath);
var PTY = PC.GetType("MagicKeys."+API.GetPClass(), true, true);
PClass =  Activator.CreateInstance(PTY);
}
catch(Exception)
{
MKDebugForm("FileNotFound|"+ModulePath);
return;
}
}

}
}