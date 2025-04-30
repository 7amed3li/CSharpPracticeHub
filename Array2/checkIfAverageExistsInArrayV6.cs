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

            for (int i = 0; i < 10; i++)
            {
                Console.Write("plz enter "+ (i+1) + ", inci sayi : " );
                dizi[i] = int.Parse(Console.ReadLine());
            }
            int enBuyuk = dizi[0];
            int enKucuk = dizi[0];
            int enBuyukIndex = 0;
            int enKucukIndex = 0;

            // البحث في المصفوفة للعثور على أكبر وأصغر قيم
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] > enBuyuk)
                {
                    enBuyuk = dizi[i];
                    enBuyukIndex = i;
                }

                if (dizi[i] < enKucuk)
                {
                    enKucuk = dizi[i];
                    enKucukIndex = i;
                }
            }

            // طباعة النتائج على الشاشة
            Console.WriteLine("أكبر قيمة: " + enBuyuk);
            Console.WriteLine("أصغر قيمة: " + enKucuk);
            Console.WriteLine("ترتيب أكبر قيمة: " + (enBuyukIndex + 1)); // المصفوفات تبدأ العد من الصفر، لذا يتم إضافة +1 هنا.
            Console.WriteLine("ترتيب أصغر قيمة: " + (enKucukIndex + 1));

            

            Console.ReadLine();

        }
    }
}