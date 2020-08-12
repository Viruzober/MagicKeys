using System.Runtime.InteropServices;
using System;
 
namespace MagicKeys
{
 public partial class DeveloperTool
{
[DllImport("kernel32.dll", SetLastError = true)]
public static extern bool Beep(int frequency, int duration);

public static void SoundBeep(int Frequency)
{
Beep(Frequency, 100);
        }

}
}