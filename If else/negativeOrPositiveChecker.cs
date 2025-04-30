namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("l]tfen bir sayi giriniz .... :");
            int sayi = Convert.ToInt32(Console.ReadLine());


            if (sayi == 0)
                Console.WriteLine("o sayi sifirdir");
            else if (sayi > 0)
                Console.WriteLine("o sayi pozitiftir ");
            else
                Console.WriteLine("o sayi negatiftir ");
        }
    }
}