using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_on
{
    internal class _2
    {
        static void FindSquare(int x)
        {
            int s = 0;
            s = x * x;
            Console.WriteLine($"Square of {x} is {s}");
        }
        static void FindCube(int x)
        {
            int c = 0;
            c = x * x * x;
            Console.WriteLine($"Cube of {x} is {c}");
        }
        static void Main(String[] Args)
        {
            int x;
            Console.WriteLine("Enter a no : ");
            x = int.Parse(Console.ReadLine());
            FindSquare(x);
            FindCube(x);
        }
    }
}