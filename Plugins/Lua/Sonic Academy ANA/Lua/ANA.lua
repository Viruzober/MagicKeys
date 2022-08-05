function FactoryMenu()
	MouseClick("Left", 235, 45, 1, 0, 0, 10)
end

function BankMenu()
	MouseClick("Left", 415, 45, 1, 0, 0, 10)
end

function PatchMenu()
	MouseClick("Left", 620, 45, 1, 0, 0, 10)
end

function PreviousPreset()
	MouseClick("Left", 747, 43, 1, 0, 0, 10)
	Sleep(500)
	ImgToText(200, 40, 595, 30, 2)
end

function NextPreset()
	MouseClick("Left", 767, 42, 1, 0, 0, 10)
	Sleep(500)
	ImgToText(200, 40, 595, 30, 2)
end
