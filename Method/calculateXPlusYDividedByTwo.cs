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
            Console.Write("x değerini girin: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("y değerini girin: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double sonuc = DenklemHesapla(x, y);
            Console.WriteLine("Denklemin Sonucu: " + sonuc);
        }

        static double DenklemHesapla(double x, double y)
        {
            return x + (y / 2);
        }
    }
}
