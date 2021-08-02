using System;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;
using System.Media;
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