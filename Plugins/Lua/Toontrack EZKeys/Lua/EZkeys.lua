function BanksMenu()
	MouseClick("Left", 405, 17, 1, 0, 0, 10)
end

function PresetsMenu()
	MouseClick("Left", 605, 17, 1, 0, 0, 10)
end

-- Presets cache to attempting for define of presets bounces
local pnCache = ""
function PresetsSwitch(direction)
	local arrowsRow = 630
	local arrowsCol = {
		up = 21,
		down = 29
	}
	MouseClick("Left", arrowsRow, arrowsCol[direction], 1, 0, 0, 10)
	Sleep(300)
	-- Attempt to define the presets bounces
	local newPresetName = ImgToText(150, 20, 455, 11, 4)
	if newPresetName ~= pnCache then
		Speak(newPresetName)
		pnCache = newPresetName
	else
		MagicKeys.SoundPlay("End", false)
	end
end

function ReportBank()
	Speak(string.format("Bank menu. %s selected", ImgToText(150, 20, 300, 11, 4)))
end

function ReportPreset()
	local presetName = ImgToText(150, 20, 455, 11, 4)
	-- The following code line is identical of ReportBank function report code, that's just  Lua syntax sugar demonstration
	Speak(("Presets menu. %s selected"):format(presetName))
	pnCache = presetName
end

-- Loader
Sleep(100)
if MagicKeys.ImageSearch("Browse")[0] == 0 then
	VUILoader("Browse")
end
