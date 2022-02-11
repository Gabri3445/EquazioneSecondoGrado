long num = 0;
do
{
    Console.WriteLine("Scrivi un numero maggiore di zero");
    num = Convert.ToInt64(Console.ReadLine());
    divisori(num);
} while (num > 0);

void divisori(long num)
{
    long numCount, numDiv = 0;
    numDiv = num;
    while (numDiv > 0)
    {
        numCount = num % numDiv;
        if (numCount == 0)
        {
            Console.WriteLine(numDiv);
        }
        numDiv--;
    }
    return;
}