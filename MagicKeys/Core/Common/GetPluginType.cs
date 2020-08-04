using System;
using System.Reflection;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static Type PClass = null;
public static Type BClass = null;

public static void GetPluginType()
{
try
{
if (API.GetBClass() != "None")
{
Assembly MKB = Assembly.LoadFrom(@"Plugins\"+API.GetBClass()+@"\"+API.GetBClass()+".dll");
BClass = MKB.GetType("MagicKeys."+API.GetBClass(), true, true);
}
if (API.GetPClass() == "MagicKeys")
{
Assembly MK = Assembly.LoadFrom("MagicKeys");
PClass = MK.GetType("MagicKeys.MagicKeys", true, true);
return;
}
Assembly PC = Assembly.LoadFrom(API.GetModulePath());
PClass = PC.GetType("MagicKeys."+API.GetPClass(), true, true);
}
catch(Exception)
{
MKDebugForm("GetPluginType|"+API.GetVUIPath()+API.GetVUIExt()+"|"+API.GetModule()+".dll");
return;
}
}

}
}