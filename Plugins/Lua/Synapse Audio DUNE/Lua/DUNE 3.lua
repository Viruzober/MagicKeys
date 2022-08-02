function BanksMenu()
	MouseClick("Left", 479, 71, 1, 0, 0, 10)
end

function PatchesMenu()
	MouseClick("Left", 645, 75, 1, 0, 0, 10)
end

function PresetsMenu()
	MouseClick("Left", 455, 102, 1, 0, 0, 10)
end

function PreviousPreset()
	MouseClick("Left", 705, 75, 1, 0, 0, 10)
	Sleep(500)
	Speak(ImgToText(250, 50, 420, 80, 2))
end

function NextPreset()
	MouseClick("Left", 735, 75, 1, 0, 0, 10)
	Sleep(500)
	Speak(ImgToText(250, 50, 420, 80, 2))
end
