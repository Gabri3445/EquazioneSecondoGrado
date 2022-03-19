global using System.Collections.Generic;
using DividersEnum;

int number = 0;

do
{
    number = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    foreach (int i in Dividers.DividersFunc(number))
    {
        Console.WriteLine("{0}", i);
    }
} while (true);

