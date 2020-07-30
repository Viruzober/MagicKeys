using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static string VUFAutoFunc(List<string> Action)
{
string R = null;
for(int I = 0 ; I <= Action.Count-1; I++)
{
string[] FP = Action[I].Split("|", 2);
if (FP[0] == "Func")
{
string[] Param = FP[1].Split("|", 2);
if (Param.Length == 1)
{
R += " "+InvokeFromString(Param[0]);
continue;
}
R += " "+InvokeFromString(Param[0], Param[1]);
continue;
}
R += " "+InvokeFromString("VUF"+FP[0], FP[1]);
}
return R;
}

}
}