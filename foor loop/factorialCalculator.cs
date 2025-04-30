namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" plz enter num :");
            int n = int.Parse(Console.ReadLine());

            int faktoryal = 1;

            if (n < 0)
            {
                Console.WriteLine("hesaplamaz ");
            }
            else
            { 
                for(int i = 1; i <= n; i++)
                {
                    faktoryal *= i;
                }
                Console.WriteLine(faktoryal);
            }
        }     
    }
}

