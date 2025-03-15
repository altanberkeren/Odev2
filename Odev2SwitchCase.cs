using System;

class Program
{
    static void Main()
    {
        Console.Write("Arabanin yasini girin: ");
        if (int.TryParse(Console.ReadLine(), out int yas))
        {
            Console.WriteLine(ArabaDurumuSwitch(yas));
        }
        else
        {
            Console.WriteLine("Gecersiz giris! Lutfen bir sayi girin.");
        }
    }

    static string ArabaDurumuSwitch(int yas)
    {
        switch (yas)
        {
            case < 0:
            case > 30:
                return "Ya hic uretilmedi ya da trafikten men edilmistir";

            case < 10:
                return "Arabaniz yeni";

            case < 20:
                return "Servise goturmeniz gerekebilir";

            case < 30:
                return "Arabaniz hurdaya cikabilir";

            default:
                return "Bilinmeyen durum";
        }
    }
}
