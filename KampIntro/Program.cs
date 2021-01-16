using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //TYPE SAFETY :TİP GÜVENLİĞİ
            //do not repeat yourself
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azaldı butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("artis butonu");
            }
            else
            {
                Console.WriteLine("degismedi butonu");
            }



            if (sistemeGirisYapmisMi == true) 
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else if (true)
            {

            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
           
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
