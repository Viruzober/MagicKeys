using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

namespace MagicKeys
{
public partial class MagicKeys
{
public static string Version = "1.4";
public static bool RegUser = true;
public static Size Display = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
public static int Width = Display.Width;
public static int Height = Display.Height;
// буфер для функции отслеживания изменений на экране.
public static Bitmap OneScreen;
// Флаг для выхода из зависания.
public static bool LoopError = false;
// Флаг для включения/отключения MagicKeys.
public static int KeySwitch = 0;
public static int NavigationType = 0;
public static bool SoundTheme = true;
public static bool SpeachType = false;
// Задержка в цикле обнаружения окон.
public static int TimeOut = 20;
// Имя класса для обнаруженного окна.
public static string PluginClass = string.Empty;
// Объектная модель текущего интерфейса.
public static Dictionary<int, bool> VUIObjects = new Dictionary<int, bool>();
public static List<int> ActiveObjects = new List<int>();
// Текущий загруженный интерфейс.
public static string IniFile = string.Empty;
// Количество объектов интерфейса.
public static int Count;
// Номер текущего объекта интерфейса.
public static int Section;
// состояние обнаружения, Координаты и размеры текущего контрола. Обновляется динамически.
public static int[] P = new int[10];
// Для хранения временных координат.
public static int[] DP = new int[10];
public static int nChars = 256;
public static StringBuilder Title = new StringBuilder(nChars);
public static StringBuilder Class = new StringBuilder(nChars);
public static StringBuilder Text = new StringBuilder(nChars);
// Часть заголовков и классы окон для обнаружения.
public static string[] HWNDFXTrack = {"FX: Track", "#32770"};
public static string[] HWNDKontaktB = {"Kontakt (x64 bridged)", "REAPERb32host"};
public static string[] HWNDKontaktCM = {"Content Missing", "#32770"};
public static string[] HWNDKontaktP = {"Progress", "#32770"};
public static string[] HWNDNexus = {"reFX Nexus", "REAPERb32host"};
public static string[] HWNDPlugSound = {"PS0", "REAPERb32host"};
public static string[] HWNDPlugSoundFree ={"Plugsound", "REAPERb32host"};
}
}