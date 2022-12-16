using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptutorial
{
    internal interface IUniversalRemote
    {
         void SwitchOn();
        public void SwitchOff();
        public int ChangeVolume(int vol);
        public string ChangeChannel(string chanel);

    }
}
