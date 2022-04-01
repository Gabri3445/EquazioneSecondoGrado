namespace DividersBench;

public class Backend
{
    [Params(2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384, 32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4194304, 8388608, 16777216, 33554432, 67108864, 134217728, 268435456, 536870912, 1073741824, 2147483647)]
    public int N { get; set; }

    [Benchmark]
    public int[] Dividers()
    {
        int i = 0;
        int[] dividersArr = new int[N];
        long numCount, numDiv = 0;
        numDiv = N;
        while (numDiv > 0)
        {
            numCount = N % numDiv;
            if (numCount == 0)
            {
                dividersArr[i] += 1;
            }
            numDiv--;
            i++;
        }
        return dividersArr;
    }
}


