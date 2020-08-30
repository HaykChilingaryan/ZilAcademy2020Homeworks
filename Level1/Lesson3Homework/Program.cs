using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework 3.1
            int a = 40;
            int b = 67;
            int res = a - b;
            Console.WriteLine(res) ;
            res = a + b;
            Console.WriteLine(res);
            res = a * b;
            Console.WriteLine(res);
            res = a / b;
            Console.WriteLine(res);
            res = a % b;
            Console.WriteLine(res);

            //Homework 3.2
            byte c = 2;
            checked
            {
                unchecked
                {
                    c = (byte)(c + 121);
                }
            }
            Console.WriteLine(c);
            //checked
            //{
            //    c = (byte)(c + 289);
            //}

            //Homework 3.3 
            float f = 3.54f;
            float r = 1.77f;
            float resf = f + r;
            Console.WriteLine(resf);
             resf = f * r;
            Console.WriteLine(resf);
            resf = f / r;
            Console.WriteLine(resf);
            resf = f - r;
            Console.WriteLine(resf);
        }
    }
}
