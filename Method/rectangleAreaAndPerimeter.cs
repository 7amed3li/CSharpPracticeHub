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
            Console.Write("Dikdörtgenin kısa kenarını girin: ");
            double kisaKenar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Dikdörtgenin uzun kenarını girin: ");
            double uzunKenar = Convert.ToDouble(Console.ReadLine());

            double alan = DikdortgenAlanHesapla(kisaKenar, uzunKenar);
            double cevre = DikdortgenCevreHesapla(kisaKenar, uzunKenar);

            Console.WriteLine("Dikdörtgenin Alanı: " + alan);
            Console.WriteLine("Dikdörtgenin Çevresi: " + cevre);
        }

        static double DikdortgenAlanHesapla(double kisaKenar, double uzunKenar)
        {
            return kisaKenar * uzunKenar;
        }

        static double DikdortgenCevreHesapla(double kisaKenar, double uzunKenar)
        {
            return 2 * (kisaKenar + uzunKenar);
        }
    }
}
