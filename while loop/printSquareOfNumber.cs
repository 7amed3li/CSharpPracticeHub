namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("plz enter a number (-1 for equi)");// -1 اخرج من البرناكج 
            int num = int.Parse(Console.ReadLine());
            while (num != -1) 
            {
                Console.WriteLine("مربع الرقم المدخل = "+(num*num));

                Console.WriteLine("plz enter a number (-1 for equi)");// -1 اخرج من البرناكج 
                num = int.Parse(Console.ReadLine());
            }
        }     
    }
}
