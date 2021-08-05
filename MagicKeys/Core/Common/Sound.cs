using System.Media;

namespace MagicKeys
{
public partial class MagicKeys
{
public static void SoundPlay(string SoundFile, int Wait)
{
if (SoundTheme == true)
{
string SoundPath = @$".\Sounds\{SoundFile}.wav";
SoundPlayer Player = new SoundPlayer();
Player.SoundLocation = SoundPath;
if (Wait == 0)
{
Player.Play();
}
else
{
Player.PlaySync();
}
}
}

}
}