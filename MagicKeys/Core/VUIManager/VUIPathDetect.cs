using System;
using System.IO;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static string VUIPathDetect(string VUIName)
{
if (File.Exists(API.GetVUIPath()+VUIName+".vui") == true)
{
return API.GetVUIPath()+VUIName+".vui";
}
string Temp = API.GetVUIPath().Split(@"\")[1];
string BaseVUIPath = Temp.Remove(Temp.IndexOf("Lib"));
return @"Plugins\"+BaseVUIPath+@"\VUI\"+VUIName+".vui";
}

}
}