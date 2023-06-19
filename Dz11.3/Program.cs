using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz11._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            myDictionary.Add("One", 1);
            myDictionary.Add("Two", 2);
            myDictionary.Add("Three", 3);

            Console.WriteLine("Total pairs in dictionary: " + myDictionary.Count);

            Console.WriteLine("Value for key 'Two': " + myDictionary.GetValue("Two"));

            Console.ReadLine();
        }
    }
    class Dictionary<TKey, TValue>
    {
        private TKey[] keys;
        private TValue[] values;
        private int count;

        public int Count { get { return count; } }

        public Dictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
            count = 0;
        }

        public void Add(TKey key, TValue value)
        {
            Array.Resize(ref keys, count + 1);
            Array.Resize(ref values, count + 1);

            keys[count] = key;
            values[count] = value;

            count++;
        }

        public TValue GetValue(TKey key)
        {
            for (int i = 0; i < count; i++)
            {
                if (keys[i].Equals(key))
                {
                    return values[i];
                }
            }

            throw new Exception("Key not found in dictionary.");
        }
    }
}
