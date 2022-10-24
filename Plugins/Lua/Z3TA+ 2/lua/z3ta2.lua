-- Выбираем преобразование координат
local pos = position.module
-- Нужен кеш для проверки при сборке сообщения о пресете
sayCache = {}

function sayContent(shouldReturn)
	local name = screen.recognizeText(pos(522, 5, 100, 50), 3)
	if name then
		if type(shouldReturn) == "boolean" and shouldReturn  then
			return name
		else
			speak(name)
			sayCache.content = name
		end
	else
		speak("Content is not recognized.")
	end
end

function sayBank(shouldReturn)
	local name = screen.recognizeText(pos(587, 5, 100, 50), 5)
	if name then
		if type(shouldReturn) == "boolean" and shouldReturn  then
			return name
		else
			speak(name)
			sayCache.bank = name
		end
	else
		speak("Content is not recognized.")
	end
end

function sayPreset(shouldReturn)
local name = screen.recognizeText(pos(647, 5, 200, 50), 3)
	if name then
		if type(shouldReturn) == "boolean" and shouldReturn  then
			return name
		else
			speak(name)
			sayCache.preset = name
		end
	else
		speak("Content is not recognized.")
	end
end

function chooseContent()
	mouse.clickLeft(pos(525, 29))
end

function chooseBank()
	mouse.clickLeft(pos(658, 28))
end

function choosePreset()
	mouse.clickLeft(pos(723, 29))
end

function callMenu(key)
	local menus = {
		content={x=525, y=29},
		banks={x=658, y=28},
		presets={x=723, y=29}
	}
	-- Выше мы фактически сформировали объекты координат, так что мы можем просто  передать в щелчок объект, индексирующийся по ключу раздела
	mouse.clickLeft(menus[key])
end

function arrows(direction)
	local xPos = ({["back"]=835,["next"]=815})[direction]
	if xPos then
	screen.snapshot(pos(647, 5, 200, 50))
		mouse.clickLeft(pos(xPos, 29))
		screen.waitUntilChanged(pos(647, 5, 200, 50), 5, 5, 2)
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
		speak(message)
	else
		error("Unknown direction", direction)
	end
end
