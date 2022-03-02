using HangManSharp;

//Variables
string randomWord = null;
char[] word;
string input = "";

//Instantiate classes
Backend _backend = new Backend();
Backend.ConsoleSpinner consoleSpinner = new Backend.ConsoleSpinner();

//Catch the thread return value

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
word = randomWord.ToCharArray();

do 
{
    Console.WriteLine("Insert the word\t\t\t\t\t\tThe word is {0} characters long", randomWord.Length);
    input = Console.ReadLine();
    if(_backend.Compare(word, input) != null)
    {

    }

}
while (true);