using System;
using System.Runtime.InteropServices;
using System.Text;
namespace MagicKeys
{
    public partial class MagicKeys
{
[DllImport("user32.dll")]
[return: MarshalAs(UnmanagedType.Bool)]
static extern bool IsWindowEnabled(IntPtr hWnd);
[DllImport("user32.dll", SetLastError = true)]
static extern IntPtr SendMessage(IntPtr hWnd, WM Msg, int wParam, StringBuilder lParam);
[DllImport("user32.dll")]
[return: MarshalAs(UnmanagedType.Bool)]
public static extern bool EnumChildWindows(IntPtr hwndParent, EnumChildProcDelegate lpEnumFunc, IntPtr lParam);
#if X86
[DllImport("ImageSearch32.dll")]
public static extern IntPtr ImageSearch(int x, int y, int right, int bottom, string imagePath);
#elif X64
[DllImport("ImageSearch64.dll")]
public static extern IntPtr ImageSearch(int x, int y, int right, int bottom, string imagePath);
#endif
[DllImport("user32.dll")]
public static extern int GetSystemMetrics(int smIndex);
[DllImport("user32.dll", SetLastError = true)]
public static extern uint SendInput(uint nInputs, ref INPUT pInputs, int cbSize);
[DllImport("user32.dll", SetLastError = true)]
[return: MarshalAs(UnmanagedType.Bool)]
public static extern bool GetCursorPos(out WinPoint Point);
[DllImport("user32.dll")]
public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
[DllImport("user32.dll")]
public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName,int nMaxCount);
[DllImport("user32.dll")]
public static extern IntPtr GetForegroundWindow();
[DllImport("user32.dll", SetLastError=true)]
public static extern bool GetWindowRect(IntPtr hwnd, out WinRect lpRect);
[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
[DllImport("user32.dll", SetLastError = true)]
public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
[DllImport("user32.dll")]
public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
[DllImport("user32.dll")]
public static extern IntPtr WindowFromPoint(WinPoint p);
#if X86
[DllImport("nvdaControllerClient32.dll")]
public static extern int nvdaController_cancelSpeech();
[DllImport("nvdaControllerClient32.dll", CharSet = CharSet.Unicode)]
public static extern int nvdaController_speakText(string text);
#elif X64
[DllImport("nvdaControllerClient64.dll")]
public static extern int nvdaController_cancelSpeech();
[DllImport("nvdaControllerClient64.dll", CharSet = CharSet.Unicode)]
public static extern int nvdaController_speakText(string text);
#endif
[DllImport("user32.dll", CharSet = CharSet.Auto)]
public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, IntPtr lParam);
[DllImport("user32.dll", ExactSpelling = true)]
public static extern IntPtr GetAncestor(IntPtr hwnd, uint flags);
[DllImport("user32.dll")]
public static extern bool GetMenuItemRect(IntPtr hWnd, IntPtr hMenu, uint uItem, out MenuRect lprcItem);
[DllImport("user32.dll", EntryPoint = "SetWindowPos")]
public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);
[DllImport("User32.dll")]
public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);
[DllImport("user32.dll")]
[return: MarshalAs(UnmanagedType.Bool)]
public static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);
[DllImport("user32.dll")]
private static extern UInt32 GetWindowThreadProcessId(Int32 hWnd, out Int32 lpdwProcessId);
#if X86
[DllImport("user32.dll", EntryPoint="GetWindowLong")]
private static extern IntPtr GetWindowLongPtr32(IntPtr hWnd, GWL nIndex);
#elif X64
[DllImport("user32.dll", EntryPoint="GetWindowLongPtr")]
private static extern IntPtr GetWindowLongPtr64(IntPtr hWnd, GWL nIndex);
#endif
[DllImport("kernel32.dll", SetLastError = true)]
public static extern IntPtr OpenProcess(ProcessAccessFlags processAccess, bool bInheritHandle, int processId);
[DllImport("psapi.dll")]
static extern uint GetModuleFileNameEx(IntPtr hProcess, IntPtr hModule, [Out] StringBuilder lpBaseName, [In] [MarshalAs(UnmanagedType.U4)] int nSize);
}
}