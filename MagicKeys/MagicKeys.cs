using System;
using System.Reflection;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;

namespace MagicKeys
{
public partial class MagicKeys
{

public static Menu HM;

static void Main(string[] args)
{
if (CheckRunProc("MagicKeys") == true) return;
#if X86
if (OS() == "64")
{
MessageBox.Show("Эта версия MagicKeys предназначенна для windows x86. Используйте версию MagicKeys x64.", "Внимание");
return;
}
#endif
if (CheckInternet() == true)
{
string UI = UserInfo(PCID());
if (UI != "Reg user")
{
RegUser = false;
MessageBox.Show("Пожалуйста зарегистрируйтесь через меню на панели задач.", "Внимание");
}
}
LoadSettings();
SoundPlay("Start.ogg", 0);
Speak("Сервис Magic Keys запущен");
HM = new Menu();
PluginsListLoader();
Thread ThreadPluginDetector = new Thread(new ThreadStart(PluginDetector));
ThreadPluginDetector.IsBackground = true;
ThreadPluginDetector.Start();
RegisterHotKey(HM.Handle, 0, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F1);
RegisterHotKey(HM.Handle, 1, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F2);
RegisterHotKey(HM.Handle, 3, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F5);
RegisterHotKey(HM.Handle, 4, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F6);
Application.Run();
}

}
}