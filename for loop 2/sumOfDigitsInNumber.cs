using System.Data.SqlTypes;

namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            while (sayi > 0)
            {
                int digit = sayi % 10;
                count += digit;
                sayi /= 10;
            }

            Console.WriteLine("Rakamların sayıları: " + count);

        }
    }
}

