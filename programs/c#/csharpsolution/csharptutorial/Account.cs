using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptutorial
{
    internal class Account
    {
        public int actno;
        public string name;
        public string email;
        public long mobile;
        public string idproof;
        public int balance;
        public Account(string name, string email, long mobile, string idproof)
        {
            this.name = name;
            this.email = email;
            this.mobile = mobile;
            this.idproof = idproof;
            
            Random random = new Random();
            this.actno = random.Next(1,100);
            Console.WriteLine("random account number " + this.actno);
                            
         }

        public int deposit(int actno,int amttodeposit)
        {
            this.balance = this.balance + amttodeposit;
            return this.balance;
        }
    }
}
