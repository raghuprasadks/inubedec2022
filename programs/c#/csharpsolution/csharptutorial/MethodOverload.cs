using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptutorial
{
    internal class MethodOverload
    {

        public int add(int n1,int n2)
        {
            return n1+ n2;
        }

        public long add(long n1,long n2)
        {
            return n1 + n2;
        }

        public float add(float n1, float n2)
        {
            return n1 + n2;
        }

    }
}
