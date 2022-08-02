function CategoryMenu()
	MouseClick("Left", 400, 30, 1, 0, 0, 10)
end

function KicksMenu()
	MouseClick("Left", 630, 30, 1, 0, 0, 10)
end

function PreviousCategory()
	MouseClick("Left", 425, 30, 1, 0, 0, 10)
	Sleep(500)
	ImgToText(100, 50, 310, 20, 1)
end

function NextCategory()
	MouseClick("Left", 445, 30, 1, 0, 0, 10)
	Sleep(500)
	ImgToText(100, 50, 310, 20, 1)
end

function PreviousKick()
	MouseClick("Left", 710, 30, 1, 1, 0, 10)
	Sleep(500)
	ImgToText(250, 60, 455, 20, 1)
end

function NextKick()
	MouseClick("Left", 730, 30, 1, 1, 0, 10)
	Sleep(500)
	ImgToText(250, 60, 450, 20, 1)
end

function SaveKick()
	MouseClick("Left", 660, 50, 1, 0, 0, 10)
end
