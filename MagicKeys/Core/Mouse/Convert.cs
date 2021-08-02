using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace MagicKeys
{
public partial class MagicKeys
{
public static int MouseConvertX(int X)
{
return Convert.ToInt32(MXDC*(decimal)X);
}
public static int MouseConvertY(int Y)
{
return Convert.ToInt32(MYDC*(Decimal)Y);
}
}
}