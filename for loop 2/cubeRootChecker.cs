using System.Data.SqlTypes;

namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("sayi sayinin giriniz : ");
            int sayi =int.Parse(Console.ReadLine());

            for(int i = 1;i <= sayi;i++)
            {
                Console.WriteLine(i + " * " + i +"* "+i+ "= " + Math.Pow(i,3) );
            }

        }
    }
}

