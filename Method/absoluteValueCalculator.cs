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
            Console.Write("İki tam sayıyı girin:\nSayı 1: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sayı 2: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int farkinMutlakDegeri = MutlakFark(sayi1, sayi2);
            Console.WriteLine("Girilen sayıların farkının mutlak değeri: " + farkinMutlakDegeri);
            Console.ReadKey();
        }

        static int MutlakFark(int sayi1, int sayi2)
        {
            int fark = sayi1 - sayi2;
            int mutlakDeger = Math.Abs(fark);
            return mutlakDeger;
        }
    }
}