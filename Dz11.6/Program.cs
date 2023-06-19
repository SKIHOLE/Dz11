using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz11._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("zds");
            arrayList.Add(new Myclass());
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            Console.ReadLine();
        }
    }
    class Myclass
    {

    }
}
