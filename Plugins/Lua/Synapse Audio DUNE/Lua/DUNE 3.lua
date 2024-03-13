-- Define which conversion we need
local pos = position.module -- relative

mouse.timeUp = 50

function BanksMenu()
	mouse.clickLeft(pos(479, 71))
end

function PatchesMenu()
	mouse.clickLeft(pos(645, 75))
end

function PresetsMenu()
	mouse.clickLeft(pos(455, 102))
end

local presetArea = pos(420, 82, 250, 50)
function PreviousPreset()
	screen.snapshot(presetArea)
	mouse.clickLeft(pos(705, 75))
	screen.waitUntilChanged(presetArea, 2, 2, 2)
	speak(screen.recognizeText(presetArea, 2))
end

function NextPreset()
	screen.snapshot(presetArea)
	mouse.clickLeft(pos(735, 75))
	screen.waitUntilChanged(presetArea, 2, 2, 2)
	speak(screen.recognizeText(presetArea, 2))
end
