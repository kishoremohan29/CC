using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_on
{
    internal class _3
    {
        static void Main(String[] Args)
        {
            int x, y;
            bool result;
            Console.WriteLine("Enter the value for X");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value for Y");
            y = int.Parse(Console.ReadLine());
            if (x < y)
            {
                result = true;
                Console.WriteLine($"The result of whether X is less than Y is {result}");
            }
            else
            {
                result = false;
                Console.WriteLine($"The result of whether X is less than Y is {result}");
            }
        }
    }
}