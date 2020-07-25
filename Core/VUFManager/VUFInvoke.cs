using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void VUFInvoke(List<string> Func, List<string> Param, int TimeOut)
{
for(int I = 0; I <= Func.Count-1; I++)
{
Thread.Sleep(TimeOut);
MessageBox.Show(Func[I], Param[I]);
if (Func[I] == (I+1).ToString()+"Func")
{
string[] FP = Param[I].Split("|");
if (FP[1] == "No")
{
InvokeFromString(FP[0]);
continue;
}
InvokeFromString(FP[0], FP[1]);
continue;
}
InvokeFromString("VUF"+Func[I], Param[I]);
}
}

}
}