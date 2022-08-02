function BanksMenu()
	MouseClick("left", 411, 69, 1, 0, 0, 10)
end

function PatchesMenu()
	MouseClick("left", 525, 75, 1, 0, 0, 10)
end

function PresetsMenu()
	MouseClick("left", 487, 106, 1, 0, 0, 10)
end

function PreviousPreset()
	MouseClick("left", 574, 70, 1, 0, 0, 10)
	Sleep(500)
	ImgToText(250, 50, 420, 80, 2)
end

function NextPreset()
	MouseClick("left", 596, 71, 1, 0, 0, 10)
	Sleep(500)
	ImgToText(250, 50, 420, 80, 2)
end
