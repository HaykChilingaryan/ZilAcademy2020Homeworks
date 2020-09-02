using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variant 1
            float a = float.Parse(Console.ReadLine());
            if (a > 0 && a % 1 == 0)
            {
                if (a % 2 != 0)
                {
                    Console.WriteLine("Natural and odd");
                }
                else
                    Console.WriteLine("Natural but not odd");
            }
            else
            {
                Console.WriteLine("Not Natural");
            }

            //Variant 2
            Console.WriteLine(a > 0 && a % 1 == 0 ? a % 2 != 0 ? "Natural and odd": "Natural but not odd" : "Not Natural");
        }
    }
}
