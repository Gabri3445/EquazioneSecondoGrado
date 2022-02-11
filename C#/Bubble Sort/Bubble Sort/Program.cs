int arrSize = 0;
Console.WriteLine("Inserisci quanti elementi casuali vuoi");
arrSize = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int[] arr = new int[arrSize];
for (int i = 0; i < arrSize; i++)
{
    arr[i] = Convert.ToInt32(Random.Shared.Next(arrSize + arrSize));
}
printArray(arr);
for (int i = 0; i < 10; i++)
{
    Console.Write("\n");
}
bubbleSort(arr);
printArray(arr);
Console.ReadKey();
void bubbleSort(int[] arr)
{
    int i = 0, j = 0;

    for (i = 0; i < arrSize - 1; i++)
    {
        for (j = 0; j < arrSize - 1 - i; j++)
        {
            if (arr[j] > arr[j + 1])
            {
               swap(ref arr[j], ref arr[j + 1]);
            }
        }
    }
}
void printArray(int[] arr)
{
    for (int i = 0; i < arrSize; i++)
    {
        Console.WriteLine(arr[i]);
    }
}
void swap(ref int x, ref int y)
{
    int temp = x;
    x = y;
    y = temp;
}