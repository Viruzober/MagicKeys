using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Drawing;
namespace ConfigInstaller
{
public partial class ConfigInstaller
{
public static Size Display = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
public static int DWidth = Display.Width;
public static int DHeight = Display.Height;
public enum DMDO
{
DEFAULT = 0,
D90 = 1,
D180 = 2,
D270 = 3
}
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
struct DEVMODE
{
public const int DM_PELSWIDTH = 0x80000;
public const int DM_PELSHEIGHT = 0x100000;
private const int CCHDEVICENAME = 32;
private const int CCHFORMNAME = 32;
[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHDEVICENAME)]
public string dmDeviceName;
public short dmSpecVersion;
public short dmDriverVersion;
public short dmSize;
public short dmDriverExtra;
public int dmFields;
public int dmPositionX;
public int dmPositionY;
public DMDO dmDisplayOrientation;
public int dmDisplayFixedOutput;
public short dmColor;
public short dmDuplex;
public short dmYResolution;
public short dmTTOption;
public short dmCollate;
[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHFORMNAME)]
public string dmFormName;
public short dmLogPixels;
public int dmBitsPerPel;
public int dmPelsWidth;
public int dmPelsHeight;
public int dmDisplayFlags;
public int dmDisplayFrequency;
public int dmICMMethod;
public int dmICMIntent;
public int dmMediaType;
public int dmDitherType;
public int dmReserved1;
public int dmReserved2;
public int dmPanningWidth;
public int dmPanningHeight;
}
[DllImport("user32.dll", CharSet = CharSet.Auto)]
static extern int ChangeDisplaySettings([In] ref DEVMODE lpDevMode, int dwFlags);
public static void ChangeDPI(int dpi)
{
int WR = DWidth, HR = DHeight;
SetResolution(1024, 768);
RegistryKey key = Registry.CurrentUser.OpenSubKey("Control Panel", true);
key = key.OpenSubKey("Desktop", true);
key = key.OpenSubKey("PerMonitorSettings", true);
foreach (var RegDSP in key.GetSubKeyNames())
{
var Gkey = key.OpenSubKey(RegDSP, true);
Gkey.SetValue("DpiValue", dpi);
Gkey.Close();
}
SetResolution(WR, HR);
}
public static void SetResolution(int w, int h)
{
long RetVal = 0;
DEVMODE dm = new DEVMODE();
dm.dmSize = (short)Marshal.SizeOf(typeof(DEVMODE));
dm.dmPelsWidth = w;
dm.dmPelsHeight = h;
dm.dmFields = DEVMODE.DM_PELSWIDTH | DEVMODE.DM_PELSHEIGHT;
RetVal = ChangeDisplaySettings(ref dm, 0);
}
public static int[] GetMaxScreenSize()
{
var scope = new System.Management.ManagementScope();
var q = new System.Management.ObjectQuery("SELECT * FROM CIM_VideoControllerResolution");
var searcher = new System.Management.ManagementObjectSearcher(scope, q);
var results = searcher.Get();
UInt32 maxHResolution = 0;
UInt32 maxVResolution = 0;
foreach (var item in results)
{
if ((UInt32)item["HorizontalResolution"] > maxHResolution)
maxHResolution = (UInt32)item["HorizontalResolution"];
if ((UInt32)item["VerticalResolution"] > maxVResolution)
maxVResolution = (UInt32)item["VerticalResolution"];
}
return new int[2]{Convert.ToInt32(maxHResolution), Convert.ToInt32(maxVResolution)};
}
}
}