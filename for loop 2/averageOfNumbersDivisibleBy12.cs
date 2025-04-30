namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double toplam = 0;
            double kactane = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 12 == 0)
                {
                    kactane++;
                    toplam += i;
                }
                
            }
            double ortalama = toplam / kactane;
            Console.WriteLine("kac sayi "+kactane);
            Console.WriteLine("sayilaar toplami = "+ toplam);
            Console.WriteLine("ortalama ="+ortalama);

        }
    }
}

