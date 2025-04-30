using System;
using System.IO;

namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("plz enter bir sayi :");
            int sayi = int.Parse(Console.ReadLine());

            int sayac = 0;
            for (int i = 0; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                }

            }
            if (sayac < 2 || sayac == 1)
            {
                Console.WriteLine("asil sayidir");
            }
            else
            {
                Console.WriteLine("asyil sayi degildir");
            }
        }
    }
}
