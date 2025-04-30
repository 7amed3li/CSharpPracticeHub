using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_problems
{
    internal class Program
    {
        static void Hello(string name)
        {
            
            Console.WriteLine("Hello"+name);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            Hello(name);
            Console.ReadLine();
        }
    }
}
