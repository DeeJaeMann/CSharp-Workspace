// See https://aka.ms/new-console-template for more information
Console.Write("Please enter a number: ");
int number;
string input = Console.ReadLine();

int Factorial(int number)
{
    return 0;
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


