from numba import jit
import random

@jit(nopython=True)
def monteCarloPi(nsamples):
    acc = 0
    for i in range(nsamples):
        x = random.random()
        y = random.random()
        if (x ** 2 + y ** 2) < 1.0:
            acc += 1
    return 4.0 * acc / nsamples

def main():
    print(monteCarloPi(1000000))

if __name__ == '__main__':
    main()