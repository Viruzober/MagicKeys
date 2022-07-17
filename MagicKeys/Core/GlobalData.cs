using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MagicKeys
{

public partial class MagicKeys
{

public static bool LockPluginDetect = false;
public static List<PluginContainer> Plugins = new List<PluginContainer>();
public static ModuleCoords Coords;
public static CurrentPluginContainer CurrentPlugin = new CurrentPluginContainer();
public static List<VUIKeyFuncContainer> VUIKeysFunctions = new List<VUIKeyFuncContainer>();
public static List<VUIObjectContainer> AllVUIObjects = new List<VUIObjectContainer>();
public static List<VUIObjectContainer> VisibleVUIObjects = new List<VUIObjectContainer>();
public static string ThreadFunc = string.Empty;

}
}