namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 sayi giriniz :");
           
            int toplam = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((i+1)+" sayi giriniz :");
                int sayi = int.Parse(Console.ReadLine());
               
                toplam += i;
            }
            Console.WriteLine("sayilaar toplami = " + toplam);
        }
    }
}

