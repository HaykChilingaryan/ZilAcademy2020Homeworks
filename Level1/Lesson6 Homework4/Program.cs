using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson6_Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine(Math.Pow(n,i));
            }
        }
    }
}
