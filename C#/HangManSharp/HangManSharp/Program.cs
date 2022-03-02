using HangManSharp;
//Instantiate classes
Backend _backend = new Backend();
Backend.ConsoleSpinner consoleSpinner = new Backend.ConsoleSpinner();

//Catch the thread return value
string randomWord = null;
Thread initThread = new Thread(() => { randomWord = _backend.GetWord(); });
initThread.Start();
//Loading animation
Console.Write("Loading...");
while (initThread.IsAlive != true)
{
    consoleSpinner.Turn();
    Thread.Sleep(200);
}
initThread.Join();
Console.Clear();
char[] word = randomWord.ToCharArray();
Console.WriteLine("Insert the word\t\t\t\t\t\tThe word is {0} characters long", randomWord.Length);