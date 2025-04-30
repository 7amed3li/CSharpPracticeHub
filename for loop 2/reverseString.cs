using System.Data.SqlTypes;

namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir ifade giriniz :");
            string ifade=Console.ReadLine();
            Console.WriteLine("girdginiz ifade tarsi :");
            for (int i = ifade.Length - 1; i >= 0; i--)
            {
                Console.Write(ifade[i]);
            }

        }
    }
}

