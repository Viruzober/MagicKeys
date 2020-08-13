using System;
using System.Net.NetworkInformation;

namespace MagicKeys
{
public partial class MagicKeys
{

public static bool CheckInternet()
{
IPStatus status = IPStatus.Unknown;
try
{
status = new Ping().Send("viruzober.tk", 2000).Status;
}
catch{}
if (status == IPStatus.Success)
{
return true;
}
else
{
return false;
}
}

}
}