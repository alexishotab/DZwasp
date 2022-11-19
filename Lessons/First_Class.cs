using ConsoleApp3;//Используя чужой namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("White", "Porsche", 4);
            Car car2 = new Car() { Name="porshe", Color = "rainbow"/*, NumberOfWheels =6*/};// инициализатор, тоже самое что указание свойств в этом же файле car1.Name="porsche
            Car car3 = new Car("Yellow");

            Console.WriteLine(car2.ToString());
            Console.ReadLine();
        }
    }
}

    