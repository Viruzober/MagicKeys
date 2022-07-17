using System.Collections.Generic;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void GlobalPluginLoad(string PluginName, PluginPointContainer Point)
{

CurrentPlugin.PluginName = PluginName;
CurrentPlugin.WTitle = Point.WTitle;
CurrentPlugin.WClass = Point.WClass;
CurrentPlugin.PluginClass = Point.PluginClass;
CurrentPlugin.VUIName = Point.StartVUI;
CurrentPlugin.Module = Point.Module;

}

}
}