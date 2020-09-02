using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            if (a%2 == 0 || a%3 ==0)
                Console.WriteLine("Divisible");
            else
                Console.WriteLine("Not Divisible");
        }
    }
}
