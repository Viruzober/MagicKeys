using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicKeys
{

public partial class DeveloperTool
{

public static List<String> LW = new List<string>();
public static List<int> LX = new List<int>();
public static List<int> LY = new List<int>();
public static void OCRWordPosition()
{
KeyUnReg();
OptionKeyUnReg();
Bitmap Screen = new Bitmap(P[3]-P[1], P[4]-P[2]);
Graphics g = Graphics.FromImage(Screen);
g.CopyFromScreen(P[1], P[2], 00, 0, Screen.Size);
var memoryStream = new MemoryStream();
Screen.Save(memoryStream, ImageFormat.Bmp);
byte[] b = memoryStream.ToArray();
string Resulte = Task.Run(() => MKLib.OCR(b, "en")).Result;
OCRResult JsonResulte = JsonSerializer.Deserialize<OCRResult>(Resulte);
OCRResultForm ORF = new		OCRResultForm();
foreach(var Line in JsonResulte.lines)
{
for(int I = 0; I <= Line.words.Count-1; I++)
{
LW.Add(Line.words[I].text);
LX.Add(Convert.ToInt32(Line.words[I].rect.x));
LY.Add(Convert.ToInt32(Line.words[I].rect.y));
}
}
foreach(var W in LW){
ORF.WList.Items.Add(W);
}
ORF.ShowDialog();
if(ORF.DialogResult == DialogResult.OK)
{
int SI = ORF.WList.SelectedIndex;
MKLib.MouseMove(P[1]+LX[SI], P[2]+LY[SI], 0);
}
LW.Clear();
LX.Clear();
LY.Clear();
OptionKeyReg();
KeyReg();
}

}
}