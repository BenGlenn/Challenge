using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void CookieTests()
        {
            Cookie cookie = new Cookie();
            cookie.Name = "Snickerdoodle";
            cookie.HasNuts = false;
            cookie.GramsOfFlur = 10;

            Cookie anotherCookie = new Cookie();
            anotherCookie.Name = "Something else";

            Cookie snickerdoodle = new Cookie("Snickerdoodle", false, 11.5);
            Cookie penutButter = new Cookie("PenutButter", true, 150);
        }

        [TestMethod]
        public void VehicleTest()
        {
            Vehicle car = new Vehicle();
            car.TypeOfVehicle = VehicleType.Car;

            //Object initialisation syntax 

            Vehicle newCar = new Vehicle
            {
                Make = "Honda",
                Model = "Civic",
                TypeOfVehicle = VehicleType.Car,
           
            };
        }

    }

    
}
