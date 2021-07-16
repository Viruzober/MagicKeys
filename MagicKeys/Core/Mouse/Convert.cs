using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static int MouseConvertX(int X)
{
return MXDC*X;
}

public static int MouseConvertY(int Y)
{
return MYDC*Y;
}

}
}