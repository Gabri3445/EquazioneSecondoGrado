using HangManSharp;

//Variables
string randomWord = null;
char[] word;
string input = "";
int[] checkArr;

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


Console.WriteLine("Insert the word\t\t\t\t\t\t\t\t\tThe word is {0} characters long", randomWord);
do 
{
    input = Console.ReadLine();

    if(_backend.Compare(word, input) != null)
    {
        checkArr = _backend.Compare(word, input);
        _backend.Print(checkArr, input);
    } 
    else if (_backend.Compare(word, input) == null)
    {
        Console.Write("Use the provided word count");
        Thread.Sleep(1000);
        Backend.RemoveCurrentConsoleLine();
    }
    else
    {

    }

}
while (true);