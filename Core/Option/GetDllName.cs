using System;
using System.Diagnostics;
using System.Text;
using System.Runtime.InteropServices;

namespace MagicKeys
{
public partial class MagicKeys
{

public static string GetDllName(IntPtr Handle)
{
Int32 ProcessID;
GetWindowThreadProcessId(Handle.ToInt32(), out ProcessID);
IntPtr OP = OpenProcess(ProcessAccessFlags.QueryInformation | ProcessAccessFlags.VirtualMemoryRead, false, ProcessID);
#if X86
IntPtr GGWL = GetWindowLongPtr32(Handle, GWL.GWL_HINSTANCE);
#elif X64
IntPtr GGWL = GetWindowLongPtr64(Handle, GWL.GWL_HINSTANCE);
#endif
GetModuleFileNameEx(OP, GGWL, Text, nChars);
return Text.ToString();
}

public enum ProcessAccessFlags : uint
{
All = 0x001F0FFF,
Terminate = 0x00000001,
CreateThread = 0x00000002,
VirtualMemoryOperation = 0x00000008,
VirtualMemoryRead = 0x00000010,
VirtualMemoryWrite = 0x00000020,
DuplicateHandle = 0x00000040,
CreateProcess = 0x000000080,
SetQuota = 0x00000100,
SetInformation = 0x00000200,
QueryInformation = 0x00000400,
QueryLimitedInformation = 0x00001000,
Synchronize = 0x00100000
}

public enum GWL
{
GWL_WNDPROC =    (-4),
GWL_HINSTANCE =  (-6),
GWL_HWNDPARENT = (-8),
GWL_STYLE =      (-16),
GWL_EXSTYLE =    (-20),
GWL_USERDATA =   (-21),
GWL_ID =     (-12)
}

}
}