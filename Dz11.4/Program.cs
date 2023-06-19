using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dz11._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class ArrayList<T>
    {
        private T[] array;
        public ArrayList(params T[] array)
        {
            this.array = array;
        }
        public void Add(T jrray)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = jrray;
        }
        public void Clear()
        {
           array = new T[0];   
        }
        public void Insert(int index, T jrray)
        {
            T[] newArray = new T[array.Length + 1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            newArray[index] = jrray;
            for (int i = index + 1; i < newArray.Length; i++)
            {
                newArray[i] = array[i - 1];
            }
            array = newArray;
        }
        public void RemoveAt(int index)
        {
            T[] newArray = new T[array.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = index; i < newArray.Length; i++)
            {
                newArray[i] = array[i + 1];
            }
            array = newArray;
        }
        public bool Contain(T item)
        {
            if (array.Contains(item))
            {
                return true;
            }
            return false;
        }
        public int Count()
        {
              return array.Length;
        }
        public int IndexOf(T item)
        {
            if (array.Contains(item))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Equals(item))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        public void Remove(T item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(item))
                {
                    T[] newArray = new T[array.Length - 1];
                    for (int b = 0; b < i; i++)
                    {
                        newArray[i] = array[i];
                    }
                    for (int b = i; b < newArray.Length; i++)
                    {
                        newArray[i] = array[i + 1];
                    }
                    array = newArray;
                }
            }
        }
    }
}
