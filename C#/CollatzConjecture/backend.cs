namespace CollatzConjecture
{
    public class Backend
    {
        public static IEnumerable<double> Collatz(int input)
        {
            if (input == 1)
            {
                yield break;
            }

            yield return input;

            if (input % 2 == 0)
            {
                foreach (var item in Collatz(input / 2))
                {
                    yield return item;
                }
            }
            else
            {
                foreach (var item in Collatz(input * 3 + 1))
                {
                    yield return item;
                }
            }
        }
    }
}