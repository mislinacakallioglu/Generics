using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
          Dictionary<string, int> sehirler = new Dictionary<string, int>();
            sehirler.Add("Ankara", 06);
            sehirler.Add("İstanbul", 34);
            sehirler.Add("İzmir", 35);
           
            Console.WriteLine(sehirler.Count);
        }
    }
    class MyDictionary<TKey,TValue> // Generic class
    {
        TKey[] tkey;
        TValue[] tvalue;
        public MyDictionary()
        {
            tkey = new TKey[0];
            tvalue = new TValue[0];
        }

        public void Add(TKey key,TValue value)
        {
            TKey[] tempKeys = tkey;
            TValue[] tempValues = tvalue;
            tkey = new TKey[tkey.Length + 1];
            tvalue = new TValue[tvalue.Length + 1];
           
            for (int i = 0; i < tempKeys.Length; i++)
            {
                tkey[i] = tempKeys[i];
                tvalue[i] = tempValues[i];
            }
            tkey[tkey.Length - 1] = key;
            tvalue[tvalue.Length - 1] = value;
        }
  
        public int Count
        {
            get { return tkey.Length; }
        
        }

    }
}

