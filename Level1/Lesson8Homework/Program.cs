using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson8Homework
{
    class Program
    {
        static void AllDivisors(int n)
        {
            for (int i = 1; i <= n/2; i++)
            {
                if(n%i == 0)
                {
                    Console.WriteLine($"{i} is a divisor of n");
                }
            }
        }

        static int SumOfAllDivisors(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        static double SumOverCount(int n)
        {
            double sum = 0;
            double count = 0;
            double res = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                    count++;
                }
            }
            res = sum / count;
            return res;
        }

        static bool IsPowerof3(int n)
        {
            for (int i = 1; i <= n; i*=3)
            {
                if (i == n)
                {
                    return true;
                }
            }
            return false;
        }

        static int MaxPowerOf2(int n)
        {
            int res = 0;
            for (int i = 1; i <= n; i *= 2)
            {
                if (i*2 >= n)
                {
                    res = i;
                }
            }
            return res;
        }

        static int MinPowerOf2(int n)
        {
            int res = 0;
            for (int i = 1; i < n; i *= 2)
            {
                if (i * 2 > n)
                {
                    res = i*2;
                }
            }
            return res;
        }
        static void ReverseWithZeros(int n)
        {
            int res = 0;
            while(n!=0)
            {
                res = 10*((res * 10) + n % 10);
                n /= 10;
            }
            Console.WriteLine(res);
        }

        static void Problem30()
        {
            int sum = 0;
            int num1, num2;
            bool b = true;
            for (int i = 1122; i < 1123; i++)
            {
                int n = i;
                while (n!=0)
                {
                    int k = n % 10;
                    int t = n / 10;
                    while (t != 0)
                    {
                        if (k == t % 10)
                        {
                            t = 0;
                            n = 0;
                            b = false;
                        }
                        t /= 10;
                    }
                    n /= 10;
                }
                if(b==false)
                {
                    continue;
                }
                int p = i;
                for (int j = 0; j < 4; j++)
                {
                    sum += p % 10;
                    p /= 10;
                }
                num1 = i % 100;
                num2 = i / 100;
                if(num2-num1 == sum)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            //AllDivisors(18);
            //Console.WriteLine(SumOverCount(18) );
            //Console.WriteLine(IsPowerof3(27));
            //Console.WriteLine(MaxPowerOf2(5000)); 
            //Console.WriteLine(MinPowerOf2(93082));
            //ReverseWithZeros(34);
            Problem30();


        }

    }
}
