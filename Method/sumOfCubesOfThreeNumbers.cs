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
            Console.Write("3 basamaklı bir sayı girin: ");
            int num = Convert.ToInt32(Console.ReadLine());

            bool result = KontrolMetodu(num);

            if (result)
            {
                Console.WriteLine("Girilen sayı, basamaklarının küplerinin toplamına eşittir.");
            }
            else
            {
                Console.WriteLine("Girilen sayı, basamaklarının küplerinin toplamına eşit değildir.");
            }
            Console.ReadKey();  
        }

        static bool KontrolMetodu(int sayi)
        {
            if (sayi < 100 || sayi > 999)
            {
                throw new ArgumentOutOfRangeException("sayi", "Lütfen 3 basamaklı bir sayı girin.");
            }

            int birler = sayi % 10;
            int onlar = (sayi / 10) % 10;
            int yuzler = sayi / 100;

            int kupToplami = (birler * birler * birler) + (onlar * onlar * onlar) + (yuzler * yuzler * yuzler);

            return kupToplami == sayi;
        }
    }
}
