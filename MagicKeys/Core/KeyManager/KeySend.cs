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
if (string.IsNullOrEmpty(Send)) return;
char[] Chars = Send.ToCharArray();
INPUT[] KeyInputs = new INPUT[1];
for(int I = 0; I < Chars.Length; I++)
{
UInt16 Ch = Chars[I];
if ((Ch < 0xD800) || (Ch > 0xDFFF))
{
KeyInputs = new INPUT[2];
KeyInputs[0].type = InputType.Keyboard;
KeyInputs[0].U.ki.wVk = 0;
KeyInputs[0].U.ki.wScan = (UInt16)Chars[I];
KeyInputs[0].U.ki.dwFlags = KeyEventFlags.Unicode|KeyEventFlags.KeyDown;
KeyInputs[1].type = InputType.Keyboard;
KeyInputs[1].U.ki.wVk = 0;
KeyInputs[1].U.ki.wScan = (UInt16)Chars[I];
KeyInputs[1].U.ki.dwFlags = KeyEventFlags.Unicode|KeyEventFlags.KeyUp;
}
else
{
KeyInputs = new INPUT[4];
KeyInputs[0].type = InputType.Keyboard;
KeyInputs[0].U.ki.wVk = 0;
KeyInputs[0].U.ki.wScan = (UInt16)Chars[I];
KeyInputs[0].U.ki.dwFlags = KeyEventFlags.Unicode|KeyEventFlags.KeyDown;
KeyInputs[0].U.ki.time = 0;
KeyInputs[1].type = InputType.Keyboard;
KeyInputs[1].U.ki.wVk = 0;
KeyInputs[1].U.ki.wScan = (UInt16)Chars[I+1];
KeyInputs[1].U.ki.dwFlags = KeyEventFlags.Unicode|KeyEventFlags.KeyDown;
KeyInputs[1].U.ki.time = 0;
KeyInputs[2].type = InputType.Keyboard;
KeyInputs[2].U.ki.wVk = 0;
KeyInputs[2].U.ki.wScan = (UInt16)Chars[I];
KeyInputs[2].U.ki.dwFlags = KeyEventFlags.Unicode|KeyEventFlags.KeyUp;
KeyInputs[2].U.ki.time = 0;
KeyInputs[3].type = InputType.Keyboard;
KeyInputs[3].U.ki.wVk = 0;
KeyInputs[3].U.ki.wScan = (UInt16)Chars[I+1];
KeyInputs[3].U.ki.dwFlags = KeyEventFlags.Unicode|KeyEventFlags.KeyUp;
KeyInputs[3].U.ki.time = 0;
I += 1;
}
SendInput((uint)KeyInputs.Length, KeyInputs, Marshal.SizeOf(typeof(INPUT)));
}
    
    }

}
}