using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0, mult = 1;
            while(number!=0)
            {
                sum += number % 10;
                mult *= number % 10;
                number /= 10;
            }
        }
    }
}
