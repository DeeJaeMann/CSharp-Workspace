internal class Program
{
    /// <summary>
    /// Performs factorial calculation on number.
    /// </summary>
    /// <param name="number">The number.</param>
    /// <returns>
    /// The result of the calculation as an int.
    /// </returns>
        static int Factorial(int number)
        {
            int result = 1;

            for (int thisNumber = number; thisNumber > 0; thisNumber--)
            {
                result *= thisNumber;
            }

            return result;
        }
    private static void Main()
    {
        Console.Write("Please enter a number: ");
        int number;
        string input = Console.ReadLine();


        if (int.TryParse(input, out number))
        {
            Console.WriteLine($"You entered {input}");
            Console.WriteLine($"Factorial: {Factorial(number)}");
        }
        else
        {
            Console.WriteLine("That is not a number!");
        }
    }
}