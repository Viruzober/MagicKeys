using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace MagicKeys
{
public partial class MagicKeys
{
[DllImport("user32.dll", SetLastError = true)]
public static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);
public static void KeySend(string SendKeys, int Time)
{
string[] TempKey = SendKeys.Split("+");
//(int)Enum.Parse(typeof(Keys), TempKey[0]);
INPUT[] KeyInput = new INPUT[1];
KeyInput[0].type = InputType.Keyboard;
KeyInput[0].U.ki.wVk = 17;
KeyInput[0].U.ki.dwFlags = KeyEventFlags.KeyDown;
SendInput((uint)KeyInput.Length, KeyInput, Marshal.SizeOf(new INPUT()));
}

}
}