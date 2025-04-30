Console.Write("Kaç tane sayı gireceksiniz? ");
        int sayiAdedi = Convert.ToInt32(Console.ReadLine());

        int[] kullaniciDizisi = new int[sayiAdedi];

        for (int i = 0; i < sayiAdedi; i++)
        {
            Console.Write("Sayı {0}: ", i + 1);
            kullaniciDizisi[i] = Convert.ToInt32(Console.ReadLine());
        }

        SayilariSay(kullaniciDizisi);
    }

    static void SayilariSay(int[] dizi)
    {
        int pozitifSayisi = 0;
        int negatifSayisi = 0;

        foreach (int sayi in dizi)
        {
            if (sayi > 0)
            {
                pozitifSayisi++;
            }
            else if (sayi < 0)
            {
                negatifSayisi++;
            }
        }

        Console.WriteLine("Pozitif Sayıların Sayısı: " + pozitifSayisi);
        Console.WriteLine("Negatif Sayıların Sayısı: " + negatifSayisi);
    }