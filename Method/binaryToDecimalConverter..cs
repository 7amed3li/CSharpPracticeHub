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
            Console.Write("İkili sayıyı girin: ");
            string ikiliSayi = Console.ReadLine();

            int onlukTaban = IkiliSayiToOnlukTaban(ikiliSayi);
            Console.WriteLine("Onluk tabanda karşılığı: " + onlukTaban);
        }

        static int IkiliSayiToOnlukTaban(string ikiliSayi)
        {
            int onlukTaban = Convert.ToInt32(ikiliSayi, 2);
            return onlukTaban;
        }
    }
}
