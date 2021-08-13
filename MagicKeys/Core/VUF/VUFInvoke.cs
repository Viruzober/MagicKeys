using System.Collections.Generic;
using System.Threading;

namespace MagicKeys
{

public partial class MagicKeys
{

public static string VUFInvoke(List<string> Funcs, List<string> Params)
{
string Result = null;
for(int I = 0 ; I <= Funcs.Count-1; I++)
{
if (Funcs[I] == "Func")
{
string[] Param = Params[I].Split(",", 2);
if (Param.Length == 1)
{
Result = SystemInvoke(Param[0]);
continue;
}
Result = SystemInvoke(Param[0], Param[1]);
continue;
}
Result = SystemInvoke("VUF"+Funcs[I], Params[I]);
}
return Result;
}

}
}