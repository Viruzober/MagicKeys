using System;
using System.Reflection;
using System.Runtime.Loader;
using System.Windows.Forms;
using System.IO;

namespace MagicKeys
{
public partial class MagicKeys
{

public static MagicKeys MKOC = new MagicKeys();
public static object PClass = null;
public static object BClass = null;
public static CustomAssemblyLoadContext Cals = new CustomAssemblyLoadContext();

public static void GetPluginType()
{
string ModulePath = string.Empty;
Cals = new CustomAssemblyLoadContext();
            //try
            //{
if (API.GetBClass() != "None")
{
ModulePath = Path.Combine(Directory.GetCurrentDirectory(), @"Plugins\"+API.GetBClass()+@"\"+API.GetBClass()+".dll");
Assembly MKB = Cals.LoadFromAssemblyPath(ModulePath);
var BTY = MKB.GetType("MagicKeys."+API.GetBClass(), true, true);
BClass = Activator.CreateInstance(BTY);
}
if (API.GetPClass() == "MagicKeys")
{
PClass = MKOC.GetType();
return;
}
ModulePath = Path.Combine(Directory.GetCurrentDirectory(), API.GetModulePath());
Assembly PC = Cals.LoadFromAssemblyPath(ModulePath);
var PTY = PC.GetType("MagicKeys."+API.GetPClass());
PClass =  Activator.CreateInstance(PTY);
//}
//catch(Exception)
//{
//MKDebugForm("FileNotFound|"+ModulePath);
//return;
//}
}

}

public class CustomAssemblyLoadContext : AssemblyLoadContext
{
public CustomAssemblyLoadContext() : base(isCollectible: true)
{ }
protected override Assembly Load(AssemblyName assemblyName)
{
return null;
}
}

}