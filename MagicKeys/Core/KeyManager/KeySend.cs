using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Text.Unicode;
using System.Text;

namespace MagicKeys
{
public partial class MagicKeys
{
[DllImport("user32.dll", SetLastError = true)]
public static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);
public static void KeySend(string Type, string Send, int Time)
{
//(int)Enum.Parse(typeof(Keys), "Escape")
UInt16 U = "п"[0];
INPUT[] KeyInput = new INPUT[2];
KeyInput[0].type = InputType.Keyboard;
KeyInput[0].U.ki.wVk = 0;
KeyInput[0].U.ki.wScan = (ushort)1122;
KeyInput[0].U.ki.dwFlags = KeyEventFlags.Unicode|KeyEventFlags.KeyDown;
KeyInput[1].type = InputType.Keyboard;
KeyInput[1].U.ki.wVk = 0;
KeyInput[1].U.ki.wScan = (ushort)1122;
KeyInput[1].U.ki.dwFlags = KeyEventFlags.Unicode|KeyEventFlags.KeyUp;
SendInput(2, KeyInput, Marshal.SizeOf(new INPUT()));
}

}
}