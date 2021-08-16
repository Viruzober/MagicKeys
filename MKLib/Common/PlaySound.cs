using System.IO;
using System.Media;
using csogg;
using csvorbis;

public static partial class MKLib
{

public static void PlaySound(string SoundFile, int Wait)
{
using (var file = new FileStream(SoundFile, FileMode.Open, FileAccess.Read))
{
var OGGD = new OggDecoder.OggDecodeStream(file);
SoundPlayer Player = new SoundPlayer(OGGD);
if (Wait == 0)
{
Player.Play();
}
else
{
Player.PlaySync();
}
Player.Dispose();
}
}

}