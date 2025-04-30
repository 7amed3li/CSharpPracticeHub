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
            Console.Write("الرجاء إدخال درجة الحرارة بالسيليزية: ");
            double santigrat = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = SantigratToFahrenheit(santigrat);
            Console.WriteLine("{0} درجة سيليزية = {1} درجة فهرنهايت", santigrat, fahrenheit);
            Console.ReadKey();
        }
        static double SantigratToFahrenheit(double santigrat)
        {
            return (santigrat * 9 / 5) + 32;
        }  
    }
}