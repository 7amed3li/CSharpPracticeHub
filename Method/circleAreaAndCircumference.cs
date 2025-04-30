  Console.Write("Dairenin yarıçapını girin: ");
        double yaricap = Convert.ToDouble(Console.ReadLine());

        double alan = DaireAlanHesapla(yaricap);
        double cevre = DaireCevreHesapla(yaricap);

        Console.WriteLine("Dairenin Alanı: " + alan);
        Console.WriteLine("Dairenin Çevresi: " + cevre);
    }

    static double DaireAlanHesapla(double yaricap)
    {
        return Math.PI * yaricap * yaricap;
    }

    static double DaireCevreHesapla(double yaricap)
    {
        return 2 * Math.PI * yaricap;
    }