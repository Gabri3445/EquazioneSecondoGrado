namespace Reversort;
class Program
    {
        public static void Main()
        {
            int[] arr = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            reversort(arr);
            Print(arr);
        }  

        public static void Print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }

        public static int reversort(int[] arr)
        {
            int j = 0;
            int reverseCount = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                j = findMinIndex(arr, i, arr.Length);
                reverseCount = j - i + 1;
                
            }
            return j;
        }

        public static int findMinIndex(int[] arr, int begin, int end)
        {
            int minIndex = begin;
            for (int i = 0; i < end; i++)
            {
                if (arr[i] < arr[minIndex])
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }

        public static void reverse
    }