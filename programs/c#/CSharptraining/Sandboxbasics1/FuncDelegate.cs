using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandboxbasics1
{
    internal class FuncDelegate
    {

        static int sum(int x,int y)
        {
            return x + y;
        }

        internal static void funcDelegateDemo()
        {
            Console.WriteLine("funcDelegate");
            Func<int,int,int> add = sum;
            int result =add(10, 20);
            Console.WriteLine(result);
        }

        internal static void anonymousFunc()
        {
            Func<int> getRandomNumber = delegate ()
            {
                Random rnd = new Random();
                return rnd.Next(1, 100);
            };

            Console.WriteLine("anonymousFunc:random " +getRandomNumber);
        }

        internal static void lambdaFunc()
        {
            Func<int> getRandomNumber = () => new Random().Next(1, 100);

            Console.WriteLine("lambdaFunc:random " + getRandomNumber);
            //Or 

            Func<int, int, int> Sum = (x, y) => x + y;
            Console.WriteLine("lambdaFunc:sum " + Sum(10,23));

        }
    }
}
