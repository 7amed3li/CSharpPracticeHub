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
            Console.Write("Doğum yılınızı girin: ");
            int dogumYili = Convert.ToInt32(Console.ReadLine());

            int yas = YasHesapla(dogumYili);
            Console.WriteLine("Yaşınız: " + yas);
        }

        static int YasHesapla(int dogumYili)
        {
            int simdikiYil = DateTime.Now.Year;
            int yas = simdikiYil - dogumYili;
            return yas;
        }
    }
}
