local pos = position.module

mouse.timeUp = 20

function LoadPreset()
mouse.clickLeft(pos(455, 40))
mouse.clickLeft(pos(480, 60))
end

function PreviousPreset()
mouse.clickLeft(pos(703, 19))
end

function NextPreset()
mouse.clickLeft(pos(723, 19))
end
