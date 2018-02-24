import json
with open('high_elf.txt', 'r', encoding="utf-8") as ifile:
    data = [line.rstrip('\n') for line in ifile.readlines()]
    print(json.dumps(data))
    
    
