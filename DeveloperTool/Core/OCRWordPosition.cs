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
Bitmap s = MKLib.ResizeImage(Screen, OCRZoom); 
s.Save(memoryStream, ImageFormat.Bmp);
byte[] b = memoryStream.ToArray();
string Resulte = Task.Run(() => MKLib.OCR(b, "en")).Result;
OCRResult JsonResulte = JsonSerializer.Deserialize<OCRResult>(Resulte);
OCRResultForm ORF = new		OCRResultForm();
foreach(var Line in JsonResulte.Lines)
{
for(int I = 0; I <= Line.Words.Count-1; I++)
{
LW.Add(Line.Words[I].Text);
LX.Add(Convert.ToInt32(Line.Words[I].BoundingRect.X));
LY.Add(Convert.ToInt32(Line.Words[I].BoundingRect.Y));
}
}
foreach(var W in LW){
ORF.WList.Items.Add(W);
}
ORF.ShowDialog();
if(ORF.DialogResult == DialogResult.OK)
{
int SI = ORF.WList.SelectedIndex;
MKLib.MouseMove(P[1]+(LX[SI] / OCRZoom), P[2]+(LY[SI] / OCRZoom), 0);
}
LW.Clear();
LX.Clear();
LY.Clear();
OptionKeyReg();
KeyReg();
}

}
}