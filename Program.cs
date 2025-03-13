string? readInput;
bool validInput = false;
int testNumber = 0;

Console.WriteLine("Enter an integer between 5 and 10");

while (validInput == false)
{
    readInput = Console.ReadLine();
    int.TryParse(readInput, out testNumber);

    if (testNumber >= 5 && testNumber <= 10)
        validInput = true;
    else
    {
        Console.WriteLine($"The number {testNumber} is not between 5 and 10. Please try again.");
        //validInput = false;

    }
}

Console.WriteLine($"The number {testNumber} was accepted.");