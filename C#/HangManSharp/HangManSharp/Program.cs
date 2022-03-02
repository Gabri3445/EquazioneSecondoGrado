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


Console.WriteLine("Insert the word\t\t\t\t\t\tThe word is {0} characters long", randomWord.Length);
do 
{
    input = Console.ReadLine();

    if(_backend.Compare(word, input) != null)
    {
        checkArr = _backend.Compare(word, input);
        for (int i = 0; i < word.Length; i++)
        {
            if(checkArr[i] == 1)
            {
                
            }
            else if(checkArr[i] == 2)
            {

            }
        }
    } 
    else
    {
        Console.Write("Use the provided word count\r");
        Thread.Sleep(1000);
        Backend.RemoveCurrentConsoleLine();
        Console.SetCursorPosition()
    }

}
while (true);