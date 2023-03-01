using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x ra vared konin ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y rw vared konin ");
            double y = Convert.ToInt32(Console.ReadLine());
            double result = Math.Abs(y-x);
            result = (x * result) + y;
            result = Math.Sqrt(result);
            x = Math.Cos(x);
            y = Math.Asin(y);
            y = Math.Sqrt(y);
            Console.Write(" javab = ");
            Console.WriteLine(result);
        }

    }
 }
