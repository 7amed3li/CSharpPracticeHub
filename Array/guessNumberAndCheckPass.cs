namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] poun = new int[5];
            for (int i = 0; i < poun.Length; i++)
            {
                poun[i] = rnd.Next(1, 100);
                Console.Write(poun[i] + " ");
            }
                
            for (int i = 0; i < poun.Length; i++) {
                if (poun[i] >= 60) {
                    Console.WriteLine("pasarli");
                 
                }else
                    Console.WriteLine("degel");
            }
        }     
    }
}

