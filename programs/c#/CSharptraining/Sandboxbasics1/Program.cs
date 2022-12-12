using Sandboxbasics1;
using System.Runtime.Intrinsics.X86;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        /**
         DelegateDemo.invokeDelegate();
         FuncDelegate.funcDelegateDemo();

         FuncDelegate.anonymousFunc();
         FuncDelegate.lambdaFunc();
        
         ActionDelegateDemo.ActionDelegate();
        
        PredicateDelegateDemo.PredicateDelegate();
        
        AnonymousMethodDemo.AnonymousMethod1();
        
        EventsDemo ed = new EventsDemo();
        ed.ProcessCompleted += ed_ProcessCompleted; // register with an event
        ed.StartProcess();
        

        ProcessBusinessLogic bl = new ProcessBusinessLogic();
        bl.ProcessCompleted += bl_ProcessCompleted;
        bl.StartProcess();
        **/
        GenericsDemo.Generics();


    }

    // event handler
    public static void ed_ProcessCompleted()
    {
        Console.WriteLine("Process Completed");
    }

    public static void bl_ProcessCompleted(object sender,bool IsSuccessful)
    {
        Console.WriteLine("process " + sender + (IsSuccessful ? "Completed Successfully" : "failed"));
    }
    

}

