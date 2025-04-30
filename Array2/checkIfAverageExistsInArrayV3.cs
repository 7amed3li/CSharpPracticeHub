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
        {  // Rastgele sayılarla dolu bir dizi oluştur
            int[] dizi = new int[20];
            Random rand = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rand.Next(100); // 0 ile 99 arasında rastgele sayılar
            }

            // Çift ve tek toplamlarını hesapla
            int ciftToplam = 0;
            int tekToplam = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] % 2 == 0)
                {
                    ciftToplam += dizi[i];
                }
                else
                {
                    tekToplam += dizi[i];
                }
            }

            // Çift olanların toplamını tek olanların toplamına oranını bul
            double oran = ciftToplam / (double)tekToplam;

            // Sonucu ekrana yazdır
            Console.WriteLine($"Çift olanların toplamı: {ciftToplam}");
            Console.WriteLine($"Tek olanların toplamı: {tekToplam}");
            Console.WriteLine($"Çift olanların toplamı / Tek olanların toplamı oranı: {oran:F2}");


            Console.ReadLine();

        }
    }
}