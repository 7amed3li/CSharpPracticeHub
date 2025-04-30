Console.Write("1. dik kenarı girin: ");
        double kenar1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("2. dik kenarı girin: ");
        double kenar2 = Convert.ToDouble(Console.ReadLine());

        double hipotenus = HipotenusHesapla(kenar1, kenar2);
        Console.WriteLine("Hipotenüs: " + hipotenus);
    }

    static double HipotenusHesapla(double kenar1, double kenar2)
    {
        double hipotenus = Math.Sqrt((kenar1 * kenar1) + (kenar2 * kenar2));
        return hipotenus;
    }