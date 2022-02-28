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
        public string getWord()
        {
            const int wordCount = 1000;
            int randomWordNum = Random.Shared.Next(wordCount);
            try
            {
                StreamReader sr = new StreamReader("words");

                for (int i = 0; i < wordCount; i++)
                {
                    sr.ReadLine();
                    if (i == randomWordNum)
                    {
                        return sr.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(1);
            }
            return null;
        }
    }
}