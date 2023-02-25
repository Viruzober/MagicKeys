using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicKeys
{
public static class Settings
{

public static bool NavigationType = false;
public static bool SoundTheme = true;
public static bool SpeakType = false;
public static bool Exit = true;
public static int TimeOut = 20;
public static string UpdateChannel = MagicKeys.GetUpdateChannel();
public static bool CheckUpdate= true;

}
}