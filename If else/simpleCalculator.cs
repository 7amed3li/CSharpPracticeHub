namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE FIRST NUM :");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("ENTER THE FIRST NUM :");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine(" enter the opration '+' , '-', '*' , '/' ");
            char opration=char.Parse(Console.ReadLine());

            if (opration == '+')
            {
                Console.WriteLine("num1 + num2 = " + (num1 + num2));
            }
            else if (opration == '-')
            {
                Console.WriteLine("num1 - num2  = " + (num1 - num2));
            }
            else if (opration == '*')
            {
                Console.WriteLine("num1 * num2 = " + (num1 * num2));
            }
            else if (opration == '/')
            {
                Console.WriteLine("num1 / num2 = " + (num1 / num2));
            }
          
        }
    }
}

