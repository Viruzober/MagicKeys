using System;
using System.Collections.Generic;

public class Rect
{
public int X { get; set; }
public int Y { get; set; }
public int Width { get; set; }
public int Height { get; set; }
}

public class Word
{
public string Text { get; set; }
public Rect BoundingRect { get; set; }
}

public class Line
{
public string Text { get; set; }
public List<Word> Words { get; set; }
}

    public class OCRResult
{
public string Text { get; set; }
public Nullable<double> TextAngle { get; set; }
public List<Line> Lines { get; set; }
}