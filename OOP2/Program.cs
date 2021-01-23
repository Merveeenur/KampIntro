using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Id = 1;
            musteri1.Adi = "engin";
            musteri1.Soyadi = "demir";
            musteri1.Soyadi = "12345678910";


            //kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2; 
            musteri2.MusteriNo = "123456";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "124568";

            //Gerçek  müşteri - Tüzel müşteri
            //SOLID
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
        }

    }
}
