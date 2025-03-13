string? readInput;
bool validInput = false;
int testNumber = 0;

Console.WriteLine("Enter an integer between 5 and 10");

while (validInput == false)
{
    bool parsePass;

    readInput = Console.ReadLine();
    parsePass = int.TryParse(readInput, out testNumber);

    if (!parsePass)
        Console.WriteLine($"{readInput} is not a number. Please try again.");
    else if (testNumber >= 5 && testNumber <= 10)
        validInput = true;
    else
        Console.WriteLine($"{testNumber} is not between 5 and 10. Please try again.");
}

Console.WriteLine($"The number {testNumber} was accepted.");