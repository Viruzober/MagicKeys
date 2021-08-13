using System.IO;
using System.Linq;

namespace MKUpdater
{

public partial class MKUpdater
{

public static void CopyDirectory(string source, string target) 
{ 
var sourcePath = source.TrimEnd('\\', ' '); 
var targetPath = target.TrimEnd('\\', ' '); 
var files = Directory.EnumerateFiles(sourcePath, "*", SearchOption.AllDirectories).GroupBy(s=> Path.GetDirectoryName(s));
foreach (var folder in files) 
{ 
var targetFolder = folder.Key.Replace(sourcePath, targetPath);
Directory.CreateDirectory(targetFolder); 
foreach (var file in folder) 
{ 
var targetFile = Path.Combine(targetFolder, Path.GetFileName(file)); 
if (File.Exists(targetFile))
{
File.Delete(targetFile);
}

File.Move(file, targetFile); 
}
}
}

}
}