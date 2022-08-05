function BanksMenu()
	MouseClick("Left", 479, 71, 1, 0, 0, 10)
end

function PatchesMenu()
	MouseClick("left", 645, 75, 1, 0, 0, 10)
end

function PresetsMenu()
	MouseClick("left", 455, 102, 1, 0, 0, 10)
end

function PreviousPreset()
	MouseClick("left", 705, 75, 1, 0, 0, 10)
	Sleep(500)
	ImgToText(250, 50, 420, 80, 2)
end

function NextPreset()
	MouseClick("left", 735, 75, 1, 0, 0, 10)
	Sleep(500)
	ImgToText(250, 50, 420, 80, 2)
end
