def dividers(num):
    numDiv, numCount = 0, 0
    numDiv = num
    while numDiv > 0:
        numCount = num % numDiv
        if numCount == 0:
            print(numDiv)
        numDiv -= 1
    return 0
