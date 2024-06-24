namespace Factorial
{
    public class Program
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
        public static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number;
            string input = Console.ReadLine();

            Console.WriteLine();
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
}