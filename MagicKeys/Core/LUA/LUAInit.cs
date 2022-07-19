using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Loaders;
using System.IO;

namespace MagicKeys
{

public partial class MagicKeys
{

public static Script LUAScript = new Script();
public static void LUAInit()
{
UserData.RegisterType<MagicKeys>();
UserData.RegisterType<ModuleCoords>();
UserData.RegisterType(typeof(MKLib));
LUAScript = new Script();
LUAScript.Globals["MagicKeys"] = typeof(MagicKeys);
LUAScript.Globals["MKLib"] = typeof(MKLib);
((ScriptLoaderBase)LUAScript.Options.ScriptLoader).IgnoreLuaPathGlobal = true;
string[] path = ((ScriptLoaderBase)LUAScript.Options.ScriptLoader).ModulePaths = new string[] {API.GetLUAPath()+@"\?.lua", @"\?.lua"};
LUAScript.DoFile(Path.Combine("MagicKeys.lua"));
LUAScript.DoFile(Path.Combine(API.GetLUAPath(), API.GetVUI()+".lua"));
}

}
}