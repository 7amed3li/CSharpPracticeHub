namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üçgenin kenar uzunluklarını girin: ");
            double kenar1 = Convert.ToDouble(Console.ReadLine());
            double kenar2 = Convert.ToDouble(Console.ReadLine());
            double kenar3 = Convert.ToDouble(Console.ReadLine());

            if (kenar1 == kenar2 && kenar2 == kenar3)
            {// مثلث متساوي الاضلاع 
                Console.WriteLine("Bu bir eşkenar üçgendir.");
            }
            else if (kenar1 == kenar2 || kenar1 == kenar3 || kenar2 == kenar3)
            {
                //متساوي الساقين 
                Console.WriteLine("Bu bir ikizkenar üçgendir.");
            }
            else
            { // مختلف الاضلاع 
                Console.WriteLine("Bu bir çeşitkenar üçgendir.");
            }

        }
    }
}
