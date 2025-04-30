namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plz Enter first number.... :");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Plz Enter secound number.... :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine("Num 1 is begest" + num1);
            else
                Console.WriteLine("Num 2 is begest " + num2);
        }
    }
}  