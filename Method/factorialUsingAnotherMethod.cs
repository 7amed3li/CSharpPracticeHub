using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Faktöriyelini hesaplamak istediğiniz sayıyı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            long faktoriyel = FaktoriyelHesapla(sayi);
            Console.WriteLine(sayi + " sayısının faktöriyeli: " + faktoriyel);

            Console.ReadKey();
        }

        static long FaktoriyelHesapla(int sayi)
        {
            if (sayi < 0)
            {
                Console.WriteLine("Negatif sayıların faktöriyeli yoktur.");
            }

            long faktoriyel = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel *= i;
            }

            return faktoriyel;
        }
    }
}
