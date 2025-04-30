namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("fizedan kaç aldınız .... :");
            int vize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("finaldan kaç aldınız.... :");
            int final = Convert.ToInt32(Console.ReadLine());

            double ortalama = (vize * 0.4) + (final * 0.6);

            if (ortalama > 60)
                Console.WriteLine("tabreklar giçtin , ortalama = " + ortalama);
            else
                Console.WriteLine("Maalasef kaldin , ortalama = " + ortalama);
        }
    }
}