-- Define which conversion we need
local pos = position.module -- relative

-- Static mouse properties initialization
mouse.timeUp = 10

function Line_in()
	mouse.clickLeft(pos(45, 130))
end

function Mic()
	mouse.clickLeft(pos(45, 155))
end

function HiZ()
	mouse.clickLeft(pos(45, 185))
end

function Mic_HiZ()
	mouse.clickLeft(pos(45, 215))
end

function MixCH_12_34()
	mouse.clickLeft(pos(45, 250))
end

function MixCH_12_56()
	mouse.clickLeft(pos(45, 285))
end

function Mon()
	mouse.clickLeft(pos(170, 90))
end

function Out()
	mouse.clickLeft(pos(200, 90))
end

function Volume1(direction)
	mouse.move(pos(110, 250))
	keyboard.sendKeys(direction, 10, 10)
end

function Volume2(direction)
	mouse.move(pos(215, 250))
	keyboard.sendKeys(direction, 10, 10)
end
