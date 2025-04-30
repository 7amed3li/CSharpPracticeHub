namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++) 
            {
                Console.Write(" pz enter a number : ");
                arr[i]=int.Parse(Console.ReadLine());
            }
            int sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue; 
            for (int i =0;i <arr.Length; i++)
            {
                sum+= arr[i];
                if (max < arr[i])
                    max = arr[i];
                if (min > arr[i])
                    min = arr[i];
            }
            Console.Write("The sum is :"+sum+"\n");
            Console.Write("the avrage is :"+(sum/5));
            Console.Write("max is :"+max+"\n");
            Console.Write("min is:"+min);
        }     
    }
}

