using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework 2.1
            byte byteNumber = 23;
            short shortNumber = 2323;
            int intNumber = 22323231;
            long longNumber = 10349;
            float floatNumber = 12010;
            double doubleNumber = 32.22;
            bool boolVariable = true;
            char character = 'c';
            string text = "My name is Hayk";

            //Homework 2.2 Case1
            byte x = 255;
            bool smth = x + 1 < x;
            Console.WriteLine(smth);

            //Homework 2.2 Case2
            byte k = 255;
            byte b = (byte)(k + 1);
            Console.WriteLine(b);

            string fName = "Hayk";
            string lName = "Chilingaryan";
            Console.WriteLine(fName+" "+lName);
            
        }
    }
}
