using CollatzConjecture;
using System.Diagnostics;

Stopwatch sw = new Stopwatch();

long num = Convert.ToInt64(Console.ReadLine());
Console.Clear();
sw.Start();
double[] data = Backend.Collatz(num).ToArray();
var plt = new ScottPlot.Plot(1000, 1000);
plt.AddSignal(data);
plt.SaveFig("./CollatzConjecture.png");
sw.Stop();
TimeSpan ts = sw.Elapsed;

string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
    ts.Hours, ts.Minutes, ts.Seconds,
    ts.Milliseconds / 10);
Console.WriteLine("Runtime " + elapsedTime);

Console.WriteLine($"Lenght of Collatz Conjecture = {data.Length - 1}");
Console.ReadKey();