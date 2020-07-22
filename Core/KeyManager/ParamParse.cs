using System;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static string ParamParse(string FuncParam)
{
string[] Temp = FuncParam.Split("|");
if (Temp.Length > 1)
{
return Temp[1];
}
return null;
}

}
}