using System;
using System.Net;
using System.Reflection.Metadata.Ecma335;

namespace DZ1Csharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(n - Math.Abs(i - j));
                }
                Console.Write("\n");
            }
        }
    }
}