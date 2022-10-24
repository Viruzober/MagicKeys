--[[
MagicKeys and MKLib Lua wrapper
The wrapper implements all methods and objects obey the Lua codestyle.
]]--

-- coordinates and size conversion
-- All methods which wait x, y, w or h need converted
position = {}

-- getting the relative coordinates
position.module = setmetatable({}, {
	-- The table indexing must be referenced to MagicKeys coordinates object
	__index = MagicKeys.Coords,
	-- When the object called as function it mus convert passed values to expected table
	__call = function (self, x, y, w, h)
		local obj = {}
		-- assign the default values
		x = x or 0 y = y or 0
		obj.x = MagicKeys.Coords.X + x
		obj.y = MagicKeys.Coords.Y + y
		obj.w = w
		obj.h = h
		return obj
	end
})

-- Getting an absolute coordinates
-- Basically, it is just plug for easy substitution
position.screen = setmetatable({}, {
	__index = function ()
		return 0
	end,
	__call = function (self, x, y, w, h)
		local obj = {}
		obj.x = x or 0
		obj.y = y or 0
		obj.w = w
		obj.h = h
		return obj
	end
})


-- Clipboard manipulations
clipboard = {}

function clipboard.getText()
	return MKLib.GetText()
end

-- Show debug form
---@Param debugInfo (string)
function debugForm(debugInfo)
	MKLib.CallDebugForm(debugInfo)
end

-- User input implementations
inputBox ={}

-- Allows to get the numeric value using spinbox
---@param title (string): the window title
---@param caption (string): the instruction for typing
---@param min (number): the minimal spinbox value
---@param max (number): the maximal spinbox value
---@return 1 (boolean): true when OK button is presset, false otherwise
---@return 2 (number): specified numeric value
function inputBox.spinner(title, caption, min, max)
	local retval =  MKLib.InputBox(title, caption, min, max)
	return retval ~= nil, tonumber(retval or 0)
end

function inputBox.string(title, caption, multiline)
	local retval = MKLib.InputTextBox(title, caption, multiline or false)
	return retval ~= nil, tostring(retval or "")
end

keyboard = {}

-- Implement the send type proxy
setmetatable(keyboard, {
	__index = function (self, key)
		if key:match("^send") then
			local type = key:match("^send(.+)")
			return function (keys, time, postTime)
				time = time or self.time or 50
				postTime = postTime or self.postTime or 100
				MKLib.KeySend(type, keys, time, postTime)
			end
		end
	end
})

screen = {}

function screen.recognizeText(position, Zoom, Lang)
	return MKLib.ImgToText(position.w, position.h, position.x, position.y, Zoom, Lang or "en")
end

function screen.isPixelColor(coords, Color)
	return MKLib.PixelSearch(coords.x, coords.y, Color)
end

function screen.searchImage(imgPath, window)
	return MagicKeys.ImageSearch(imgPath, window)
end

function screen.searchImageAt(imgPath, position, variant)
	return MagicKeys.ImageSearchArea(imgPath, position.x, position.y, position.w, position.h, variant)
end

function screen.snapshot(position)
	MKLib.CreateBitmap(position.x, position.y, position.w, position.h)
end

function screen.waitUntilChanged(position, SkipPixelX, SkipPixelY, CountChangedPixel)
	MKLib.DisplayTraffic(position.x, position.y, position.w, position.h, SkipPixelX, SkipPixelY, CountChangedPixel)
end

mouse = {}

function mouse.move(coords, timeMove)
	MKLib.MouseMove(coords.x, coords.y, timeMove or mouse.timeMove or 0)
end

setmetatable(mouse, {
	__index = function (self, key)
		if key:match("^click") then
			local button = key:match("^click(.+)")
			return function (coords, Count, TimeMove, TimeClick, TimeUp)
				--Default definitions
				Count = Count or 1
				-- The following properties might initialized in the mouse for all module work time
				TimeMove = TimeMove or self.timeMove or 0
				TimeClick = TimeClick or self.timeClick or 0
				TimeUp = TimeUp or self.timeUp or 1
				-- Getting decide where we need to click
				local x, y = coords.x, coords.y
				if coords.w and coords.h then
					x = math.modf((x + coords.w) * 0.33)
					y = math.modf((y + coords.h) * 0.33)
				end
				MKLib.MouseClick(button, x, y, Count, TimeMove, TimeClick, TimeUp)
			end
		elseif key:match("^drag") then
			local button = key:match("^drag(.+)")
			return function (coordsFrom, coordsTo, TimeMove, TimeUp)
				--Default definitions
				-- The following properties might initialized in the mouse for all module work time
				TimeMove = TimeMove or self.timeMove or 0
				TimeUp = TimeUp or self.timeUp or 1
				MKLib.MouseClickDrag(button, coordsFrom.x, coordsFrom.y, coordsTo.x, coordsTo.y, TimeMove, TimeUp)
			end
		end
	end
})

menu = {}

function menu.countItems()
	return MKLib.GetMICount()
end

function menu.getItemHandle()
	return MKLib.GetMIHandle()
end

sound = {}

function sound.play(soundFile, waitUntilPlayed)
	MagicKeys.SoundPlay(soundFile, waitUntilPlayed or false)
end

-- VUI interraction
vui = {}

function vui.load(VUIName)
	MagicKeys.VUILoader(VUIName)
end

function vui.nextObject()
	MagicKeys.VUIObjectNavigator("Next")
end

function vui.previousObject()
	MagicKeys.VUIObjectNavigator("Back")
end

function vui.speakCurrentObject()
	MagicKeys.VUIObjectSpeak()
end

function vui.updateObjects(resetPosition)
	MagicKeys .VUIObjectsUpdate(resetPosition)
end

-- Get visible VVUI objects array
function vui.getVisibleObjects()
	local constructor = {}
	-- C# contains the array index from 0
	for i = 0, #MagicKeys.VisibleVUIObjects-1 do
		local vuiObj = MagicKeys.VisibleVUIObjects[i]
		local fixedvuiObj = {}
		for key, value in pairs(vuiObj) do
			fixedvuiObj[string.gsub(key, "^%u", string.lower)] = value
		end
		table.insert(constructor, fixedvuiObj)
	end
	return constructor
end

-- Plugin namespace
plugin = {}

function plugin.getPaths()
	return {
		plugin = MagicKeys.API.GetPluginPath(),
		vui = MagicKeys.API.GetVUIPath(),
		lua = MagicKeys.API.GetLUAPath(),
		images = MagicKeys.API.GetImgPath()
	}
end



-- Window and controls identification and interraction
window = {}

function window.setFocusByCoordinates(coords)
	MKLib.SetFocusControlPoint(coords.x, coords.y)
end

function sleep(Time)
	MKLib.Sleep(Time)
end

function speak(Text, waitUntilSpeak)
	MKLib.Speak(Text, waitUntilSpeak or false)
end
