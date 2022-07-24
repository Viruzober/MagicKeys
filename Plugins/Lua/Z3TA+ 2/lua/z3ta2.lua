-- Язык интерфейса
lang = "en"
-- Нужен кеш для проверки при сборке сообщения о пресете
sayCache = {}

function sayContent(shouldReturn)
	local name = ImgToText(100, 50, 522, 5, 3, lang)
	if name then
		if type(shouldReturn) == "boolean" and shouldReturn  then
			return name
		else
			MKLib.Speak(name, true)
			sayCache.content = name
		end
	else
		MKLib.Speak("Content is not recognized.", true)
	end
end

function sayBank(shouldReturn)
	local name = ImgToText(100, 50, 587, 5, 5, lang)
	if name then
		if type(shouldReturn) == "boolean" and shouldReturn  then
			return name
		else
			MKLib.Speak(name, true)
			sayCache.bank = name
		end
	else
		MKLib.Speak("Content is not recognized.", true)
	end
end

function sayPreset(shouldReturn)
local name = ImgToText(200, 50, 647, 5, 3, lang)
	if name then
		if type(shouldReturn) == "boolean" and shouldReturn  then
			return name
		else
			MKLib.Speak(name, true)
			sayCache.preset = name
		end
	else
		MKLib.Speak("Content is not recognized.", true)
	end
end

local function leftClick(x, y)
	MouseClick("Left", x, y, 1, 0, 0, 1)
end

function chooseContent()
	leftClick(525, 29)
end

function chooseBank()
	leftClick(658, 28)
end

function choosePreset()
	leftClick(723, 29)
end

function callMenu(key)
	local menus = {
		content={x=525, y=29},
		banks={x=658, y=28},
		presets={x=723, y=29}
	}
	leftClick(menus[key].x, menus[key].y)
end

function arrows(direction)
	local xPos = ({["back"]=835,["next"]=815})[direction]
	if xPos then
		leftClick(xPos, 29)
		MKLib.Sleep(100)
		local message = ""
		local contentString = sayContent(true)
		if sayCache.content ~= contentString then
			message = message..string.format("Content %s, ", contentString)
		end
		sayCache.content = contentString
		local bankString = sayBank(true)
		if sayCache.bank ~= bankString then
			message = message..string.format("Bank %s, ", bankString)
		end
		sayCache.bank = bankString
		sayCache.preset = sayPreset(true)
		message = message..string.format("Preset %s", sayCache.preset)
		MKLib.Speak(message, true)
	else
		error("Unknown direction", direction)
	end
end
