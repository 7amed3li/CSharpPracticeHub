namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" yaricapi giriniz : ...");
            double yaricapi=int.Parse(Console.ReadLine()); // r  نصف القطر 
            // المحيط = 2 * نصف القطر* ار
            double cevre = 2 *Math.PI* yaricapi;
            double alan = 2 * yaricapi * yaricapi;

            Console.WriteLine("daira çeverısı = "  + cevre);
            Console.WriteLine("daira alani = "+ alan.);

        }
    }
}
