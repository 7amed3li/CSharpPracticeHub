Örnek:
metot(2,3) -> 2^3 = 8
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
            Console.Write("Sayıyı girin: ");
            double sayi = Convert.ToDouble(Console.ReadLine());

            Console.Write("Üssü girin: ");
            int us = Convert.ToInt32(Console.ReadLine());

            double sonuc = UsAl(sayi, us);
            Console.WriteLine("{0} üzeri {1} = {2}", sayi, us, sonuc);
        }

        static double UsAl(double sayi, int us)
        {
            double sonuc = Math.Pow(sayi, us);
            return sonuc;
        }
    }
}
