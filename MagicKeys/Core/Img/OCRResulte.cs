using System;
using System.Collections.Generic;

namespace MagicKeys
{
public class Rect
{
public int x { get; set; }
public int y { get; set; }
public int width { get; set; }
public int height { get; set; }
}

public class Word
{
public string text { get; set; }
public Rect rect { get; set; }
}

public class Line
{
public string text { get; set; }
public List<Word> words { get; set; }
}

public class OCRResult
{
public string text { get; set; }
public List<Line> lines { get; set; }
}

}