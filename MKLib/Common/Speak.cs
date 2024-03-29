using System;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Linq;

public static partial class MKLib
{

public static void Speak(string Text, bool Wait = false)
{
var runningProcs = from proc in Process.GetProcesses(".") orderby proc.Id select proc;
if (runningProcs.Count(p => p.ProcessName.Contains("nvda")) > 0)
{
if (Wait == true)
{
while(ProcessIsPlaying("nvda") == true)
{
Application.DoEvents();
}
}
else
{
nvdaController_cancelSpeech();
}
nvdaController_speakText(Text);
nvdaController_brailleMessage(Text);
}
else if (runningProcs.Count(p => p.ProcessName.Contains("jhookldr")) > 0)
{
Type jfwApi = Type.GetTypeFromProgID("FreedomSci.JawsApi");
object o = Activator.CreateInstance( jfwApi);
jfwApi.InvokeMember("SayString",
System.Reflection.BindingFlags.InvokeMethod,null,o,new Object[1] {Text});
}
else
{
Type Sapi = Type.GetTypeFromProgID("Sapi.SpVoice");
object o = Activator.CreateInstance( Sapi);
Sapi.InvokeMember("Speak",
System.Reflection.BindingFlags.InvokeMethod,null,o,new Object[2] {Text, 3});
}
}

}