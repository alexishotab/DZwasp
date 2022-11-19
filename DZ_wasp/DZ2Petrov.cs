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
            string c = "";
            while (n != 0)
            {
                c = c + Convert.ToString(n % 2);
                n/=2;
            }
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}