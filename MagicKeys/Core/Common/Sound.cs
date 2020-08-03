using System;
using System.Threading;
using Un4seen.Bass;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void SoundPlay(string SoundFile, int Wait)
{
if (SoundTheme == true)
{
                Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
int Stream = Bass.BASS_StreamCreateFile(@".\Sounds\"+SoundFile, 0L, 0, BASSFlag.BASS_STREAM_AUTOFREE);
Bass.BASS_ChannelPlay(Stream, false);
if (Wait ==1)
{
double Time = Bass.BASS_ChannelBytes2Seconds(Stream, Bass.BASS_ChannelGetLength(Stream));
int T = Convert.ToInt32(Time * 1000);
Thread.Sleep(T);
}
}
else
{
return;
}
}

}
}