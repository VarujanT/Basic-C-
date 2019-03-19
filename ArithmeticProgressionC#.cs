using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using static System.Math;

namespace ArithmeticProgression
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(ReadLine());
            int y = int.Parse(ReadLine());
            int z = int.Parse(ReadLine());
            int d = y - x;
            int t = x + (z - 1) * d;
            WriteLine(d);
        }
    }
}