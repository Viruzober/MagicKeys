using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace MagicKeys
{
public partial class MagicKeys
{
[DllImport("user32.dll", SetLastError = true)]
public static extern uint SendInput(uint nInputs, ref INPUT[] pInputs, int cbSize);
public static void KeySend(string SendKeys, int Time)
{
string[] TempKey = SendKeys.Split("+");
INPUT[] KeyInputDown = new INPUT[2];
KeyInputDown[0] = new INPUT();
KeyInputDown[0].U.ki.dwFlags = KeyEventFlags.KeyDown;
KeyInputDown[0].U.ki.wVk = (int)Enum.Parse(typeof(Keys), TempKey[0]);
KeyInputDown[1] = new INPUT();
KeyInputDown[1].U.ki.dwFlags = KeyEventFlags.KeyDown;
KeyInputDown[1].U.ki.wVk = (int)Enum.Parse(typeof(Keys), TempKey[1]);
MessageBox.Show(SendInput(2, ref KeyInputDown, Marshal.SizeOf(new INPUT())).ToString(), "");
INPUT[] KeyInputUp = new INPUT[2];
KeyInputUp[0] = new INPUT();
KeyInputUp[0].U.ki.dwFlags = KeyEventFlags.KeyUp    ;
KeyInputUp[0].U.ki.wVk = (int)Enum.Parse(typeof(Keys), TempKey[1]);
KeyInputUp[1] = new INPUT();
KeyInputUp[1].U.ki.dwFlags = KeyEventFlags.KeyUp;
KeyInputUp[1].U.ki.wVk = (int)Enum.Parse(typeof(Keys), TempKey[0]);
SendInput(2, ref KeyInputUp, Marshal.SizeOf(new INPUT()));
}

}
}