using System;
using System.Drawing;
using System.IO;
namespace MagicKeys
{
public partial class DeveloperTool
{

public static void Save()
{
string ITB = MagicKeys.InputTextBox("Enter name", "Enter name for save");
if	(ITB == "0") return;
int[] MP = MagicKeys.GetMousePosition();
Bitmap Screen = new Bitmap(1, 1);
Graphics g = Graphics.FromImage(Screen);
g.CopyFromScreen(MP[0], MP[1], 00, 0, Screen.Size);
Color GetColor =  Screen.GetPixel(0, 0);
string StrColor = String.Format("#{0:X6}", GetColor.ToArgb() & 0x00FFFFFF);
string WR = "X "+(MP[0]-P[1]).ToString()+" Y "+(MP[1]-P[2]).ToString()+" "+StrColor+"\r\n";
if (OCRR != string.Empty) WR += OCRR+"\r\n";
using (StreamWriter sw = new StreamWriter(@".\DevSave\"+Module+@"\"+Module+".txt", true, System.Text.Encoding.Default))
{
sw.Write(WR);
}
}

}
}