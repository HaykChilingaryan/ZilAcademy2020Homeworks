using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            //int c = a;
            //a = b;
            //b = c;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine(a+ " "+ b);
            
        }
    }
}
