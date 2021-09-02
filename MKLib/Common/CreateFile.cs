using System;
using System.Linq;
using System.IO;

public static partial class MKLib
{

public static void CreateFile(string PathFile)
{
Directory.CreateDirectory(Path.GetDirectoryName(PathFile));
File.Create(PathFile).Close();
}

}