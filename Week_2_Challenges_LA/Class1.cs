using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Challenges_LA
{
   
    class Class1
    {
        Greeter greeter = new Greeter();
        [TestMethod]
        public void CallAllMethods()
        {
            string name = "Ben";
            greeter.GoodMorning(name);
            greeter.GoodAfternoon(name);
        }
    }
}
