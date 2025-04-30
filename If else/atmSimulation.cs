namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            while (true)
            {
                Console.WriteLine("lutfen bir sayi seciniz : ");
                Console.WriteLine("1:hesapindaki kac var ");
                Console.WriteLine("2:para cekme :");
                Console.WriteLine("3:para yatirma :");
                Console.WriteLine("4:islem sonlandir :");
                int bakiye = 1000;
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    Console.WriteLine("Hespiniz :" + bakiye + " vardir ");
                    Console.WriteLine("-------------------------------------------------------------");

                }
                else if (secim == 2)
                {
                    Console.WriteLine("Ne kadar ihtiyacınız var :");
                    int cekem = Convert.ToInt32(Console.ReadLine());
                    if (bakiye > cekem)
                    {
                        float kac_kaldi = bakiye - cekem;
                        Console.WriteLine("hisapiniz " + kac_kaldi + " vardir ");
                        Console.WriteLine("-------------------------------------------------------------");

                    }
                    else
                    {
                        Console.WriteLine("Çekilen paranın hesabınızdaki tutardan az olması gerekir :");
                        Console.WriteLine("-------------------------------------------------------------");

                    }

                }
                else if (secim == 3)
                {
                    Console.WriteLine("Ne kadar para yatıracaksınız? ");
                    int yatirma = Convert.ToInt32(Console.ReadLine());
                    int kac_tutardi = bakiye + yatirma;
                    Console.WriteLine("hisapiniz " + kac_tutardi + "vardir ");
                    Console.WriteLine("-------------------------------------------------------------");

                }
                else
                {
                    Console.WriteLine("islem sonlandirdi");
                    Console.WriteLine("-------------------------------------------------------------");
                }
                    
            }
           
        }
    }
}