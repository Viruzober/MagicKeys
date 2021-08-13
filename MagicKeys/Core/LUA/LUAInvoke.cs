using MoonSharp.Interpreter;


namespace MagicKeys
{
[MoonSharpUserData]
public partial class MagicKeys
{

public static string LUAInvoke(string Func, string Param = null)
{
DynValue Result;
if (Param == null)
{
Result = LUAScript.Call(LUAScript.Globals[Func]);
}
else
{
Result = LUAScript.Call(LUAScript.Globals[Func], Param);
}
return Result.String;
}

}
}