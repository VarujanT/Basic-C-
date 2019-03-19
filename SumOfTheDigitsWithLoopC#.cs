using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using static System.Math;

namespace SumOfTheDigitsWithLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter a number ");
            int x = int.Parse(ReadLine());
            int n;
            n = x;
            int sum = 0;
            while (n!=0)
            {
                sum = sum + n % 10;
                n = n / 10; 
            }
            WriteLine("The sum of the digits is: " + sum);
        }
    }
}