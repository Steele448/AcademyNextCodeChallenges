

-- Complete the checkMagazine function below.
    function checkMagazine(magazine, note)


    end
    
    local mn = {}
    for token in string.gmatch(io.stdin:read("*l"), "[^%s]+") do
        table.insert(mn, token)
    end
    
    local m = tonumber(mn[1]:match("^%s*(.-)%s*$"))
    
    local n = tonumber(mn[2]:match("^%s*(.-)%s*$"))
    
    local magazine = {}
    
    for token in string.gmatch(io.stdin:read("*l"), "[^%s]+") do
        table.insert(magazine, token)
    end
    
    local note = {}
    
    for token in string.gmatch(io.stdin:read("*l"), "[^%s]+") do
        table.insert(note, token)
    end
    
    checkMagazine(magazine, note)