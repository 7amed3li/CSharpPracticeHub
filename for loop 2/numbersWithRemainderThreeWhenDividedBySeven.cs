namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int toplam = 0;
            int kactane = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 7 == 3)
                {
                    kactane++;
                    toplam += i;
                }

            }
            Console.WriteLine("kac sayi "+kactane);
            Console.WriteLine("sayilaar toplami = " + toplam);

        }
    }
}

