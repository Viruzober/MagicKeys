using System;
using System.Drawing;
using System.IO;
using static MKLib;

namespace DeveloperTool
{

public partial class DeveloperTool
{

public static void Save()
{
string Name = InputTextBox(T._("Save"), T._("Enter name for save."));
if(Name == null)
{
return;
}

int[] MP = MKLib.GetMousePosition();
Bitmap Screen = new Bitmap(1, 1);
Graphics g = Graphics.FromImage(Screen);
g.CopyFromScreen(MP[0], MP[1], 00, 0, Screen.Size);
Color GetColor =  Screen.GetPixel(0, 0);
string StrColor = String.Format("#{0:X6}", GetColor.ToArgb() & 0x00FFFFFF);
string WR = "Name: "+Name+"\r\nX: "+(MP[0]-Coords.X).ToString()+"\r\nY: "+(MP[1]-Coords.Y).ToString()+"\r\nColor: "+StrColor+"\r\n";
WR += "\r\n";
using (StreamWriter sw = new StreamWriter(@".\DevSave\"+ModuleName+@"\"+ModuleName+".txt", true, System.Text.Encoding.Default))
{
sw.Write(WR);
}
}

}
}