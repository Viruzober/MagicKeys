using System;
using System.Windows.Forms;

public static partial class MKLib
{
public static Keys ConvertToKeys(string Key)
{
if (Key == "-")
{
return Keys.OemMinus;
}
else if (Key == "=")
{
return Keys.Oemplus;
}
return (Keys)new KeysConverter().ConvertFrom(Key);
}

}