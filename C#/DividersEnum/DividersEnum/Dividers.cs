using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividersEnum
{
    internal class Dividers
    {
        public static IEnumerable<int> DividersFunc(int num)
        {
            int numDiv, numCount = 0;
            numDiv = num;

            while (numDiv > 0)
            {
                numCount = num % numDiv;
                if (numCount == 0)
                {
                    yield return numDiv;
                }
                numDiv--;
            }
        }
    }
}
