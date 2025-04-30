مجموع وضرب الاعداد من 1 الى نون للاعداد الفرديه ومجموع مربع الاعداد من واحد الى نون للاعداد الزوجيه

namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" plz enter num :");
            int n = int.Parse(Console.ReadLine());

            int tekSToplam = 0;
            int tekScarpima = 1;
            int ceftSkarasi = 0;

            for(int i = 1;i<= n;i++)
            {
                if (i % 2 == 1)
                {
                    tekSToplam += i;
                    tekScarpima *= i;
                }
                else
                    ceftSkarasi += i * i;
            }

            Console.WriteLine(tekSToplam);
            Console.WriteLine(tekScarpima);
            Console.WriteLine(ceftSkarasi);
        }     
    }
}

