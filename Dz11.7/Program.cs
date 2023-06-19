using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz11._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intValue = MyClass.FactoryMethod<int>();
            Console.WriteLine("Factory Method Result (int): " + intValue);
            string stringValue = MyClass.FactoryMethod<string>();
            Console.WriteLine("Factory Method Result (string): " + stringValue);
            Console.ReadLine();
        }
    }
    class MyClass
    {
        public static T FactoryMethod<T>()
        {
            return default(T);
        }
    }
}
