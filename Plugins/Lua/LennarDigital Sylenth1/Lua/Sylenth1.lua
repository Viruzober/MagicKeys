local pos = position.module

function LoadBank()
	keyboard.sendKeys("LShiftKey+O")
end

function LoadPreset()
	keyboard.sendKeys("LShiftKey+L")
end

function SavePreset()
	keyboard.sendKeys("LShiftKey+P")
end

function PreviousPreset()
	mouse.clickLeft(pos(1195, 330))
	speak(screen.recognizeText(pos(150, 60, 940, 320), 4))
end

function NextPreset()
	mouse.clickLeft(pos(1225, 330))
	speak(screen.recognizeText(pos(150, 60, 940, 320), 4))
end
