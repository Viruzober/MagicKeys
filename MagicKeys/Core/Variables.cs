using System;
using System.Drawing;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Text;

namespace MagicKeys
{
public partial class MagicKeys
{
public static Size Display = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
public static int Width = Display.Width;
public static int Height = Display.Height;
public static decimal MXDC = 65535/Width;
public static decimal MYDC = 65535/Height;
public static Bitmap OneScreen;
public static int KeySwitch = 0;
public static int NavigationType = 0;
public static bool SoundTheme = true;
public static bool SpeakType = false;
public static bool Exit = true;
public static int TimeOut = 20;
public static string UpdCH = "Release";
public static Dictionary<int, Dictionary<string, string>> VUIObjects = new Dictionary<int, Dictionary<string, string>>();
public static List<int> ActiveObjects = new List<int>();
public static int Count;
public static int Section;
public static int[] P = new int[10];
public static int[] DP = new int[10];
public static int nChars = 256;
public static StringBuilder Text = new StringBuilder(nChars);
public static StringBuilder Title = new StringBuilder(nChars);
public static StringBuilder Class = new StringBuilder(nChars);
public static string SubPath = string.Empty;
public static string CopyText = String.Empty;
}
}