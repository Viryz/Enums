using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{


    class Program
    {
        static class MyStaticClass
        {
            public static void Print(string str, int color)
            {
                Console.ForegroundColor = (ConsoleColor)color;
                Console.WriteLine(str);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of color: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();

            MyStaticClass.Print(str, n);


            Console.ReadLine();
        }
    }
}
