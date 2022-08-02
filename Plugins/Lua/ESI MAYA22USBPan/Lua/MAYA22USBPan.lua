function Line_in()
	MouseClick("Left", 45, 130, 1, 0, 0, 10)
end

function Mic()
	MouseClick("Left", 45, 155, 1, 0, 0, 10)
end

function HiZ()
	MouseClick("Left", 45, 185, 1, 0, 0, 10)
end

function Mic_HiZ()
	MouseClick("Left", 45, 215, 1, 0, 0, 10)
end

function MixCH_12_34()
	MouseClick("Left", 45, 250, 1, 0, 0, 10)
end

function MixCH_12_56()
	MouseClick("Left", 45, 285, 1, 0, 0, 10)
end

function Mon()
	MouseClick("Left", 170, 90, 1, 0, 0, 10)
end

function Out()
	MouseClick("Left", 200, 90, 1, 0, 0, 10)
end

function Volume1(direction)
	MouseMove(110, 250, 0)
	KeySend("Keys", direction, 10, 10)
end

function Volume2(direction)
	MouseMove(215, 250, 0)
	KeySend("Keys", direction, 10, 10)
end
