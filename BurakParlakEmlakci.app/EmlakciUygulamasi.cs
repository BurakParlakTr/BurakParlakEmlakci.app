

using System;
using System.Collections.Generic;
using System.IO;

public class EmlakciUygulamasi
{
    private List<Ev> evler = new List<Ev>();

    public void YeniEvGirisi()
    {
        Console.WriteLine("Yeni ev girişi");
        Console.WriteLine("1. Kiralık ev");
        Console.WriteLine("2. Satılık ev");
        Console.Write("Seçim yapınız: ");
        int secim = int.Parse(Console.ReadLine());


        if (secim == 1)
        {
            KiralikEvEkle();
            KiralikEvleriDosyayaYaz();
        }
        else if (secim == 2)
        {

            SatilikEvEKle();
            SatilikEvleriDosyayaYaz();


        }
        else
        {

            Console.WriteLine("Geçersiz seçim.");
        }



    }

    private void KiralikEvEkle()
    {
        Ev ev = new Ev();
        Console.WriteLine("Kiralık ev bilgilerini giriniz:");
        Console.Write("Oda sayısı: ");
        ev.OdaSayisi = int.Parse(Console.ReadLine());
        Console.Write("Kat sayısı: ");
        ev.KatSayisi = int.Parse(Console.ReadLine());
        Console.Write("Alan: ");
        ev.Alan = int.Parse(Console.ReadLine());
        Console.Write("Kira: ");
        ev.Kira = int.Parse(Console.ReadLine());
        Console.Write("Depozito: ");
        ev.Depozito = int.Parse(Console.ReadLine());

        evler.Add(ev);

        Console.Write("Devam etmek istiyor musunuz? (Evet/Hayır): ");
        string devam = Console.ReadLine();

        if (devam.ToLower() == "evet")
        {
            KiralikEvEkle();
            KiralikEvleriDosyayaYaz();
        }
        else
        {
            KiralikEvleriDosyayaYaz();
            Console.WriteLine("Ev bilgileri dosyaya kaydedildi.");
        }
    }
    private void SatilikEvEKle()
    {
        Ev ev = new Ev();
        Console.WriteLine("Satılık ev bilgilerini giriniz:");
        Console.Write("Oda sayısı: ");
        ev.OdaSayisi = int.Parse(Console.ReadLine());
        Console.Write("Kat sayısı: ");
        ev.KatSayisi = int.Parse(Console.ReadLine());
        Console.Write("Alan: ");
        ev.Alan = int.Parse(Console.ReadLine());
        Console.Write("Fiyat: ");
        ev.Fiyat = int.Parse(Console.ReadLine());

        evler.Add(ev);

        Console.Write("Devam etmek istiyor musunuz? (Evet/Hayır): ");
        string devam = Console.ReadLine();

        if (devam.ToLower() == "evet")
        {
            SatilikEvEKle();
            SatilikEvleriDosyayaYaz();
        }
        else
        {
            SatilikEvleriDosyayaYaz();
            Console.WriteLine("Ev bilgileri dosyaya kaydedildi.");
        }
    }

    private void KiralikEvleriDosyayaYaz()
    {
        using (StreamWriter sw = new StreamWriter("evler.txt"))


            foreach (Ev ev in evler)
            {
                sw.WriteLine($"Oda sayısı: {ev.OdaSayisi}");
                sw.WriteLine($"Kat sayısı: {ev.KatSayisi}");
                sw.WriteLine($"Alan: {ev.Alan}");
                sw.WriteLine($"Kira: {ev.Kira}");
                sw.WriteLine($"Depozito: {ev.Depozito}");
                sw.WriteLine("---------------------------------------");
            }
    }
    private void SatilikEvleriDosyayaYaz()
    {
        using (StreamWriter sw = new StreamWriter("evler.txt"))


            foreach (Ev ev in evler)
            {
                sw.WriteLine($"Oda sayısı: {ev.OdaSayisi}");
                sw.WriteLine($"Kat sayısı: {ev.KatSayisi}");
                sw.WriteLine($"Alan: {ev.Alan}");
                sw.WriteLine($"fiyat: {ev.Fiyat}");
                sw.WriteLine("---------------------------------------");
            }
    }






}










public class EmlakciUygulamasi1
{
    static void Main(string[] args)
    {
        EmlakciUygulamasi emlakci = new EmlakciUygulamasi();
        emlakci.YeniEvGirisi();
    }
}