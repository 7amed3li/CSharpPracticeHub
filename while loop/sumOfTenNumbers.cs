namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            int sum = 0;
            while (counter <= 10) 
            {
                Console.Write("plz enter num "+counter+" :");
                int x=int.Parse(Console.ReadLine());
                sum += x;
                counter++;
                
            }
            Console.WriteLine(sum);
        }     
    }
}
