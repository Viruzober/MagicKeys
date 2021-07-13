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
string inputString = "a";
IntPtr ExtraInfo = IntPtr.Zero;
    if (string.IsNullOrEmpty(inputString))
    { return; }

    char[] chars = inputString.ToCharArray();
    int len = chars.Length;
    INPUT[] pInputs = new INPUT[len * 2];

    int i = 0, idx = 0;
    while (i < len)
    {
        UInt16 ch = chars[i++];

        if ((ch < 0xD800) || (ch > 0xDFFF))
        {
            pInputs[idx] = new INPUT();
            pInputs[idx].type = InputType.Keyboard;
            pInputs[idx].U.ki.wVk = 0;
            pInputs[idx].U.ki.wScan = ch;
            pInputs[idx].U.ki.dwFlags = KeyEventFlags.Unicode;
            pInputs[idx].U.ki.time = 0;
            pInputs[idx].U.ki.dwExtraInfo = ExtraInfo;
            ++idx;

            pInputs[idx] = new INPUT();
            pInputs[idx].type = InputType.Keyboard;
            pInputs[idx].U.ki.wVk = 0;
            pInputs[idx].U.ki.wScan = ch;
            pInputs[idx].U.ki.dwFlags = KeyEventFlags.Unicode|KeyEventFlags.KeyUp;
            pInputs[idx].U.ki.time = 0;
            pInputs[idx].U.ki.dwExtraInfo = ExtraInfo;
            ++idx;
        }
        else
        {
            UInt16 ch2 = chars[i++];

            pInputs[idx] = new INPUT();
            pInputs[idx].type = InputType.Keyboard;
            pInputs[idx].U.ki.wVk = 0;
            pInputs[idx].U.ki.wScan = ch;
            pInputs[idx].U.ki.dwFlags = KeyEventFlags.Unicode;
            pInputs[idx].U.ki.time = 0;
            pInputs[idx].U.ki.dwExtraInfo = ExtraInfo;
            ++idx;

            pInputs[idx] = new INPUT();
            pInputs[idx].type = InputType.Keyboard;
            pInputs[idx].U.ki.wVk = 0;
            pInputs[idx].U.ki.wScan = ch2;
            pInputs[idx].U.ki.dwFlags = KeyEventFlags.Unicode;
            pInputs[idx].U.ki.time = 0;
            pInputs[idx].U.ki.dwExtraInfo = ExtraInfo;
            ++idx;

            pInputs[idx] = new INPUT();
            pInputs[idx].type = InputType.Keyboard;
            pInputs[idx].U.ki.wVk = 0;
            pInputs[idx].U.ki.wScan = ch;
            pInputs[idx].U.ki.dwFlags = KeyEventFlags.Unicode|KeyEventFlags.KeyUp;
            pInputs[idx].U.ki.time = 0;
            pInputs[idx].U.ki.dwExtraInfo = ExtraInfo;
            ++idx;

            pInputs[idx] = new INPUT();
            pInputs[idx].type = InputType.Keyboard;
            pInputs[idx].U.ki.wVk = 0;
            pInputs[idx].U.ki.wScan = ch2;
            pInputs[idx].U.ki.dwFlags = KeyEventFlags.Unicode|KeyEventFlags.KeyUp;
            pInputs[idx].U.ki.time = 0;
            pInputs[idx].U.ki.dwExtraInfo = ExtraInfo;
            ++idx;
        }
    }

    uint nSent = SendInput((uint)pInputs.Length, pInputs, Marshal.SizeOf(typeof(INPUT)));
    }

}
}