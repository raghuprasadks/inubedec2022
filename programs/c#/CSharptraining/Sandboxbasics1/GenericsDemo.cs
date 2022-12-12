using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandboxbasics1
{
    internal class GenericsDemo
    {
        internal static void Generics()
        {
            DataStore<string> strStore = new DataStore<string>();
            strStore.Data = "Hello World";
            Console.WriteLine(strStore.Data);


            DataStore<int> intStore = new DataStore<int>();
            intStore.Data = 100;
            Console.WriteLine(intStore.Data);

            KeyValuePair<int, string> kvp = new KeyValuePair<int, string>();
            kvp.Key = 100;
            kvp.Value = "Hundred";
            Console.WriteLine(kvp.Key + " , " + kvp.Value);
        }
    }

    class DataStore<T>
    {
        public T Data { get; set; } 
    }

    class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }
}
