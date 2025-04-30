namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" plz enter num : ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("the sum is : "+sum);
        }
    }
}

