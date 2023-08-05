using System;

namespace Delegates
{
    
    class Program
    {
        public delegate void HelloFunction(string message);
        public static void Hello(string message)
        {
            Console.WriteLine("Hello " + message);
        }
        //main function
        static void Main(string[] args)
        {
            HelloFunction del = new HelloFunction(Hello);
            del("Adir");
           
            
        }
    }
}