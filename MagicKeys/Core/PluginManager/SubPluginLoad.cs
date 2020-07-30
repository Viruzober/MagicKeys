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

public static void SubPluginLoad()
{
string[] dir = Directory.GetDirectories(@"Plugins\"+SubPath);
for (int D = 0; D <= dir.Length-1; D++)
{
if (File.Exists(dir[D]+@"\Manifest.ini") == false)
{
continue;
}
string IVUI = dir[D]+@"\Manifest.ini";

}
}

}
}