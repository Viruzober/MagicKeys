function BanksMenu()
	MouseClick("Left", 411, 69, 1, 0, 0, 1)
end

function PatchesMenu()
	MouseClick("Left", 525, 75, 1, 0, 0, 1)
end

function PresetsMenu()
	MouseClick("Left", 487, 106, 1, 0, 0, 1)
end

function PreviousPreset()
	CreateBitmap(420, 80, 250, 50)
	MouseClick("Left", 574, 70, 1, 0, 0, 1)
	DisplayTraffic(420, 80, 250, 50, 5, 5, 2)
	Speak(ImgToText(250, 50, 420, 80, 2))
end

function NextPreset()
	CreateBitmap(420, 80, 250, 50)
	MouseClick("Left", 596, 71, 1, 0, 0, 10)
	DisplayTraffic(420, 80, 250, 50, 5, 5, 2)
	Speak(ImgToText(250, 50, 420, 80, 2))
end
