using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using static System.Math;

namespace TheSumOfaThreeDigitNumber//without loop
{
    class Program
    {
        static void Main(string[] args)
        {
			WriteLine("Enter a 3 digit number ");
            int x = int.Parse(ReadLine());
            int sum = x % 10 + (x / 10) % 10 + (x / 100);
            WriteLine("The sum of the 3 digits is: " + sum);
        }
    }
}