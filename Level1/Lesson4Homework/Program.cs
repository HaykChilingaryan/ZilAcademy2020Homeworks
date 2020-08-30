using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Homework 4.1
            string text = Console.ReadLine();

            string num = Console.ReadLine();
            int res = Convert.ToInt32(num);
            Console.WriteLine(res);

            num = Console.ReadLine();
            res = Convert.ToByte(num);
            Console.WriteLine(res);

            num = Console.ReadLine();
            res = Convert.ToChar(num);
            Console.WriteLine(res);

            num = Console.ReadLine();
            double dres = Convert.ToDouble(num);
            Console.WriteLine(dres);

            string num1 = Console.ReadLine();
            int res1 = int.Parse(num1);
            Console.WriteLine(res1);

            num1 = Console.ReadLine();
            double dres1 = double.Parse(num1);
            Console.WriteLine(dres1);

            num1 = Console.ReadLine();
            float fres1 = float.Parse(num1);
            Console.WriteLine(fres1);

            //Homework 4.2
            string n = Console.ReadLine();
            int number = Convert.ToInt32(n);
            int sum = 0, mult = 1;
            for (int i = 0; i < n.Length; i++)
            {
                sum += number % 10;
                mult *= number % 10;
                number /= 10;
            }
            Console.WriteLine(sum + " " + mult);

            //Homework 4.3

            string txt = Console.ReadLine();
            float fnumber1 = float.Parse(txt);
            txt = Console.ReadLine();
            float fnumber2 = float.Parse(txt);
            bool b = fnumber1 > fnumber2;
            Console.WriteLine(b);
            b = fnumber1 < fnumber2;
            Console.WriteLine(b);
            b = fnumber1 >= fnumber2;
            Console.WriteLine(b);
            b = fnumber1 <= fnumber2;
            Console.WriteLine(b);
            b = fnumber1 == fnumber2;
            Console.WriteLine(b);
        }
    }
}
