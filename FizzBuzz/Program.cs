internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a number between 1 and 100:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number >= 1 && number <= 100)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("Error: Number must be between 1 and 100.");
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid input.");
        }
    }
}