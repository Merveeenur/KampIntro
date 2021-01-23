using System;
using System.Collections.Generic;


namespace GenericOdev
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> items = new MyDictionary<int, string>();
          
            items.Add(3, "merve");
            items.Add(4, "emir");


            Console.WriteLine(items.Count);

            items.Add(5, "cengiz");
            items.Add(6, "meltem");
           
            foreach (var liste in items.Items)
            {
                Console.WriteLine(liste);
            }
            Console.WriteLine(items.Count);
            


        }
    }
}
 