using System.Drawing;
using System.Text;

namespace MagicKeys
{

public partial class DeveloperTool
{

public static Size Display = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
public static int Width = Display.Width;
public static int Height = Display.Height;
public static int KeySwitch = 0;
public static int[] P = new int[10];
public static int[] DP = new int[10];
public static int nChars = 256;
public static StringBuilder Text = new StringBuilder(nChars);
public static StringBuilder Title = new StringBuilder(nChars);
public static StringBuilder Class = new StringBuilder(nChars);
public static string Module = string.Empty;
public static int MouseStep = 1;
public static int OCRZoom = 1;
public static string OCRR = string.Empty;
public static int AutoOCR = 0;
}
}