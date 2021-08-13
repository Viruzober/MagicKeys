function mouseClick(btn, x, y, count, TimeMove, TimeClick, TimeUp)
MK.mouseClick(btn, MK.P[2]+x, MK.P[3]+y, count, TimeMove, TimeClick, TimeUp)
end
function VUILoader(VUIName)
MK.VUILoader(VUIName)
end
function Speak(Text)( ... )
MK.Speak(Text)
end
function OCR(idth, Height, X, Y, Zoom, Lang = "en")
MK.ImgToText(Width, Height, MK.P[2]+X, MP.P[3]+Y, Zoom, Lang)
end
function SubPluginLoad()( ... )
MK.SubPluginLoad()
end
function SubPluginUnLoad()
MK.SubPluginUnLoad()( ... )
end