namespace Backend
{
    class Fibonacci
    {
        public static IEnumerable<int> FibonacciSequence(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                yield return a;
                int temp = a;
                a = b;
                b = temp + b;
            }
        }
    }
}