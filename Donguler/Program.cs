using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        { 
            //array - dizi 
            string[] kurslar = new string[] {"yazılım geliştirici yetiştirme kampı", 
                "programlamaya başlangıç için temel kurs",
                "java" ,"python" ,"C++"};

            for (int i = 0; i < kurslar.Length; i++)
            {
              Console.WriteLine(kurslar[i]);
            }

            //dizi temelli yapıları tek tek dönmeye yarar foreach
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
