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
            // تعريف مصفوفة لتخزين القيم
            int[] myArray = new int[10];

            // طلب إدخال 10 قيم من المستخدم
            Console.WriteLine("الرجاء إدخال 10 قيم:");

            // حلقة for لجمع الإدخالات وتخزينها في المصفوفة
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"القيمة {i + 1}: ");

                // تخزين القيمة المدخلة مباشرة في المصفوفة
                // (تحقق من صحة الإدخال يمكن أن يتم إضافته هنا بحسب الحاجة)
                myArray[i] = int.Parse(Console.ReadLine());
            }

            // طباعة القيم المخزنة في المصفوفة
            Console.WriteLine("القيم المخزنة في المصفوفة:");

            // حلقة for لطباعة القيم المخزنة في المصفوفة
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
