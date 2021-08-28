using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MKLib;
namespace DeveloperTool
{

public partial class DeveloperTool
{

public static List<String> LW = new List<string>();
public static List<int> LX = new List<int>();
public static List<int> LY = new List<int>();
public static void OCRWordPosition()
{
OCRResult Resulte = GetOCRResult(Coords.W-Coords.X, Coords.H-Coords.Y, Coords.X, Coords.Y, OCRZoom);
OCRResultForm ORF = new		OCRResultForm();
foreach(var Line in Resulte.Lines)
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
KeyUnReg();
ORF.ShowDialog();
KeyReg();
if(ORF.DialogResult == DialogResult.OK)
{
int SI = ORF.WList.SelectedIndices[0];
MKLib.MouseMove(Coords.X+(LX[SI] / OCRZoom), Coords.Y+(LY[SI] / OCRZoom), 0);
}
LW.Clear();
LX.Clear();
LY.Clear();
}

}
}