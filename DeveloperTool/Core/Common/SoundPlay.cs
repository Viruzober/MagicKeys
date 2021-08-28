using System.IO;
using System.Media;
using static MKLib;

namespace DeveloperTool
{
public partial class DeveloperTool
{

public static void SoundPlay(string SoundFile, bool Wait = false)
{
string SoundPath = @$".\Sounds\{SoundFile}.ogg";
MKLib.PlaySound(SoundPath, Wait);
}

}
}