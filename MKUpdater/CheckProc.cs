using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;
namespace MKUpdater
{
public partial class MKUpdater
{
[Flags]
private enum ProcessAccessFlags : uint
{
QueryLimitedInformation = 0x00001000
}
[DllImport("kernel32.dll", SetLastError = true)]
private static extern bool QueryFullProcessImageName(
[In] IntPtr hProcess,
[In] int dwFlags,
[Out] StringBuilder lpExeName,
ref int lpdwSize);
[DllImport("kernel32.dll", SetLastError = true)]
private static extern IntPtr OpenProcess(
ProcessAccessFlags processAccess,
bool bInheritHandle,
int processId);
public static String GetProcessFilepath(int pId)
{
int capacity = 2000;
StringBuilder builder = new StringBuilder(capacity);
IntPtr ptr = OpenProcess(ProcessAccessFlags.QueryLimitedInformation, false, pId);
if (!QueryFullProcessImageName(ptr, 0, builder, ref capacity))
{
return String.Empty;
}
return builder.ToString();
}
public static string CheckProc()
{
Process[] proc = Process.GetProcesses();
int[] pIds = proc.Select(p => p.Id).ToArray();
var MKProc = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
string CloseProc = string.Empty;
foreach (int id in pIds)
{
if(GetProcessFilepath(id).Contains("MKUpdater")) continue;
if(GetProcessFilepath(id).Contains(MKProc))
{
CloseProc += Path.GetFileName(GetProcessFilepath(id))+"\r\n";
}
}
return CloseProc;
}
}
}