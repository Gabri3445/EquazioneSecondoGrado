int foo = 0;
bool errorlevel = false;

try
{
    foo = Convert.ToInt32(Console.ReadLine());
}
catch (FormatException ex)
{
    errorlevel = true;
    throw new System.FormatException("Value entered was not a integer", ex);
}
finally
{
    if (errorlevel == false)
        Console.WriteLine(foo);
}