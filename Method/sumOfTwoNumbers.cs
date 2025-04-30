using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_problems
{
    internal class Program
    {
        public static int Sum(int num1, int num2)
        {
            int total;
            total = num1 + num2;
            return total;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter first num");
            int n1=int.Parse(Console.ReadLine());
            Console.WriteLine("enter secound num");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("the sum is : "+Sum(n1,n2));
            Console.ReadLine();

        }
    }
}
