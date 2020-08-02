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
FileStream SoundFileStream = File.OpenRead(@".\Sounds\"+SoundFile);
long length = SoundFileStream.Length;
byte[] buffer = new byte[length];
SoundFileStream.Read(buffer, 0, (int)length);
SoundFileStream.Close();
GCHandle HGCFile = GCHandle.Alloc(buffer, GCHandleType.Pinned );
if (!Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero)) return;
int Stream = Bass.BASS_StreamCreateFile(HGCFile.AddrOfPinnedObject(), 0L, length, BASSFlag.BASS_SAMPLE_FLOAT);
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