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
            Console.Write("Bir pozitif sayı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int basamakSayisi = BasamakHesapla(sayi);
            Console.WriteLine("{0} sayısı {1} basamaklıdır.", sayi, basamakSayisi);
        }
        static int BasamakHesapla(int sayi)
        {
            if (sayi <= 0)
            {
                Console.WriteLine("Lütfen pozitif bir sayı girin.");
            }

            int basamakSayisi = 0;
            while (sayi != 0)
            {
                sayi /= 10;
                basamakSayisi++;
            }

            return basamakSayisi;
        }
    }
}
