using System;
using System.Reflection;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static Type PClass;
public static Type BClass;
public static object OClass;

public static void GetPluginType()
{
if (API.GetPClass() == "MagicKeys") return;
Assembly asm = Assembly.LoadFrom(API.GetModulePath());
PClass = asm.GetType("MagicKeys."+API.GetPClass(), true, true);
OClass = Activator.CreateInstance(PClass);
}

}
}