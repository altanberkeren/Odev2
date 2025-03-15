using System;

class Program
{
    static void Main()
    {
        Console.Write("Arabanin yasini girin: ");
        if (int.TryParse(Console.ReadLine(), out int yas))
        {
            Console.WriteLine(ArabaDurumuIfElse(yas));
        }
        else
        {
            Console.WriteLine("Gecersiz giris! Lutfen bir sayi girin.");
        }
    }

    static string ArabaDurumuIfElse(int yas)
    {
        if (yas < 0 || yas > 30)
            return "Ya hic uretilmedi ya da trafikten men edilmistir";
        else if (yas < 10)
            return "Arabaniz yeni";
        else if (yas < 20)
            return "Servise goturmeniz gerekebilir";
        else
            return "Arabaniz hurdaya cikabilir";
    }
}
