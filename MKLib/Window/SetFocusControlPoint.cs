﻿using System;

public static partial class MKLib
{

public static void SetFocusControlPoint(int X, int Y)
{
IntPtr Handle = GetWinPointHandle(X, Y);
uint IN = GetCurrentThreadId();
int Out = 0;
int TO = GetWindowThreadProcessId(Handle, out Out);
AttachThreadInput(IN, (uint)TO, true);
SetFocus(Handle);
AttachThreadInput(IN, (uint)TO, false);
}

}