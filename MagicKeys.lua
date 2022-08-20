function ImgToText(W, H, X, Y, Zoom, Lang)
	return MKLib.ImgToText(W, H, MagicKeys.Coords.X + X, MagicKeys.Coords.Y + Y, Zoom, Lang or "en")
end

function MouseClick(Button, X, Y, Count, TimeMove, TimeClick, TimeUp)
	MKLib.MouseClick(Button, MagicKeys.Coords.X + X, MagicKeys.Coords.Y + Y, Count, TimeMove, TimeClick, TimeUp)
end

function MouseClickDrag(Button, X1, Y1, X2, Y2, TimeMove, TimeUp)
	MKLib.MouseClickDrag(Button, MagicKeys.Coords.X + X1, MagicKeys.Coords.Y + Y1, MagicKeys.Coords.X + X2, MagicKeys.Coords.Y + Y2, TimeMove, TimeUp)
end

function PixelSearch(X, Y, Color)
	return MKLib.PixelSearch(MagicKeys.Coords.X + X, MagicKeys.Coords.Y + Y, Color)
end

function Sleep(Time)
	MKLib.Sleep(Time)
end

function Speak(Text, Interrupt)
	MKLib.Speak(Text, interrupt or false)
end

function VUILoader(VUIName)
	MagicKeys.VUILoader(VUIName)
end

function SetFocusControlPoint(X, Y)
	MKLib.SetFocusControlPoint(MagicKeys.Coords.X + X, MagicKeys.Coords.Y + Y)
end

function KeySend(Type, Send, Time, PostTime)
	MKLib.KeySend(Type, Send, Time, PostTime)
end

function CreateBitmap(X, Y, W, H)
	MKLib.CreateBitmap(MagicKeys.Coords.X + X, MagicKeys.Coords.Y + Y, W, H)
end

function DisplayTraffic(X, Y, W, H, SkipPixelX, SkipPixelY, CountChangedPixel)
	MKLib.DisplayTraffic(MagicKeys.Coords.X + X, MagicKeys.Coords.Y + Y, W, H, SkipPixelX, SkipPixelY, CountChangedPixel)
end