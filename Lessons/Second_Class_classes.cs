using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Human// базовый клкасс
    {
        public virtual int Age//наследники класса хюман могут менять это свойство эйдж
        {
            get { return _age; }
            set
            {
                if (value > 0)
                    _age = value;
            }
        }
        public override string ToString()//override - Есть несколько версий оверрайдов. Применяется например
        {
            return $"Age: {_age}\nIQ: {_iq}\nHeight: {_height}\n Weight:{_weight}\n";
        }
        protected int _age;//protected  - доступно только в классовой иерархии. Для сохранения инкапсуляции
        protected int _iq;
        protected int _height;
        protected int _weight;

        public Human(int age, int iq, int height, int weight)
        {
            this._age = age;
            this._iq = iq;
            this._height = height;
            this._weight = weight;
            FavCar = "Audi";
        }
        public Human(int age)
        {
            _age = age;
        }
        private string FavCar { get; set; }
    }
    public class Child : Human
        {
            public Child(int age, int iq, int height, int weight) : base(age, iq, height, weight) { }
            public bool IsTeenage
            {
                get
                {
                    return 11 < _age && _age < 18;
                }
            }
            public override int Age
            {
                set
                {
                    if (value > 0 && value < 19)
                        _age = value;
                    else
                        Console.WriteLine("He is too old");
                }
            }
    }
    sealed public class Oldman : Human //sealed -запрещает классу наследоваться. Либо всему классу наследовать, либо только одному из свойств меняться. Например для класса VeryOldman
    {
        public Oldman(int age, int iq, int height, int weight) : base(age, iq, height, weight) { }
        public override int Age
        {
            set
            {
                if (value > 45)
                    _age = value;
            }
        }
        public int Pension(int rubles)
        {
            return (100 - Age) * rubles;
        }
    }
}

