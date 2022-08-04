function BanksMenu()
	MouseClick("Left", 405, 17, 1, 0, 0, 10)
end

function PresetsMenu()
	MouseClick("Left", 605, 17, 1, 0, 0, 10)
end

function PresetsSwitch(direction)
	local arrowsRow = 630
	local arrowsCol = {
		up = 21,
		down = 29
	}
	MouseClick("Left", arrowsRow, arrowsCol[direction], 1, 0, 0, 10)
	Sleep(200)
	Speak(ImgToText(150, 20, 455, 11, 4))
end

-- Loader
Sleep(100)
if MagicKeys.ImageSearch("Browse")[0] == 0 then
	VUILoader("Browse")
end
