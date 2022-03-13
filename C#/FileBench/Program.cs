using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;

//Main
var summary = BenchmarkRunner.Run<Benchmark>();

File.Delete("file0");

[MemoryDiagnoser]
[RPlotExporter]
public class Benchmark
{
    private string filePath;
    private readonly int[] data;

    public Benchmark()
    {
        filePath = "file0";
        data = new int[100];
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = i;
        }
    }

    [Benchmark]
    public void WriteFile()
    {
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            foreach (int i in data)
            {
                sw.WriteLine(i);
            }
        }
    }
}