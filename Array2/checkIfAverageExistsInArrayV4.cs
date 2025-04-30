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
            Console.WriteLine("Bir cümle girin:");
            string cumle = Console.ReadLine();

            Console.WriteLine("Aranacak karakteri girin:");
            char arananKarakter = Console.ReadKey().KeyChar;

            // Cümlenin içinde aranan karakterin sayısını bulma
            int karakterSayisi = 0;

            // Cümledeki her bir karakteri kontrol etme
            for (int i = 0; i < cumle.Length; i++)
            {
                // Aranan karakterle eşleşirse sayacı artır
                if (cumle[i] == arananKarakter)
                {
                    karakterSayisi++;
                }
            }

            // Sonuçları ekrana yazdırma
            Console.WriteLine($"\n'{arananKarakter}' karakteri cümlede {karakterSayisi} kez geçiyor.");


            Console.ReadKey();
        }        
    }
}