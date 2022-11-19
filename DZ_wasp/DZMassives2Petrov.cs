using System;
using System.Net;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int[] numbers = new int[a];
            double answer = 0;
            for (int i = 0; i < a; i++)
            {
                int x = int.Parse(Console.ReadLine());
                numbers[i] = x;
            }
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < numbers.Length-1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int cash = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = cash;
                    }
                }
            }
            for (int i = 0; i < a; i++)
                if (i==k-1)
                    Console.Write(numbers[i]);

            //string binary = Convert.ToString(answer, 2);

        }
    }
}