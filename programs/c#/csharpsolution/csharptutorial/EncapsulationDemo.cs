using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptutorial
{
    internal class EncapsulationDemo
    {
        public static void encapsulationDemo() {
            Employee employee = new Employee();
            employee.sal = 200000;
            Console.WriteLine("sal is " + employee.sal);
                }
                
    }

    internal class Employee
    {
        //public,private,protected,internal
        private int code;
        //private int name;
        public string name { get; set; }
        //setter and getter
        public int sal { get; set; }
    }



}
