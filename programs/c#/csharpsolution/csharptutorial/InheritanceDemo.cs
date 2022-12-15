using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace csharptutorial
{
    internal class InheritanceDemo
    {
        public static void demoInheritance()
        {
            Bike mybike = new Bike(007, "Ranga", "Bajaj", "Pulsor", "Black", 159000);
            mybike.start();
            mybike.move();
            mybike.move();
            mybike.move();
            mybike.stop();

            Vehicle bike2 = new Bike(008, "Ranga", "Yamaha", "RX 100", "Red", 169000);
            bike2.start();
            bike2.move();
            bike2.stop();
        }
    }

    internal class Vehicle
    {
        internal int regno;
        internal string owner;
        internal string make;
        internal string model;
        internal string color;
        internal int price;
        internal int speed;

        public Vehicle()
        {

        }

        public Vehicle(int regno, string owner, string make, string model, string color, int price)
        {
            this.regno = regno;
            this.owner = owner;
            this.make = make;
            this.model = model;
            this.color = color;
            this.price = price;
                     
        }

        public virtual void start()
        {
            Console.WriteLine("Vehicle:Button Start");
            this.speed = 0;
        }
        public void move()
        {
            
            this.speed = this.speed +5;
            Console.WriteLine("Vehicle:moved with speed of "+this.speed);
        }

        public void stop()
        {

            this.speed = 0;
            Console.WriteLine("Vehicle:stopped");
        }

    }
    internal class Bike : Vehicle
    {
        public Bike(int regno, string owner, string make, string model, string color, int price):base(regno, owner,make,model,color,price)
        {

        }
        public override void start()
        {
            Console.WriteLine("Bike:Kick Start");
            this.speed = 0;
        }
    }


}
