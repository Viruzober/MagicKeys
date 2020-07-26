using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void VUFInvoke(List<string> Action)
{
for(int I = 0 ; I <= Action.Count-1; I++)
{
string[] FP = Action[I].Split("|", 2);
InvokeFromString("VUF"+FP[0], FP[1]);
}
}

}
}