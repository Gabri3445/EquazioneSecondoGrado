using Backend;

int num = int.Parse(Console.ReadLine());

foreach (var item in Fibonacci.FibonacciSequence(num))
{
    Console.WriteLine(item);
}