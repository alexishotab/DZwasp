using System;
using System.Net;
using System.Reflection.Metadata.Ecma335;

namespace DZ4Csharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            ushort a = ushort.Parse(Console.ReadLine());
            ushort b = ushort.Parse(Console.ReadLine());
            ushort c = ushort.Parse(Console.ReadLine());
            ushort d = ushort.Parse(Console.ReadLine());
            long answer;
            answer = (long)a | (long) b << 16 | (long)c << 32 | (long)d << 48;
            string binary = Convert.ToString(answer, 2);
            Console.WriteLine(binary);
            Console.WriteLine(answer);
        }
    }
 }
