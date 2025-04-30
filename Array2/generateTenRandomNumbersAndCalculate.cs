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
            int[] dizi = new int[10];

            Random rnd = new Random();
            int toplam = 0;
            for (int i = 0; i < 10; i++)
            {
                dizi[i] = rnd.Next(1,101);
                toplam += i;
            }

            Console.WriteLine("Rastgele Oluşturulan Dizi: " + string.Join(", ", dizi));
            double ort = toplam / 10;
            Console.WriteLine("Dizinin Ortalaması: " + ort);

            int enbuyuk = dizi[0];
            int enkucuk = dizi[0];

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i]>enbuyuk)
                {
                    enbuyuk = dizi[i];
                    Console.WriteLine("rnbuyuk "+ enbuyuk);
                }
                if (dizi[i]<enkucuk)
                {
                    enkucuk = dizi[i];
                    Console.WriteLine("enkucuk "+enkucuk);
                }
            }
            Console.WriteLine("");
            Console.ReadLine();

        }
    }
}