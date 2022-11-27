using System;
using machines;
using autoparking;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Automobiles
{
    class MainClass
    {
        public static void Print(params string[] args)
        {
            foreach (var arg in args)
                Console.Write(arg + " ");
        }
        public static void Main(string[] args)
        {
            Dictionary<string, int> carg = new Dictionary<string, int>() { {"Beton",2000},{ "Pesok",1000} };
            Truck car1 = new Truck("Volvo", 1000, 1990,4000, "Petrov Alexey", carg);
            Car car2 = new Car("Lada", 2, 2018);
            Dictionary<string,int> spis = new Dictionary<string, int>() { { "Engine", 2003 }, { "Wheel", 2010 } };
            PassengerCar car3 = new PassengerCar("LEXUS", 500, 1997, 5 ,spis);
            List<Car> cars = new List<Car>();
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            Autopark RonaldoCars = new Autopark("RonaldoCars", cars);
            //car1.Brand = "mersedes";
            //Print(car1.ToString());
            //Console.WriteLine(car3.Find("Engine"));
            //car3.ListOfBook();
            Print(RonaldoCars.ToString());
        }
    }
}