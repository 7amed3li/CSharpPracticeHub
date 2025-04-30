namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] poun = new int[10];
            for (int i = 0; i < poun.Length; i++)
            {
                poun[i] = rnd.Next(1, 100);
                Console.WriteLine(poun[i] + " ");
            }
            int max = 0;
            int sira = 0;
            for (int i = 0; i < poun.Length; i++)
            {
                if (poun[i] >= max)
                {
                    max = poun[i];
                    sira = i+1;
                }
            }
            Console.WriteLine("sinavlarda en yuksek poun  " + sira+"  siradaki ogerncidir ve pounler  "+max);
        }
    }
}

