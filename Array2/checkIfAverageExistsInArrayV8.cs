سؤال رقم 2 ف الملف 

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
        { // Rastgele sayılarla dolu bir dizi oluştur
            int[] dizi = new int[20];
            Random rand = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rand.Next(100); // 0 ile 99 arasında rastgele sayılar
            }

            // Kullanıcıdan bir sayı girmesini iste
            Console.Write("Bir sayı girin: ");
            int girilenSayi = Convert.ToInt32(Console.ReadLine());

            // Dizide girilen sayıdan küçük olan elemanları say
            int kucukElemanSayisi = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] < girilenSayi)
                {
                    kucukElemanSayisi++;
                }
            }

            // Sonucu ekrana yazdır
            Console.WriteLine($"Dizideki elemanlardan {girilenSayi}'den küçük olanların sayısı: {kucukElemanSayisi}");

           
            Console.ReadLine();

        }
    }
}