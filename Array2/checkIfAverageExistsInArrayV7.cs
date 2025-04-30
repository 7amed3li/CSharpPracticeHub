using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[10];
            Random rnd= new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0,101);
                Console.Write (" > "+ dizi[i]+"\n");
            }
            int en_kucuk = dizi[0];
            int index = 0;

            for (int i = 1;i < dizi.Length;i++) 
            {
                if (dizi[i] < en_kucuk)
                {
                    en_kucuk = dizi[i];
                    index=i; 
                }
            }
            Console.WriteLine("en kucuk :"+ en_kucuk);
            Console.WriteLine("index :" + (index+1) );
            Console.ReadKey();
        }        
    }
}