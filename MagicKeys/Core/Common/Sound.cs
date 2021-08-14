using System.IO;
using System.Media;
using csogg;
using csvorbis;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void SoundPlay(string SoundFile, int Wait)
{
if (Settings.SoundTheme == true)
{
string SoundPath = @$".\Sounds\{SoundFile}.ogg";
using (var file = new FileStream(SoundPath, FileMode.Open, FileAccess.Read))
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

}
}