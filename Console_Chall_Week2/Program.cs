using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Chall_Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Greeter greeter = new Greeter();
            greeter.DayTimeGreeting();
            greeter.TimeGreeting();
            greeter.Greeting("Ben");
            greeter.Hello();
            greeter.Farwell("Ben");


            Console.ReadLine();
            
        }
    }
}
