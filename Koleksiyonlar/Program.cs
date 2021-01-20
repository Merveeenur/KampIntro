using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"engin","murat","merve","halil"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //isimler[4] = "ilker";
            //Console.WriteLine(isimler[4]);

            //List<string> isimler3 = new List<string>();// BU ŞEKİLDE DE YAPILANİLİR LİSTE EKLEMESİ
            //isimler3.Add("engin");

            List<string> isimler2 = new List<string> { "engin", "murat", "merve", "halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("İLKER");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);



        }
    }
}
