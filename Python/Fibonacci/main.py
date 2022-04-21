from numba import jit

@jit(nopython=True)
def fibonacci(n):
    fib = [0, 1]
    for i in range(2, n+1):
        fib.append(fib[i-1] + fib[i-2])
    return fib

def main():
    n = int(input("Enter a number: "))
    print(fibonacci(n))

if __name__ =='__main__':
    main()