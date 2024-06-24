// See https://aka.ms/new-console-template for more information
Console.Write("Please enter a number: ");
int number;
string input = Console.ReadLine();

int Factorial(int number)
{
    int result = 1;
    Console.WriteLine($"Number is {number}");

    for ( int thisNumber = number; thisNumber > 0; thisNumber--)
    {
        result *= thisNumber;
        Console.WriteLine($"thisNumber {thisNumber} result {result}");
    }

    return result;
}

if ( int.TryParse(input, out number) )
{
    Console.WriteLine($"You entered {input}");
    Console.WriteLine($"Factorial: {Factorial(number)}");
}
else
{
    Console.WriteLine("That is not a number!");
}


