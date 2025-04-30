    Console.Write(" lütfen bir sayı giriniz : ");
    float sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi == 1)
    {
        Console.WriteLine("asil sayi degeldir");
        return;
    }
    for (float i = 2; i <sayi/2; i++) 
    {
        if (sayi % i == 0 ) 
        {
            Console.Write("onu asil sayi değildir", i);
            return;
        }

    }
    Console.WriteLine("asil sayidir ");
    Console.ReadLine();
}