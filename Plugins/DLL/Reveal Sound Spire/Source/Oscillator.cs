﻿using System;
using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class RevealSoundSpire
{

public static void Oscillator1()
{
MouseClick("Left", P[1]+145, P[2]+60, 1, 0, 0, 10);
Speak("Oscillator 1 select");
}

public static void Oscillator2()
{
MouseClick("Left", P[1]+180, P[2]+60, 1, 0, 0, 10);
Speak("Oscillator 2 select");
}

public static void Oscillator3()
{
MouseClick("Left", P[1]+215, P[2]+60, 1, 0, 0, 10);
Speak("Oscillator 3 select");
}

public static void Oscillator4()
{
MouseClick("Left", P[1]+250, P[2]+60, 1, 0, 0, 10);
Speak("Oscillator 4 select");
}
public static bool Copy = false;
public static void CopyOscillator()
{
MouseClick("Left", P[1]+290, P[2]+60, 1, 0, 0, 10);
Speak("Oscillator copied");
Copy = true;
}

public static void PasteOscillator()
{
if (Copy == false)
{
Speak("Oscillator not copied");
return;
}
MouseClick("Left", P[1]+335, P[2]+60, 1, 0, 0, 10);
Speak("Oscillator pasted");
}

}
}