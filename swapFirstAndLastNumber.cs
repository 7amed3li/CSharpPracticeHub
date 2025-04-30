using System.Data.SqlTypes;

namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int temp = number1;
        number1 = number2;
        number2 = temp;

        Console.WriteLine("After swapping:");
        Console.WriteLine("First number: " + number1);
        Console.WriteLine("Second number: " + number2);
        }
    }
}

