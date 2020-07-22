using System;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static string FuncParse(string FuncParam)
{
string[] Temp = FuncParam.Split("|");
return Temp[0];
}

}
}