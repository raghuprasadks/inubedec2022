using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptutorial
{
    public delegate void MyDelegate(string msg);
    internal class DelegateDemo
    {
        public static void delegateDemo()
        {
            Console.WriteLine("Regular way of calling a function");
            A.MethodA("hello A");
            B.MethodB("hello B");
            Console.WriteLine("using delegate");

            MyDelegate del1 = A.MethodA;

            del1.Invoke("hi i am calling from delegate");

            MyDelegate del2 = B.MethodB;
            del2("hi calling from delegate : 2nd way");
            Console.WriteLine("Lambda ");
            MyDelegate del3 = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            del3("lambda expression");
        }
    }

    class A
    {
        public static void MethodA(string msg)
        {
            Console.Write("Class A : Method A "+msg);
        }
    }

    class B
    {
        public static void MethodB(string msg)
        {
            Console.Write("Class B : Method B " + msg);
        }
    }
}
