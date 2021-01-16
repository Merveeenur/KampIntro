using System;

namespace Methotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama= "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";


            Urun[] urunler = new Urun[] {urun1,urun2};
            //type-safe -- tip güvenli sistemler bu diller

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------");
            }

            Console.WriteLine("------Metotlar------");
             //instance -örnek
             //encapsulation !!!!!!!

            SepetManager sepetManager = new SepetManager ();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut","yeşil",12,10);
            sepetManager.Ekle2("elma", "yeşil", 12,5);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 12,3);
        }
    }
}
//dont repeat yourself =DRY =Clean Code=Best Practise