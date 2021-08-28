using System;
using System.Windows.Forms;

public static partial class MKLib
{

public static string GetKeyName(int Key)
{
if (Key == 13)
{
return "Enter";
}
if (Key == 33)
{
return "PageUp";
}
if (Key == 34)
{
return "PageDown";
}
if (Key >= 48 && Key <= 57)
{
return ((char)Key).ToString();
}
if (Key == 189)
{
return "-";
}
if (Key == 187)
{
return "+";
}
return ((Keys)Key).ToString();
}

}