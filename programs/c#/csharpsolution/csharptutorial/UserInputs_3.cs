using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptutorial
{
    internal class UserInputs_3
    {

        public static void UserInputDemo()
        {
            Console.WriteLine("Enter Your Name");
            string name =Console.ReadLine();
            Console.WriteLine("Your name is "+name);
            Console.WriteLine("Enter Your Age");
            int  age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is " + age);

        }
    }
}
