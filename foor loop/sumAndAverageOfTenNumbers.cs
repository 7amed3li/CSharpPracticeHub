namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("enter 10 numbers :");
            int sum = 0;
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(" plz enter num "+(i+1)+":");
                int n = int.Parse(Console.ReadLine());
                sum = sum + i;
            }
            double avg = sum / 10;

            Console.WriteLine("the sum is : "+sum);
            Console.WriteLine("the avrage is :"+avg);
        }
    }
}

