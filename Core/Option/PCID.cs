using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using System.Runtime.InteropServices;

namespace MagicKeys
{
public partial class MagicKeys
{

public static string PCID()
{
ManagementObject os = new ManagementObject("Win32_OperatingSystem=@");
string serial = (string)os["SerialNumber"];
return serial;
}

}
}