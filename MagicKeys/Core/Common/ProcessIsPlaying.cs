using System.Data;
using CSCore.CoreAudioAPI;
using CSCore.Codecs.WAV;
using CSCore.DirectSound;
using CSCore.SoundOut;
using CSCore.Win32;
using CSCore.Utils;
using System.Diagnostics;
using System;
using System.Linq;
using System.Threading;
using CSCore;
using CSCore.Streams.Effects;

namespace MagicKeys
{
public partial class MagicKeys
{

public static bool ProcessIsPlaying(string ProcessName)
{
var enumerator = new MMDeviceEnumerator();
foreach (MMDevice device in enumerator.EnumAudioEndpoints(DataFlow.All, DeviceState.Active))
{
var sessionManager = AudioSessionManager2.FromMMDevice(device);
var sessionEnumerator = sessionManager.GetSessionEnumerator();
var Sessions = sessionEnumerator.Where(P => P.QueryInterface<AudioSessionControl2>().Process.ProcessName == ProcessName);
foreach (var session in Sessions)
{
if (session.QueryInterface<AudioMeterInformation>().GetPeakValue() > 0)
{
return true;
}
}
}
return false;
}

}
}