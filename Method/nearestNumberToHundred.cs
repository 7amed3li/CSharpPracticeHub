using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace solve_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("الرجاء إدخال الأرقام:");

            // الحصول على الأرقام من المستخدم كنص وتحويلها إلى أعداد صحيحة
            Console.Write("الرقم الأول: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("الرقم الثاني: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            // استدعاء الطريقة YakinSayi وطباعة الناتج
            int enYakinSayi = YakinSayi(sayi1, sayi2);
            if (enYakinSayi == 0)
            {
                Console.WriteLine("الأرقام متساوية.");
            }
            else
            {
                Console.WriteLine("العدد الأقرب إلى 100 هو: " + enYakinSayi);
            }
        }

        static int YakinSayi(int sayi1, int sayi2)
        {
            // حساب مقدار الاختلاف بين كل عدد والرقم 100
            int uzaklik1 = Math.Abs(100 - sayi1);
            int uzaklik2 = Math.Abs(100 - sayi2);

            // المقارنة بين قيم الاختلاف للعثور على العدد الأقرب إلى 100
            if (uzaklik1 < uzaklik2)
            {
                return sayi1;
            }
            else if (uzaklik2 < uzaklik1)
            {
                return sayi2;
            }
            else
            {
                return 0; // إذا كانت الأرقام متساوية
            }
        }
    }
}