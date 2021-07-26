using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace MagicKeys
{
public partial class MagicKeys
{

public static string OS()
{
bool Bit = Environment.Is64BitOperatingSystem;
if (Bit == true)
{
return "64";
}
return "86";
}

}
}