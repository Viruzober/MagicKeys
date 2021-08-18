using Microsoft.Collections.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MagicKeys
{

public partial class MagicKeys
{
public static bool LockPluginDetect = false;
public static OrderedDictionary<string, OrderedDictionary<string, string>> VUIObjects = new OrderedDictionary<string, OrderedDictionary<string, string>>();
public static List<string> ActiveObjects = new List<string>();
public static int ObjectsCount;
public static int CurrentObject;
public static ModuleCoords Coords;
public static string ThreadFunc = string.Empty;

}
}