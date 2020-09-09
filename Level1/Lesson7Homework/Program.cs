using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Homework
{
    class Program
    {
        static void PrintAndCount6(int a, int b)
        {
            int count = 0;
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
                count++;
            }
            Console.WriteLine($"Count is {count}");
        }

        static void SumOfRange7(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;  
            }
            Console.WriteLine($"Sum is {sum}");
        }

        static int FirstDivider8(int a, int b)
        {
            
            for (int i = a; i <= b; i++)
            {
                if(i%3==0)
                {
                    return i;
                }
            }
            return -1;
        }

        static double SumOfSequenceOneOverN9(int n)
        {
            double sum = 0;
            for (double i = 1; i <=n; i++)
            {
                sum += 1 / i;
            }
            return sum;
        }

        static int Sum10(int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += (n + i) * 2;
            }
            return sum;
        }

        static double Product11(int n)
        {
            double prod = 1;
            for (double i = 1; i<=n; i++)
			{
                prod *= (1+i/10);
			}
            return prod;
        }

        static void Sum13(int n)
        {
            int sq = 0;
            for (int i = 1; i <= (2*n-1); i+=2)
			{
                sq += i;
                Console.WriteLine(sq);
			}
        }

        static void Sum14(int n)
        {
           int sumOfNums = 0;
           while(n!=0)
           {
                sumOfNums+=n&10;
                n/=10;
           }
           if(n == sumOfNums*2)
           {
                Console.WriteLine("Yes");
           }
           else
            {
                Console.WriteLine("No");
            }
        }

        static double Sum12(int n)
        {
            double sum = 0;
            double k = 1.1;
            for (int i = 0; i <=  n; i++)
            {
                
                sum += k;
                k = -(k + i / 10);
            }
            return sum;
        }

        //  static int FindThatNUmber15(int n)
        //  {
        //      int k = n % 100;

        //  }

        static void SumProdCount16(int n)
        {
            int sum = 0;
            int count = 0, prod = 1;
            while(n!=0)
            {
                sum += n % 10;
                count++;
                prod *= n % 10;
                n /= 10;
            }
            Console.WriteLine($"Sum is {sum}, Count is {count}, Product is {prod}");
        }
        static void LeastOddNumber17(int n)
        {
            int min = n % 10;
            while (n != 0)
            {
                int k = n % 10;
                if(k%2!= 0 && k<min)
                {
                    min = k;
                }
                n /= 10;
            }
            if (min % 2 != 0)
            {
                Console.WriteLine($"Minimum odd number is {min}");
            }
            else
            {
                Console.WriteLine("No odd number");
            }
        }

        static void SumOfOdds18(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                if(n%10 > 4 && (n%10)%2 !=0 )
                {
                    sum += n % 10;
                }
                n /= 10;
            }
            Console.WriteLine(sum);
        }
        static void SumOfEvens19(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                if (n % 10 < 7 && (n % 10) % 2 == 0)
                {
                    sum += n % 10;
                }
                n /= 10;
            }
            Console.WriteLine(sum);
        }

        static void MinMaxsquared20(int n)
        {
            int min = n % 10;
            int max = n % 10;
            while (n != 0)
            {
                int k = n % 10;
                if (k>max)
                {
                    max = k;
                }
                if(k<min)
                {
                    min = k;
                }
                n /= 10;
            }
            Console.WriteLine((max-min)*(max - min));
        }
        static void Main(string[] args)
        {
            //PrintAndCount6(3, 5);
            //SumOfRange7(3, 5);
            //Console.WriteLine(FirstDivider8(3, 5));
            //Console.WriteLine(SumOfSequenceOneOverN9(4));
            //Console.WriteLine(Sum10(3));
            //Console.WriteLine(Product11(3));
            //Sum13(3);
            //LeastOddNumber17(4444444);
            //SumOfOdds18(7279172);
            //SumOfEvens19(7279172);
            //MinMaxsquared20(7279172);
            Console.WriteLine(Sum12(4));
        }
    }
}
