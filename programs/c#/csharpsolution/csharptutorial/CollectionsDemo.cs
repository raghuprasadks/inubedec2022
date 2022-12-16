using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptutorial
{
    internal class CollectionsDemo
    {
        internal static void DemoCollections()
        {
            ArrayListDemo ald = new ArrayListDemo();
            ald.demoArrayList();
        }
    }

    internal class ArrayListDemo
    {

        internal void demoArrayList()
        {
            Console.WriteLine("Array List : Adding items");
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("two");
            arrayList.Add(true);
            arrayList.Add(5.6);
            int zeroindex = (int)arrayList[0];
            Console.WriteLine("Array element at zeroindex "+ zeroindex);

            Console.WriteLine("iterate :");
            foreach(var ele in arrayList)
            {
                Console.WriteLine(ele);
            }

            arrayList.Insert(2, "insert");

            Console.WriteLine("iterate :after insert");
            foreach (var ele in arrayList)
            {
                Console.WriteLine(ele);
            }

            arrayList[1] = "twenty two";

            arrayList.Remove("twenty two");
            Console.WriteLine("iterate :after update and remove");
            foreach (var ele in arrayList)
            {
                Console.WriteLine(ele);
            }














        }


    }
}
