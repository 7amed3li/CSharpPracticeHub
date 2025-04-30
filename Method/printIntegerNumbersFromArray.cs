Console.Write("Kaç tane sayı gireceksiniz? ");
        int sayiAdedi = Convert.ToInt32(Console.ReadLine());

        int[] kullaniciDizisi = new int[sayiAdedi];

        for (int i = 0; i < sayiAdedi; i++)
        {
            Console.Write("Sayı {0}: ", i + 1);
            kullaniciDizisi[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Girilen Sayılar:");
        DiziYazdir(kullaniciDizisi);
    }

    static void DiziYazdir(int[] dizi)
    {
        foreach (int sayi in dizi)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine();
    }