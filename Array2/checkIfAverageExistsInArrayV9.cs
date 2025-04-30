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
        {
            //- 10 boyutlu bir diziyi rastgele sayılarla doldurunuz. Bu sayıların ortalaması ile en büyük ve en
            //küçük sayının ortalamasını bularak, bu 2 ortalamanın farkını bulan programı yazınız.
            int[] dizi = new int[20];

            Random rnd = new Random();

            int buyukToplam = 0;
            int kucukToplam = 0;
            
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0,101);
                Console.Write(dizi[i] + " ");

                if (dizi[i] > 50)
                {
                    buyukToplam += dizi[i];
                }
                else
                {
                    kucukToplam += dizi[i];
                }

            }

            double oran = (double)buyukToplam / kucukToplam;

            // Sonuçları ekrana yazdırma
            Console.WriteLine("\n\n50'den Büyük Olanların Toplamı: " + buyukToplam);
            Console.WriteLine("50'den Küçük Olanların Toplamı: " + kucukToplam);
            Console.WriteLine("Oran: " + oran);

            Console.ReadKey();
        }        
    }
}