using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week_2_Challenges_LA
{
    [TestClass]
    public class Greeter
    {
        // CHALLENGE A
        [TestMethod]

        public string Greeting(string name)
        {

            string greeting = $"Hello {name}";
            return greeting;
        }

        [TestMethod]
        public void Hello()
        {
            string inputName = Greeting("Josh");
            Console.WriteLine(inputName);
        }


        // CHALLENGE B
        public string Farewell(string name)
        {
            string farewell = $"It was nice to meet you {name}";
            return farewell;
        }

        [TestMethod]
        public void Goodby()
        {
            string inputName = Farewell("Josh");
            Console.WriteLine(inputName);
        }

        // CHALLENGE C
        public string GoodMorning(string name)
        {
            string goodMorning = $"Have a nice morning {name}";
            Console.WriteLine(goodMorning);
            return goodMorning;
        }
        public string GoodAfternoon(string name)
        {
            string goodAfternoon = $"have a nice afternoon {name}";
            Console.WriteLine(goodAfternoon);
            return goodAfternoon;
        }
        public string GoodNight(string name)
        {
            string goodNight = $"Have a good night {name}";
            Console.WriteLine(goodNight);
            return goodNight;
        }

        [TestMethod]

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

        [TestMethod]
        public void TimeGreeting()
        {
            string now = DateTime.Now.ToString("17");
            int dateTime = Int16.Parse(now);

            string name = "josh";
            if (dateTime < 12)
            {
                GoodMorning(name);
            }
            if (dateTime >= 12 && dateTime < 17)
            {
                GoodAfternoon(name);
            }
            if (dateTime >= 17)
            {
                GoodNight(name);
            }


     
        }

     
        
      



    }

    


}
