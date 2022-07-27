using MoonSharp.Interpreter;

namespace MagicKeys
{
[MoonSharpUserData]
public partial class MagicKeys
{

public static void LUAInvoke(string Func, string Param)
{
if (string.IsNullOrEmpty(Param) == true)
{
LUAScript.Call(LUAScript.Globals[Func]);
}
else
{
LUAScript.Call(LUAScript.Globals[Func], Param);
}
}

}
}