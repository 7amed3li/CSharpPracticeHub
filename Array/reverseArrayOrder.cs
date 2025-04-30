using System.Data.SqlTypes;

namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[5];
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine("enter 5 adet  "+(i+1));
                dizi[i]  = int.Parse(Console.ReadLine());
            }
            for (int i = dizi.Length - 1; i >=0; i--)
            {
                Console.WriteLine(dizi[i]);
            }

        }
    }
}

