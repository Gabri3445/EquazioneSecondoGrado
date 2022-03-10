from time import sleep
from dividers import dividers

num = 1

while True:
    print("Enter a number: ")
    num = int(input())
    dividers(num)
    if not num > 0:
        break

sleep(3)
