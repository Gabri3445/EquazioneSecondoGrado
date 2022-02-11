int arrSize = 0;
Console.WriteLine("Inserisci quanti elementi casuali vuoi");
arrSize = Convert.ToInt32(Console.ReadLine());
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
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
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