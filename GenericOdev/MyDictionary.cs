using System;
using System.Collections.Generic;
using System.Text;

namespace GenericOdev
{
    class MyDictionary<T, T1>
    {
        T[] itemId;
        T1[] itemName;
        public MyDictionary()
        {
            itemId = new T[0];
            itemName = new T1[0];
        }
        
        public void Add(T ıd,T1 name)
        {
            T[] tempArray = itemId;
            T1[] tempArray1 = itemName;


            itemId = new T[itemId.Length + 1];
            itemName = new T1[itemName.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                itemId[i] = tempArray[i];
                itemName[i] = tempArray1[i];
            }
            itemId[itemId.Length - 1] = ıd;
            itemName[itemName.Length - 1] = name;
            
        }
        public int Count
        {
            get { return itemId.Length; }
        }
        public T1[] Items
        {
            get { return itemName; }
        }
    }
}
