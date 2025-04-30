using System.Data.SqlTypes;

namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Lütfen sayı sayısını giriniz: ");
            int sayiSayisi = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine( sayiSayisi+ "*" + i +"="+sayiSayisi * i);
            }

        }
    }
}

