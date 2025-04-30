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
            Console.Write("Kaç tane sayı gireceksiniz? ");
            int sayiAdedi = Convert.ToInt32(Console.ReadLine());

            int[] kullaniciDizisi = new int[sayiAdedi];

            for (int i = 0; i < sayiAdedi; i++)
            {
                Console.Write("Sayı {0}: ", i + 1);
                kullaniciDizisi[i] = Convert.ToInt32(Console.ReadLine());
            }

            int enBuyuk = EnBuyukBul(kullaniciDizisi);
            Console.WriteLine("Dizideki En Büyük Sayı: " + enBuyuk);
        }

        static int EnBuyukBul(int[] dizi)
        {
            int enBuyuk = dizi[0]; // Dizinin ilk elemanını en büyük kabul ediyoruz.

            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] > enBuyuk)
                {
                    enBuyuk = dizi[i];
                }
            }

            return enBuyuk;
        }
    }
}
