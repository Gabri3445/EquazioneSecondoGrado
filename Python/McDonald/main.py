from variables import *
from mcdonald import *

createFile()
read()
while True:
    match inizio():
        case 1:
            comprare()
        case 2:
            match staff():
                case 1:
                    scorte()
                case 2:
                    chiudere()
