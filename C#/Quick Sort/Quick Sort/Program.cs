string sortPath = "sorted.txt";
string unSortPath = "unsort.txt";
int arrSize = 0;
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Inserisci quanti elementi casuali vuoi");
arrSize = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int[] arr = new int[arrSize];
unSortWriteToTxt(new StreamWriter(unSortPath));
int counter = 0;
QuickSort(arr, 0, arr.Length - 1);
sortWriteToTxt(new StreamWriter(sortPath));
Console.ReadKey();

void QuickSort(int[] arr, int start, int end)
{
    int i;
    if (start < end)
    {
        i = Partition(arr, start, end);

        QuickSort(arr, start, i - 1);
        QuickSort(arr, i + 1, end);
    }
}

int Partition(int[] arr, int start, int end)
{
    int temp;
    int p = arr[end];
    int i = start - 1;

    for (int j = start; j <= end - 1; j++)
    {
        if (arr[j] <= p)
        {
            i++;
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
    
    counter += 1;
    Console.WriteLine("Working / Iteration " + counter);

    temp = arr[i + 1];
    arr[i + 1] = arr[end];
    arr[end] = temp;
    return i + 1;
}

void sortWriteToTxt(StreamWriter sw)
{
    try
    {
        for (int i = 0; i < arrSize; i++)
        {
            sw.WriteLine(arr[i]);
        }
        sw.Close();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
    }
    finally
    {
        Console.WriteLine("Wrote sorted array to " + sortPath);
    }
}

void unSortWriteToTxt(StreamWriter sw)
{
    try
    {
        for (int i = 0; i < arrSize; i++)
        {
            arr[i] = Convert.ToInt32(Random.Shared.Next(Int32.MaxValue));
            sw.WriteLine(arr[i]);
        }
        sw.Close();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
    }
    finally
    {
        Console.WriteLine("Wrote unsorted array to " + unSortPath);
    }
}