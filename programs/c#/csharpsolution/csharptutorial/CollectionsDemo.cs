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
           
            ListDemo listDemo = new ListDemo();
            listDemo.listDemo();
            **/
            AccountManagement actmgmt = new AccountManagement();
            actmgmt.manageAccount();
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

    internal class Employees
    {

        int code;
        string name;
        string desg;
        string dept;
        // int salary;
        public int salary { get; set; }

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

            int totalsal = 0;

            foreach (Employees emp in empList)
            {
                Console.WriteLine(emp.Informtion());
                totalsal = totalsal + emp.salary;
            }

            Console.WriteLine("total salary is " + totalsal);
        }
    }

    internal class AccountManagement
    {
        public void manageAccount()
        {
            List<Account> actList = new List<Account>();

            Account act1 = new Account("ravi", "ravi@gmail.com", 999999L,"Aadhar-1");
            actList.Add(act1);

            int actnum1 = act1.actno;
            Console.WriteLine("act num1 " + actnum1);
            act1.deposit(actnum1, 10000);

            Account act2 = new Account("ramya", "ramya@gmail.com", 999999L, "Aadhar-1");
            actList.Add(act2);

            int actnum2 = act2.actno;
            Console.WriteLine("act num2 " + actnum1);
            act2.deposit(actnum1, 25000);


            
            int totalbalance = 0;
            int maxbalance = 0;
            string maxbalactholder = "";
            string actinfo = "";
            foreach (Account act in actList)
            {
                Console.WriteLine(act.Information());
                totalbalance = totalbalance + act.balance;

                int actbal = act.balance;

                if (actbal > maxbalance)
                {
                    maxbalance = actbal;
                    maxbalactholder = act.name;
                    actinfo = act.Information();
                }
            }

            Console.WriteLine("total totalbalance is " + totalbalance);
            Console.WriteLine("maximum balance is " + maxbalance);
            Console.WriteLine("maximum balance account holder is " + maxbalactholder);
            Console.WriteLine("Account information " + actinfo);
        }
    }
}
