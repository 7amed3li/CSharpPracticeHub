namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count= 0;
            for (int i = 0; i <= 100; i++) 
            {
                if (i % 7 == 3) {
                    count++; // إذا كان الشرط صحيحًا، يتم زيادة قيمة count بواحد.
                }
            }
            Console.WriteLine("kaln = "+ count);
        }
    }
}

