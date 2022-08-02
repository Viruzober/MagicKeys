function PreviousPreset()
MouseClick("left", 70, 465, 1, 0, 0, 10)
ImgToText(300, 35, 60, 445, 4)
end

function NextPreset()
MouseClick("left", 70, 450, 1, 0, 0, 10)
ImgToText(300, 35, 60, 445, 4)
end

function BankManager()
MouseClick("left", 80, 450, 1, 0, 0, 10)
WaitWinClose(SysTreeView32)
end

function Options()
MouseClick("left", 450, 480, 1, 0, 0, 10)
end
