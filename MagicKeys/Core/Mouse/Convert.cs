using System;

namespace MagicKeys
{

public partial class MagicKeys
{

public static int MouseConvertX(int X)
{
return Convert.ToInt32(65535 / GetDisplayResolution().Width * X);
}

public static int MouseConvertY(int Y)
{
return Convert.ToInt32(65535 / GetDisplayResolution().Height * Y);
}

}
}