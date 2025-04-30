using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int count = 0;
            int sum = 0;

            for (int i = 0; i < 100; i++)
            {
                int num = random.Next(500, 1001);
                if (num % 3 == 0)
                {
                    count++;
                    sum += num;
                }
            }

            double average = (double)sum / count;
            Console.WriteLine("The sum of the numbers divisible by 3 is: " + sum);
            Console.WriteLine("The average of the numbers divisible by 3 is: " + average);
            Console.ReadKey();
        }
    }
}
