local pos = position.module

function CategoryMenu()
	mouse.clickLeft(pos(400, 30))
end

function KicksMenu()
	mouse.clickLeft(pos(630, 30))
end

local categoriesArea, kicksArea = pos(100, 50, 310, 20), pos(250, 60, 455, 20)

function PreviousCategory()
	mouse.clickLeft(pos(425, 30))
	sleep(500)
	speak(screen.recognizeText(categoriesArea, 1))
end

function NextCategory()
	mouse.clickLeft(pos(445, 30))
	sleep(500)
	speak(screen.recognizeText(categoriesArea, 1))
end

function PreviousKick()
	mouse.clickLeft(pos(710, 30))
	sleep(500)
	speak(screen.recognizeText(kicksArea, 1))
end

function NextKick()
	mouse.clickLeft(pos(730, 30))
	sleep(500)
	speak(screen.recognizeText(kicksArea, 1))
end

function SaveKick()
	mouse.clickLeft(pos(660, 50))
end
