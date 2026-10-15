using System;

namespace TekCiftOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sayi sayiNesnesi = new Sayi();
            string cevap = "";

            while (cevap != "N" && cevap != "n")
            {
                Console.Write("Bir tam sayi giriniz: ");
                string giris = Console.ReadLine() ?? "";

                if (int.TryParse(giris, out int girilenSayi))
                {
                    sayiNesnesi.SetSayi(girilenSayi);

                    Console.WriteLine("Girilen sayi: " + sayiNesnesi.GetSayi());

                    if (sayiNesnesi.CiftMi())
                    {
                        Console.WriteLine("Sayi cifttir.");
                    }
                    else
                    {
                        Console.WriteLine("Sayi tektir.");
                    }
                }
                else
                {
                    Console.WriteLine("Gecersiz giris! Lutfen bir tam sayi giriniz.");
                }

                Console.Write("Devam etmek icin Enter'a basin, cikmak icin N/n girin: ");
                cevap = Console.ReadLine() ?? "";
            }

            Console.WriteLine("Program sonlandirildi.");
        }
    }
}
