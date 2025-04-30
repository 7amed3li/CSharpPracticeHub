كم عدد الارقام التي يريد تخمينها ثم سوف يقلبهم ف الطباعه يعني اول تخمين هيكون الاخير والعكس .txt
namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kac adet sayi uretilsin: ");
            int adet =int.Parse(Console.ReadLine());
            Random rnd=new Random();
            int[] dizi = new int[adet];
            for (int i = 0; i < adet; i++) 
            {
                dizi[i] = rnd.Next();
                Console.WriteLine(i+"dizi elemani, ..:" + dizi[i]);

            }
            int temp = dizi[0];
            dizi[0] = dizi[adet-1];
            dizi[adet-1] = temp;
            Console.WriteLine("iki elemanla son eleman yer degesyrdi ");
            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine(i + "dizi elemanim ...." + dizi[i]);
            }



        }
    }
}
