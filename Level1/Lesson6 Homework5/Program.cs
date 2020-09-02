using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i+=2)
            {
                sum += i; 
            }
            Console.WriteLine(sum);
        }
    }
}
