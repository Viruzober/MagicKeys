using System;
using System.IO;
using System.Text;

namespace MagicKeys
{

public partial class MagicKeys
{

public static string GetDllName(IntPtr Handle)
{
int nChars = 256;
StringBuilder Text = new StringBuilder(nChars);
Int32 ProcessID;
GetWindowThreadProcessId(Handle, out ProcessID);
IntPtr OP = OpenProcess(ProcessAccessFlags.QueryInformation | ProcessAccessFlags.VirtualMemoryRead, false, ProcessID);
#if X86
IntPtr GGWL = GetWindowLongPtr32(Handle, GWL.GWL_HINSTANCE);
#else
IntPtr GGWL = GetWindowLongPtr64(Handle, GWL.GWL_HINSTANCE);
#endif
GetModuleFileNameEx(OP, GGWL, Text, nChars);
CloseHandle(OP);
return Path.GetFileName(Text.ToString());
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