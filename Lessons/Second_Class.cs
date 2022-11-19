using System;
using ConsoleApp4;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WaspClassTutorial
{
    class MainClass
    {
        public static void Print(params string[] args)
        {
            foreach (var arg in args)
                Console.Write(arg + " ");
        }
        public static void Main(string [] args)
        {
            Human hom = new Human(22, 88, 163, 55);
            Child child = new Child(12, 87, 164, 50);
            Human homo2 = new Child(13, 87, 164, 50);
            Oldman homo = new Oldman(89, 120, 170, 60); //поднимаем класс Олдмана до класса человека
            //Oldman oldman = homo as oldman;
            child.Age = 64;
            Print(hom?.ToString()); //? -вопросительный знак предотвращает вылет программы при присваивании null
            Print(homo2?.ToString());
            Print(homo.Age.ToString());

            //такая же конструкция:
            //if (homo is Oldman oldman) //Oldman oldman = homo as oldman как в строчке 21
            if (homo is Oldman)// если можно класс человека опустить до класса Олдмана
                homo.Pension(178);
            else { Console.Write("He is too younng for this "); }
        }
    }
}