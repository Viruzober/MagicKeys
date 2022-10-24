-- Define which conversion we need
local pos = position.module -- relative

function BanksMenu()
	mouse.clickLeft(pos(411, 69))
end

function PatchesMenu()
	mouse.clickLeft(pos(525, 75))
end

function PresetsMenu()
	mouse.clickLeft(pos(487, 106))
end

local presetArea = pos(420, 80, 250, 50)
function PreviousPreset()
	screen.snapshot(presetArea)
	mouse.clickLeft(pos(574, 70))
	screen.waitUntilChanged(presetArea, 5, 5, 2)
	speak(screen.recognizeText(presetArea, 2))
end

function NextPreset()
	screen.snapshot(presetArea)
	mouse.clickLeft(pos(596, 71))
	screen.waitUntilChanged(presetArea, 5, 5, 2)
	speak(screen.recognizeText(presetArea, 2))
end
