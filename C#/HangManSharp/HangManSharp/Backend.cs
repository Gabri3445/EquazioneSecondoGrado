using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HangManSharp
{
    internal class Backend
    {
        public string GetWord() => File.ReadLines("words").Skip(Random.Shared.Next(1000)).Take(1).FirstOrDefault();

        public class ConsoleSpinner
        {
            int counter;
            public ConsoleSpinner()
            {
                counter = 0;
            }
            public void Turn()
            {
                counter++;
                switch (counter % 4)
                {
                    case 0: Console.Write("/"); break;
                    case 1: Console.Write("-"); break;
                    case 2: Console.Write("\\"); break;
                    case 3: Console.Write("|"); break;
                }
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
        }

        public int[] Compare(char[] str, string input)
        {
            int[] arr = new int[str.Length];
            char[] inputChar = input.ToCharArray();

            if(str.Length != input.Length)
            {
                return null;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != inputChar[i])
                    arr[i] = 1;
            }

            return arr;
        }
    }
}