using System;
using System.Collections.Generic;
//Genericleri daha ogrenmedik ancak kısa şekilde yazmak icin kullanmak istedim.
class Araba
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public double YakıtTüketimi { get; set; } // 100 km'de tuketilen yakıt (litre)
    public double KatEdilenMesafe { get; set; } // Kat edilen mesafe (km)

    //Yapıcı Metot (Constructor)
    public Araba(string marka, string model, double yakitTuketimi, double katEdilenMesafe)
    {
        Marka = marka;
        Model = model;
        YakıtTüketimi = yakitTuketimi;
        KatEdilenMesafe = katEdilenMesafe;
    }

    //Arabanın toplam yakıt tuketimini hesaplayan metot
    public double ToplamBenzinTuketimi()
    {
        return (YakıtTüketimi / 100) * KatEdilenMesafe;
    }

    //Araba bilgilerini ekrana yazdıran metot
    public void BilgileriGoster()
    {
        Console.WriteLine($"Marka: {Marka}, Model: {Model}, 100km'de Tüketim: {YakıtTüketimi}L, Kat Edilen Mesafe: {KatEdilenMesafe}km, Toplam Yakıt: {ToplamBenzinTuketimi():F2}L");
    }
}

class Program
{
    static void Main()
    {
        //Araba Listesi
        List<Araba> arabalar = new List<Araba>
        {
            new Araba("Toyota", "Corolla", 6.5, 500),
            new Araba("Honda", "Civic", 7.2, 600),
            new Araba("BMW", "320i", 8.9, 400),
            new Araba("Ford", "Focus", 7.5, 550)
        };

        double toplamBenzin = 0;

        Console.WriteLine("Araba Listesi ve Yakit Tuketimi");
        foreach (var araba in arabalar)
        {
            araba.BilgileriGoster();
            toplamBenzin += araba.ToplamBenzinTuketimi();
        }

        Console.WriteLine($"\nToplam Yakit Tuketimi: {toplamBenzin:F2} Litre");
    }
}
