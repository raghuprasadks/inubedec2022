using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptutorial
{
    internal class AbstractDemo
    {
        public static void abstractDemo()
        {
            RBI bank = new SBI();
            float roi =bank.RateOfInterest();
            float si = bank.SimpleInterest(10000, roi,1);

            Console.WriteLine("SI : SBI " + si);

            bank = new HDFC();
             roi = bank.RateOfInterest();
             si = bank.SimpleInterest(10000, roi, 1);

            Console.WriteLine("SI : HDFC " + si);


        }
    }

    internal abstract class RBI
    {

        
        public abstract  float RateOfInterest();

        public float SimpleInterest(int principal,float roi,int time)
        {
            return (principal * roi * time);
        }

    }

    internal class SBI : RBI
    {
        public override float RateOfInterest()
        {
            return .05f;
        }
    }

    internal class HDFC : RBI
    {
        public override float RateOfInterest()
        {
            return .06f;
        }
    }

}
