using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> isimler = new MyList<string>();
            isimler.Add("merve");
            

           // MyList<int> isimler1 = new MyList<int>(); //bu şekilde de yapabilirim

        }
    }
}
