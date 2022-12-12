using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandboxbasics1
{
    public delegate void Notify(); //delegate
    internal class EventsDemo
    {
        public event Notify ProcessCompleted; //event
        public void StartProcess()
        {
            Console.WriteLine("process started");
            OnProcessCompleted();

        }

        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }
    }
   
}
