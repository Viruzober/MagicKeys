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
CurrentPlugin["PluginName"] = CurrentPlugin["PluginName"].Split(".")[0];
CurrentPlugin["PluginClass"] = CurrentPlugin["PluginClass"].Split(".")[0];
}
}
}