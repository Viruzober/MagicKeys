function BanksMenu()
	MouseClick("Left", 479, 71, 1, 0, 0, 1)
end

function PatchesMenu()
	MouseClick("Left", 645, 75, 1, 0, 0, 1)
end

function PresetsMenu()
	MouseClick("Left", 455, 102, 1, 0, 0, 1)
end

function PreviousPreset()
	CreateBitmap(420, 82, 250, 50)
	MouseClick("Left", 705, 75, 1, 0, 0, 1)
	DisplayTraffic(420, 82, 250, 50, 5, 5, 2)
	Speak(ImgToText(250, 50, 420, 80, 2))
end

function NextPreset()
	CreateBitmap(420, 82, 250, 50)
	MouseClick("Left", 735, 75, 1, 0, 0, 1)
	DisplayTraffic(420, 82, 250, 50, 5, 5, 2)
	Speak(ImgToText(250, 50, 420, 80, 2))
end
