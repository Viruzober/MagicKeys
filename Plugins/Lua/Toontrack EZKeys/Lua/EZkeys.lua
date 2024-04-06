-- Select the coordinates conversion
local pos = position.module

-- Mouse static parameters initialization
mouse.timeUp = 10

-- Loader
sleep(100)
if not screen.searchImage("Browse") then
	vui.load("Browse")
end

function BanksMenu()
	mouse.clickLeft(pos(405, 17))
end

function PresetsMenu()
	mouse.clickLeft(pos(605, 17))
end

-- Presets cache to attempting for define of presets bounces
local pnCache = ""
function PresetsSwitch(direction)
	local arrowsRow = 630
	local arrowsCol = {
		up = 21,
		down = 29
	}
	local presetArea = pos(455, 11, 150, 20)
	mouse.clickLeft(pos(arrowsRow, arrowsCol[direction]))
	-- Attempt to define the presets bounces
	for _ = 1, 5 do
		sleep(100)
		local newPresetName = screen.recognizeText(presetArea, 4)
		if newPresetName ~= pnCache then
			speak(newPresetName)
			pnCache = newPresetName
			return
		end
	end
	sound.play("End")
end

function ReportBank()
	speak(string.format("%s selected", screen.recognizeText(pos(300, 11, 150, 20), 4)), true)
end

function ReportPreset()
	local presetName = screen.recognizeText(pos(455, 11, 150, 20), 4)
	-- The following code line is identical of ReportBank function report code, that's just  Lua syntax sugar demonstration
	speak(("%s selected"):format(presetName), true)
	pnCache = presetName
end
