using System;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.Collections.Generic;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void SubPluginUnLoad()
{
if (API.GetVUIPath().Contains("Lib") == true)
{
string Temp = API.GetVUIPath().Split(@"\")[1];
string BackPluginName = Temp.Remove(Temp.IndexOf("Lib", StringComparison.Ordinal));
CurrentPlugin["PluginName"] = BackPluginName;
SubPath = "";
}
}

}
}