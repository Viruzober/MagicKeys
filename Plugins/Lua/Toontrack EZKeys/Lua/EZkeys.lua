function BanksMenu()
	MouseClick("Left", 405, 17, 1, 0, 0, 10)
end

function PresetsMenu()
	MouseClick("Left", 605, 17, 1, 0, 0, 10)
end

-- Loader
Sleep(100)
if MagicKeys.ImageSearch("Browse")[0] == 0 then
	VUILoader("Browse")
end
