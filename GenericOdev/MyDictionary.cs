using System;
using System.Collections.Generic;
using System.Text;

namespace GenericOdev
{
    class MyDictionary<Tkey, Tvalue>
    {
        Tkey[] keys=new Tkey[0];
        Tvalue[] values= new Tvalue[0];

        //public MyDictionary()
        //{
        //    keys = new Tkey[0];
        //    values = new Tvalue[0];
        //}
        
        public void Add(Tkey key,Tvalue value)
        {
            Tkey[] tempKey = keys;
            Tvalue[] tempValue = values;


            keys = new Tkey[keys.Length + 1];
            values = new Tvalue[values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
            
        }
        public int Count
        {
            get { return keys.Length; }
        }
        public Tvalue[] Items
        {
            get { return values; }
        }
    }
}
