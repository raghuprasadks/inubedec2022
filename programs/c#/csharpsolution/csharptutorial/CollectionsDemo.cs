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
            /**
            ArrayListDemo ald = new ArrayListDemo();
            ald.demoArrayList();
            **/
            ListDemo listDemo = new ListDemo(); 
            listDemo.listDemo();
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
            Console.WriteLine("Array element at zeroindex " + zeroindex);

            Console.WriteLine("iterate :");
            foreach (var ele in arrayList)
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

    internal class Employees{

        int code;
        string name;
        string desg;
        string dept;
        int salary;

        public Employees()
        {

        }

        public Employees(int code, string name, string desg, string dept, int salary)
        {
            this.code = code;
            this.name = name;
            this.desg = desg;
            this.dept = dept;
            this.salary = salary;   

        }


        public string Informtion()
        {
            return $" Code : {this.code} Name : {this.name} Dept : {this.dept} Desg: {this.desg} Salary : {this.salary}";
        }
    }

    internal class ListDemo
    {
        public void listDemo()
        {
            List<Employees> empList = new List<Employees>();

            Employees emp1 = new Employees(1, "ravi", "IT", "SE", 25000);
            Employees emp2 = new Employees(2, "gagana", "IT", "SE", 25000);
            Employees emp3 = new Employees(3, "satvik", "Accounts", "Executive", 35000);
            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);

            foreach(Employees emp in empList)
            {
                Console.WriteLine(emp.Informtion());
            }
        }
    }


}
