namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Taban sayıyı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
             
            if(sayi%3==0 &&  sayi%5==0) {
                Console.WriteLine(sayi+" olyor");
            }else
                Console.WriteLine(sayi+" olmaz");

        }     
    }
}

