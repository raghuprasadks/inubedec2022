using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandboxbasics1
{
    public delegate void MyDelegate(String msg);
    internal class DelegateDemo
    {
        public static void invokeDelegate()
        {
            MyDelegate del = new MyDelegate(methodA);
            del("Delegate invoking: ");
            del = methodA;
            del.Invoke("invoking delegate using invoke");
            del("Welcome to delegate");

            del=DelClass.methodB;
            del("Greetings from DelClass.methodB");

            Console.WriteLine("Lambda");
            del = (string msg) => Console.WriteLine("Calling from lambda" +msg);
            del("hi from lambda");
            
            Console.WriteLine("Passing delegate as a parameter");

            delegateAsParam(del);
        }

        public static void delegateAsParam(MyDelegate  del)
        {
            del("Delegate as param");

        }

        public static void methodA(string message)
        {
            Console.WriteLine("method A "+message);
        }
    }

    internal class DelClass
    {

        public static void methodB(string message)
        {
            Console.WriteLine("DelClass:methodB");
        }
    }

}   
