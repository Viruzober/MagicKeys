local pos = position.module

function PreviousPreset()
	mouse.clickLeft(pos(70, 465))
	speak(screen.recognizeText(pos(60, 445, 300, 35), 4))
end

function NextPreset()
	mouse.clickLeft(pos(70, 450))
	speak(screen.recognizeText(pos(60, 445, 300, 35), 4))
end

function BankManager()
	mouse.clickLeft(pos(80, 450))
	window.waitUntilClosed("SysTreeView32")
end

function Options()
	mouse.clickLeft(pos(450, 480))
end
