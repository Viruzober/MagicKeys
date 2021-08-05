using Microsoft.Collections.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
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
public static string UpdateChannel = GetUpdateChannel();
public static bool CheckUpdate= true;
public static OrderedDictionary<string, OrderedDictionary<string, string>> VUIObjects = new OrderedDictionary<string, OrderedDictionary<string, string>>();
public static List<string> ActiveObjects = new List<string>();
public static int CountObjects;
public static int CurrentObject;
public static int[] P = new int[10];
public static int[] DP = new int[10];
public static int nChars = 256;
public static StringBuilder Text = new StringBuilder(nChars);
public static StringBuilder Title = new StringBuilder(nChars);
public static StringBuilder Class = new StringBuilder(nChars);
public static string CopyText = String.Empty;
}
}