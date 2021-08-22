using System;
using System.Runtime.InteropServices;
using System.Text;

public static partial class MKLib
{
[DllImport("user32.dll")]
public static extern int GetDlgCtrlID(IntPtr hwndCtl);
[DllImport("user32.dll")]
static extern int GetMenuString(IntPtr hMenu, uint uIDItem, [Out] StringBuilder lpString, int nMaxCount, uint uFlag);
[DllImport("user32.dll")]
static extern IntPtr GetClipboardData(uint uFormat);
[DllImport("user32.dll")]
static extern bool IsClipboardFormatAvailable(uint format);
[DllImport("user32.dll", SetLastError = true)]
static extern bool OpenClipboard(IntPtr hWndNewOwner);
[DllImport("user32.dll", SetLastError = true)]
static extern bool CloseClipboard();
[DllImport("kernel32.dll")]
static extern IntPtr GlobalLock(IntPtr hMem);
[DllImport("kernel32.dll")]
static extern bool GlobalUnlock(IntPtr hMem);
[DllImport("user32.dll")]
[return: MarshalAs(UnmanagedType.Bool)]
public static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);
[DllImport("user32.dll")]
[return: MarshalAs(UnmanagedType.Bool)]
public static extern bool EnumChildWindows(IntPtr hwndParent, EnumChildProcDelegate lpEnumFunc, IntPtr lParam);
[DllImport("user32.dll")]
public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
[DllImport("user32.dll", SetLastError = true)]
public static extern IntPtr SendMessage(IntPtr hWnd, WM Msg, int wParam, StringBuilder lParam);
[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
public static extern int GetClassName(IntPtr hWnd, StringBuilder lClassName,int nMaxCount);
[DllImport("user32.dll")]
public static extern IntPtr GetForegroundWindow();
[DllImport("user32.dll", SetLastError=true)]
public static extern bool GetWindowRect(IntPtr hwnd, out WinRect lpRect);
[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
[DllImport("user32.dll", SetLastError = true)]
public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
[DllImport("user32.dll")]
public static extern IntPtr WindowFromPoint(WinPoint p);
[DllImport("user32.dll", CharSet = CharSet.Auto)]
public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, IntPtr lParam);
[DllImport("user32.dll")]
static extern int GetMenuItemCount(IntPtr hMenu);
[DllImport("user32.dll")]
public static extern bool GetMenuItemRect(IntPtr hWnd, IntPtr hMenu, uint uItem, out MenuRect lprcItem);
[DllImport("user32.dll", EntryPoint = "SetWindowPos")]
public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);
[DllImport("User32.dll")]
public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);
[DllImport("kernel32.dll", SetLastError=true)]
[return: MarshalAs(UnmanagedType.Bool)]
public static extern bool CloseHandle(IntPtr hObject);
#if X86
[DllImport("ImageSearch32.dll")]
public static extern IntPtr ImageSearch(int x, int y, int right, int bottom, string imagePath);
#else
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
#if X86
[DllImport("nvdaControllerClient32.dll")]
public static extern int nvdaController_cancelSpeech();
[DllImport("nvdaControllerClient32.dll", CharSet = CharSet.Unicode)]
public static extern int nvdaController_speakText(string text);
[DllImport("nvdaControllerClient32.dll", CharSet = CharSet.Unicode)]
public static extern int nvdaController_brailleMessage(string Text);
#else
[DllImport("nvdaControllerClient64.dll")]
public static extern int nvdaController_cancelSpeech();
[DllImport("nvdaControllerClient64.dll", CharSet = CharSet.Unicode)]
public static extern int nvdaController_speakText(string text);
[DllImport("nvdaControllerClient64.dll", CharSet = CharSet.Unicode)]
public static extern int nvdaController_brailleMessage(string Text);
#endif
#if X64
[DllImport("WinRTOCR64.dll")]
public static extern IntPtr Recognize(IntPtr Img, uint Size, [MarshalAs(UnmanagedType.LPTStr)] string Lang);
#else
[DllImport("WinRTOCR32.dll")]
public static extern IntPtr Recognize(IntPtr Img, uint Size, [MarshalAs(UnmanagedType.LPTStr)] string Lang);
#endif
[DllImport( "user32.dll", SetLastError = true )]
public static extern int GetWindowThreadProcessId ( IntPtr hWnd, out int lpdwProcessId );
[DllImport("kernel32.dll")]
public static extern uint GetCurrentThreadId();
[DllImport("user32.dll")]
public static extern bool AttachThreadInput(uint idAttach, uint idAttachTo, bool fAttach);
#if X86
[DllImport("user32.dll", EntryPoint="GetWindowLong")]
public static extern IntPtr GetWindowLongPtr32(IntPtr hWnd, GWL nIndex);
#else
[DllImport("user32.dll", EntryPoint="GetWindowLongPtr")]
public static extern IntPtr GetWindowLongPtr64(IntPtr hWnd, GWL nIndex);
#endif
[DllImport("kernel32.dll", SetLastError = true)]
public static extern IntPtr OpenProcess(ProcessAccessFlags processAccess, bool bInheritHandle, int processId);
[DllImport("psapi.dll")]
public static extern uint GetModuleFileNameEx(IntPtr hProcess, IntPtr hModule, [Out] StringBuilder lpBaseName, [In] [MarshalAs(UnmanagedType.U4)] int nSize);
[DllImport("user32.dll", SetLastError = true)]
public static extern IntPtr SetFocus(IntPtr hWnd);
[DllImport("user32.dll", SetLastError = true)]
public static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);
}