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
        static int sayiOku ()
        {
            Console.WriteLine("pez enter a num");
            int x=int.Parse(Console.ReadLine());
            return x;
        }
        static int  factoriyal(int x)
        {
            
            if (x < 0)
                return -1;
            if (x == 0)
                return 1;
            int f=1;
            
                for (int i = 1; i <= x; i++)
                {
                    f *= i;
                }
                return f;
            
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(factoriyal(sayiOku()));
                Console.ReadKey();

            }
        }
        
    }
}
