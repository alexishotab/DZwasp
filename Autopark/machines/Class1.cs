using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machines
{
    public class Car
    {
        protected string _brand;
        protected int _power;
        protected int _year;

        public string Brand { get; set; }
        public int Power { get; set; }
        public string Year { get; set; }
        public override string ToString()
        {
            return $"Brand: {_brand}\nPower: {_power}\nYear: {_year}\n";
        }
        public Car(string brand,int power, int year)
        {
            this._brand=brand;
            this._power = power;
            this._year = year;
        }

    }
    
    public class PassengerCar : Car
    {
        protected int _lotsOFpass;
        protected Dictionary<string,int> _book =new Dictionary<string, int>();
        public int lotsOFpass { get; set; }
        public string Book { get; set; }
        public PassengerCar(string brand, int power, int year, int lotsOFpass,Dictionary<string,int> book) : base(brand, power, year) {
            this._lotsOFpass = lotsOFpass;
            this._book = book;
        }
        public override string ToString()
        {
            return $"Brand: {_brand}\nPower: {_power}\nYear: {_year}\n:Lots of places: {_lotsOFpass}\n";
        }
        public void Add(string key,int value)
        {
            _book.Add(key, value);
        }
        public int Find(string key)
        {
            return _book[key];
        }
        public void ListOfBook()
        {
            foreach (string key in _book.Keys)
                Console.Write(key+ " ");
            Console.Write("\n");
            foreach (int key in _book.Values)
                Console.Write(key + " ");
            Console.Write("\n");
        }
    }
    public class Truck : Car
    {
        protected int _maxWeight;
        protected string _fio;
        protected Dictionary<string, int> _cargo; 
        public int MaxWeight { get; set; }
        public string Fio { get; set; }
        public string Cargo { get; set; }
        public Truck(string brand, int power, int year, int maxWeight, string fio, Dictionary<string, int> cargo) : base(brand, power, year)
        {
            this._maxWeight=maxWeight;
            this._fio=fio;
            this._cargo=cargo;
        }
        public override string ToString()
        {
            return $"Brand: {_brand}\nPower: {_power}\nYear: {_year}\nMax Cargo: {_maxWeight}\nFIO: {_fio}\n";
        }
        public void ChangeDriver(string name)
        {
            _fio = name;
        }
        public void ListOfCargo()
        {
            foreach (string key in _cargo.Keys)
                Console.Write(key + " ");
            Console.Write("\n");
            foreach (int key in _cargo.Values)
                Console.Write(key + " ");
            Console.Write("\n");
        }
        public void AddCargo(string key, int weight)
        {
            _cargo.Add(key, weight);
        }
        public void DeleteCargo(string key)
        {
            _cargo.Remove(key);
        }

    }
}
