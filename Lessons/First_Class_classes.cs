using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Car
    {
        //private, public
        //private - нельзя из других программ вызывать
        //public - доступный
        public string _name;
        private string _color;//="Black" - не объявлять дефолтное значение здесь, только в класе
        private int _numberOfWheels;

        // чтобы не писать большую запись снизу можно написать "свойство"
        public string Name
        {
            get
            {
                return _name + " _car"; // необычное свойство
            }
            set
            {
                _name = value; //тут всегда value
            }
        }
        public string Color { get; set; } = "Black";// обычное свойство. Нужно выбрать одно из

        // Правило инкапуляции - нет доступа. Чтобы получить доступ к переменной, можно задать публичный метод получения имени
        public string GetName()
        {
            return _name;
        }

        public void SetName(string value)
        {
            _name = value;
        }
        private void Move()
        {
            Console.WriteLine($" {_name} car is moving");
        }

        private int GetNumberOfWheels()
        {
            return _numberOfWheels;
        }

        //отладка - f10, f11
        //КОНСТРУКТОРЫ
        //Сразу задает свойства для объекта , как аналог Class python (svoistvo1,svoistvo2): вместо class pythin:
        public Car(string color, string name, int numberOfWheels)
        {
            _color = color;
            _numberOfWheels = numberOfWheels;
            _name = name;
            Console.WriteLine("Created Personal car");
        }
        //конструктор без параметров
        public Car()
        {
            _color = "black";
            _name = "Default";
            _numberOfWheels = 4;
            Console.WriteLine("Default car created");
        }
        public Car(string color) : this() // зис - аналог селф в питоне
        {
            _color = color;
            Console.WriteLine("Car with specified car created");
        }

        
        // Метод для получения инфы об объекте
        /*public string GetInfoAboutObject()
        {
            return NumberOfWheels;
        }*/
        public override string ToString()
        {
            return $"{Name} {Color} ";
        }







    }
}

