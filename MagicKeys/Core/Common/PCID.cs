using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
namespace MagicKeys
{
public partial class MagicKeys
{

public static string PCID()
{
string Serial = RegReader(Registry.LocalMachine, @"SOFTWARE\Microsoft\Cryptography", "MachineGuid");
return Serial;
}

}
}