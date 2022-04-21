from random import random
import matplotlib.pyplot as plt
import random

def collatz(n):
    if n % 2 == 0:
        return n / 2
    else:
        return 3 * n + 1

def main():
    print("This program plots the Collatz sequence for a given number.")
    if input("0 for random, 1 for user input: ") == "0":
        n = random.randint(0, 1000000)
    else:
        n = int(input("Enter a number: "))
    steps = [n]
    while n != 1:
        n = collatz(n)
        steps.append(n)
    plt.plot(steps)
    plt.show()


if __name__ =='__main__':
    main()