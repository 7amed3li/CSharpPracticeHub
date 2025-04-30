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
            Console.WriteLine("En fazla 20 karakterli bir kelime girin:");
            string kelime = Console.ReadLine();

            if (kelime.Length > 20)
            {
                Console.WriteLine("Hata: Kelime 20 karakterden uzun olamaz.");
                Console.ReadLine();
                return;
            }

            int sesliHarfSayisi = 0;
            int toplamKarakterSayisi = kelime.Length;

            for (int i = 0; i < kelime.Length; i++)
            {
                char harf = kelime[i];
                harf = char.ToLower(harf);

                if (harf == 'a' || harf == 'e' || harf == 'ı' || harf == 'i' || harf == 'o' || harf == 'ö' || harf == 'u' || harf == 'ü')
                {
                    sesliHarfSayisi++;
                }
            }

            double oran = (double)sesliHarfSayisi / toplamKarakterSayisi;

            Console.WriteLine($"Girilen kelimedeki sesli harflerin oranı: {oran:P}");


            Console.ReadKey();
        }        
    }
}