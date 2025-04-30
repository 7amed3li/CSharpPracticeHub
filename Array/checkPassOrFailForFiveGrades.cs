namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] poun = new int[5];
            for (int i = 0; i < poun.Length; i++) 
            {
                Console.Write(" pz enter a number : ");
                poun[i]=int.Parse(Console.ReadLine());
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

