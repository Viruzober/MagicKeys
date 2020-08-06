using System;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;
using System.Text;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void SoundPlay(string SoundFile, int Wait)
{
if (SoundTheme == true)
{
mciSendString("open \"" + @".\Sounds\" + SoundFile + "\" alias Notification", null, 0, IntPtr.Zero);
if (Wait == 0)
{
mciSendString("play Notification", null, 0, IntPtr.Zero);
}
else
{
mciSendString("play Notification wait", null, 0, IntPtr.Zero);
}    
}
else
{
return;
}
}

}
}