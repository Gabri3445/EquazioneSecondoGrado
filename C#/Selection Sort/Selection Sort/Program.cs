string sortPath = "sorted.txt";
string unSortPath = "unsort.txt";
int arrSize = 0;
Console.WriteLine("Inserisci quanti elementi casuali vuoi");
arrSize = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int[] arr = new int[arrSize];
unSortWriteToTxt(new StreamWriter(unSortPath));
selecSort(arr);
sortWriteToTxt(new StreamWriter(sortPath));
Console.ReadKey();


void selecSort(int[] arr)
{
    int min;
    for (int i = 0; i < arrSize - 1; i++)
    {
        min = i;
        for (int j = i + 1; j < arrSize; j++)
        {
            if (arr[j] < arr[min])
            {
                min = j;
            }
        }
        swap(ref arr[min], ref arr[i]);
        int counter = i + 2;
        Console.WriteLine("Working / Iteration " + counter + " out of " + arrSize);
    }
    return;
}

void swap(ref int x, ref int y)
{
    int temp = x;
    x = y;
    y = temp;
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
            arr[i] = Convert.ToInt32(Random.Shared.Next(arrSize + arrSize * 2));
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