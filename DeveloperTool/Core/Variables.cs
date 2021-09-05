using System.Drawing;
using System.Text;

namespace DeveloperTool
{

public partial class DeveloperTool
{
public static bool LockDeveloperTool = false;
public static bool LockKeys = false;
public static ModuleCoords Coords;
public static int[] OCRSize = new int[2];
public static string ProjectName = string.Empty;
public static string PointName = string.Empty;
public static string VUIName = string.Empty;
public static string ModuleName = string.Empty;
public static int MouseStep = 1;
public static int OCRZoom = 1;
public static bool AutoOCR = false;
}
}