using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandboxbasics1
{
    internal class ProcessBusinessLogic
    {
        public event EventHandler<bool> ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process Started");
            try
            {
                //uncomment following to see the result
                // throw new NullReferenceException();
                OnProcessCompleted(true);
            }catch(Exception ex)
            {
                OnProcessCompleted(false);
            }
        }

        protected virtual void OnProcessCompleted(bool IsSuccessful)
        {
            ProcessCompleted?.Invoke(this,IsSuccessful);
        }

    }

    
}
