using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using System.Runtime.InteropServices;

namespace MagicKeys
{
public partial class MagicKeys
{

public static string OS()
{
ManagementObject os = new ManagementObject("Win32_OperatingSystem=@");
string Bit = ((string)os["OSArchitecture"]).Remove(3);
return Bit;
}

}
}