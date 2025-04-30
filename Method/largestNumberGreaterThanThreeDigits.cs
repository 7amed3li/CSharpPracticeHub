 Console.WriteLine("الرجاء إدخال الأرقام:");

        // الحصول على الأرقام من المستخدم كنص وتحويلها إلى أعداد صحيحة
        Console.Write("الرقم الأول: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("الرقم الثاني: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("الرقم الثالث: ");
        int sayi3 = Convert.ToInt32(Console.ReadLine());

        // استدعاء الطريقة EnBuyukSayi وطباعة الناتج
        int enBuyuk = EnBuyukSayi(sayi1, sayi2, sayi3);
        Console.WriteLine("العدد الأكبر هو: " + enBuyuk);
    }

    static int EnBuyukSayi(int sayi1, int sayi2, int sayi3)
    {
        // بحث عن العدد الأكبر بين الأرقام المدخلة
        int enBuyuk = sayi1;

        if (sayi2 > enBuyuk)
        {
            enBuyuk = sayi2;
        }

        if (sayi3 > enBuyuk)
        {
            enBuyuk = sayi3;
        }

        return enBuyuk;
    }