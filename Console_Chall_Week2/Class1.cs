using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Chall_Week2
{
    public class Greeter
    {
        public string Greeting(string name)
        {
            string greeting = $"Hello {name}";
            return greeting;
        }

        public void Hello()
        {
            string inputName = Greeting("Josh");
            Console.WriteLine(inputName);
        }

        public string Farwell(string name)
        {
            string farwell = $"It was nice to meet you {name}.";
            return farwell;
        }

        public void Goodby()
        {
            string inputName = Farwell("Josh");
            Console.WriteLine(inputName);
        }

        public string GoodMorning(string name)
        {
            string goodMorning = $"Have a nice morning {name}";
            Console.WriteLine(goodMorning);
            return goodMorning;
        }

        public string GoodAfternoon(string name)
        {
            string goodAfternoon = $"Have a nice afternoon {name}";
            Console.WriteLine(goodAfternoon);
            return goodAfternoon;
        }

        public string GoodNight(string name)
        {
            string goodNight = $"Have a good night {name}";
            Console.WriteLine(goodNight);
            return goodNight;
        }

        public void DayTimeGreeting()
        {
            int hour = 10;
            string name = "josh";
            if (hour < 12)
            {
                GoodMorning(name);
            }
            if (hour >= 12 && hour < 17)
            {
                GoodAfternoon(name);
            }
            if (hour > 17)
            {
                GoodNight(name);
            }
        }

        public void TimeGreeting()
        {
            string now = DateTime.Now.ToString("17");
            int dateTime = Int16.Parse(now);

            string name = "josh";
            if(dateTime < 12)
            {
                GoodMorning(name);
            }
            if (dateTime >= 12 && dateTime < 17)
            {
                GoodAfternoon(name);
            }
            if (dateTime > 17)
            {
                GoodNight(name);
            }
        }



    }
}
