using System.Data;
using System.Diagnostics;
using System;
using System.Linq;
using System.Threading;
using CoreAudio;
using CoreAudio.Interfaces;

public static partial class MKLib
{

public static bool ProcessIsPlaying(string ProcessName)
{
var enumerator = new MMDeviceEnumerator();
foreach (MMDevice device in enumerator.EnumerateAudioEndPoints(CoreAudio.EDataFlow.eAll, DEVICE_STATE.DEVICE_STATE_ACTIVE))
{
var sessionManager = device.AudioSessionManager2.Sessions;
var Sessions = sessionManager.Where(p => p.DisplayName.Contains(ProcessName));
foreach (var session in Sessions)
{
if (session.AudioMeterInformation.MasterPeakValue > 0)
{
return true;
}
}
}
return false;
}

}