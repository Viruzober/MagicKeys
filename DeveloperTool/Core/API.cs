using System;
using System.IO;

namespace DeveloperTool
{
public static class API
{

public static string GetVUIPath()
{
return Path.Combine("Projects", DeveloperTool.ProjectName, "VUI");
}

public static string GetCurrentVUI()
{
return Path.Combine("Projects", DeveloperTool.ProjectName, "VUI", DeveloperTool.VUIName+".vui");
}

public static string GetImagePath()
{
return Path.Combine("Projects", DeveloperTool.ProjectName, "Images");
}

public static string GetManifestPath()
{
return Path.Combine("Projects", DeveloperTool.ProjectName, "Manifest.ini");
}

}
}