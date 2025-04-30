using System.Data.SqlTypes;

namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("plz enter 10 sayi :");
            double sum = 0;
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                sum += number;
                count++;
            }

            double average = sum / count;
            Console.WriteLine("متوسط العدد: " + average);

            Console.WriteLine("العدد الذي تم استخدامه لحساب المتوسط:");
            for (int i = 0; i < 10; i++)
            {
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                if (number > average)
                {
                    Console.WriteLine(number);
                }
            }
    }
}

