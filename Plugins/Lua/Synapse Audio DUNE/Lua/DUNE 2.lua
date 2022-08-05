function BanksMenu()
	MouseClick("Left", 411, 69, 1, 0, 0, 10)
end

function PatchesMenu()
	MouseClick("Left", 525, 75, 1, 0, 0, 10)
end

function PresetsMenu()
	MouseClick("Left", 487, 106, 1, 0, 0, 10)
end

function PreviousPreset()
	MouseClick("Left", 574, 70, 1, 0, 0, 10)
	Sleep(500)
	Speak(ImgToText(250, 50, 420, 80, 2))
end

function NextPreset()
	MouseClick("Left", 596, 71, 1, 0, 0, 10)
	Sleep(500)
	Speak(ImgToText(250, 50, 420, 80, 2))
end
