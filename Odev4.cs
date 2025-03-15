using System;
using System.Collections.Generic;
//Genericleri daha ogrenmedik ancak kısa şekilde yazmak icin kullanmak istedim.
class Calisan
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Meslek { get; set; }
    public double Maas { get; set; }
    public string Departman { get; set; }

    //Yapıcı Metot (Constructor)
    public Calisan(string ad, string soyad, string meslek, double maas, string departman)
    {
        Ad = ad;
        Soyad = soyad;
        Meslek = meslek;
        Maas = maas;
        Departman = departman;
    }

    //Çalışan bilgilerini ekrana yazdıran metot
    public void BilgileriGoster()
    {
        Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Meslek: {Meslek}, Maas: {Maas:C}, Departman: {Departman}");
    }
}

class Program
{
    static void Main()
    {
        //Çalışan Listesi
        List<Calisan> calisanlar = new List<Calisan>
        {
            new Calisan("Acun", "Ilicali", "Genel Müdür (GM)", 50000, "Yonetim"),
            new Calisan("Ibrahim", "Gokyar", "Mudur (MU)", 30000, "Yazilim"),
            new Calisan("Musa", "Uyumaz", "Programci (PR)", 20000, "Yazilim"),
            new Calisan("Gokhan", "Sal", "Stajyer (S)", 5000, "Yazilim")
        };

        double toplamMaas = 0;

        Console.WriteLine("Calisan Listesi");
        foreach (var calisan in calisanlar)
        {
            calisan.BilgileriGoster();
            toplamMaas += calisan.Maas;
        }

        Console.WriteLine("\nToplam Maas: " + toplamMaas.ToString("C"));
    }
}
