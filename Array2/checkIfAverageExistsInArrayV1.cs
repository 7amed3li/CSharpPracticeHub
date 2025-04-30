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
            int[] dizi = new int[100];
            Random rnd= new Random();
            int toplam = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0,11);
                Console.Write (" > "+ dizi[i]+"\n");
                toplam += i;
            }
            double avg=toplam /dizi.Length;  
            Console.Write ("toplam : "+ toplam + "\n");
            Console.WriteLine("avrage is :" + avg +"\n");

            int avgesit = 0;
            for (int i = 1;i < dizi.Length;i++) 
            {
                if (dizi[i] ==avg)
                {
                    avgesit++;
                }
            }
            Console.WriteLine(" dizi sayilar avrage isit : "+ avgesit);
           
            Console.ReadKey();
        }        
    }
}