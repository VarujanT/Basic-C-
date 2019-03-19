using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using static System.Math;

namespace SumofThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
			WriteLine("Enter the number");
            int x = int.Parse(ReadLine());
            int y = int.Parse(ReadLine());
            int z = int.Parse(ReadLine());
            int sum = x + y + z;
            WriteLine("The sum of the numbers is " + sum);
        }
    }
}