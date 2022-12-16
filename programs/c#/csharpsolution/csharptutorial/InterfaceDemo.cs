using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptutorial
{
    internal class InterfaceDemo
    {
        public static void TestInterface()
        {
            IUniversalRemote universalRemote = new SonyTV();
            string currentChannel;
            int currentVolume;
            universalRemote.SwitchOn();
            currentChannel =universalRemote.ChangeChannel("TV18");
            Console.WriteLine("Current Channel "+currentChannel);
            currentVolume = universalRemote.ChangeVolume(20);
            Console.WriteLine("Current Volume " + currentVolume);
            universalRemote.ChangeChannel("India TV");
            universalRemote.SwitchOff();

            universalRemote = new PhilipsTV();
            universalRemote.SwitchOn();
            currentChannel = universalRemote.ChangeChannel("Sony Channel");
            Console.WriteLine("Current Channel " + currentChannel);
            currentVolume = universalRemote.ChangeVolume(22);
            Console.WriteLine("Current Volume " + currentVolume);
            universalRemote.ChangeChannel("CNBC");
            universalRemote.SwitchOff();


        }

    }

    internal class SonyTV : IUniversalRemote
    {
        bool status;
        int currentVol;
        string currentChannel;
        public string ChangeChannel(string chanel)
        {
            this.currentChannel = chanel;
            return this.currentChannel;
        }

        public int ChangeVolume(int vol)
        {
            this.currentVol = vol;
            return this.currentVol;
        }

        public void SwitchOff()
        {
            this.status = false;
            Console.WriteLine("SonyTV:SwitchedOff");

        }

        public void SwitchOn()
        {
            this.status = true;
            Console.WriteLine("SonyTV:SwitchedOn");

        }
    }


    internal class PhilipsTV : IUniversalRemote
    {
        bool status;
        int currentVol;
        string currentChannel;
        public string ChangeChannel(string chanel)
        {
            this.currentChannel = chanel;
            return this.currentChannel;
        }

        public int ChangeVolume(int vol)
        {
            this.currentVol = vol;
            return this.currentVol;
        }

        public void SwitchOff()
        {
            this.status = false;
            Console.WriteLine("PhilipsTV:SwitchedOff");

        }

        public void SwitchOn()
        {
            this.status = true;
            Console.WriteLine("PhilipsTV:SwitchedOn");

        }
    }
}
