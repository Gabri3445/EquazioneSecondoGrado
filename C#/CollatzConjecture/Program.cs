using CollatzConjecture;

int num = Convert.ToInt32(Console.ReadLine());
double[] data = Backend.Collatz(num).ToArray();
var plt = new ScottPlot.Plot(1920, 1080);
plt.Palette = ScottPlot.Palette.OneHalf;
plt.AddSignal(data);
plt.SaveFig("./CollatzConjecture.png");
Console.WriteLine(data.Length);